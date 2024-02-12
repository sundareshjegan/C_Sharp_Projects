using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ProfileManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inpform.SendUserDetailsToMainForm += GetUser;

            #region animation code
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, optionsPanel, new object[] { true });
            //gifImage = Properties.Resources.bg6;
            gifImage = new Bitmap("D:\\Sundareshwaran\\C_Sharp_Projects\\WindowsForms\\ProfileManagement\\greenPurple.gif");
            animationTimer = new Timer();
            animationTimer.Interval = 100;
            animationTimer.Tick += AnimationTimer_Tick;
            totalFrames = gifImage.GetFrameCount(System.Drawing.Imaging.FrameDimension.Time);
            animationTimer.Start();
            #endregion
        }
        #region animation varialbles and events
        private Image gifImage;
        private Timer animationTimer;
        private int currentFrame;
        private int totalFrames;
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % totalFrames;
            optionsPanel.Invalidate();
        }
        private void optionsPanel_Paint(object sender, PaintEventArgs e)
        {
            if (gifImage != null)
            {
                gifImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Time, currentFrame);
                e.Graphics.DrawImage(gifImage, ClientRectangle);
            }
        }
        #endregion

        public static event EventHandler<string> SendNewColName;
        public static event EventHandler<string> EditData;

        public static Dictionary<string, List<string>> userdetails = new Dictionary<string, List<string>>();

        private string headerFilePath = "D:\\Sundareshwaran\\C_Sharp_Projects\\WindowsForms\\ProfileManagement\\Appdata\\newcols.txt";

        private InputForm inpform = new InputForm();
        private GetColForm newColForm;
        private OptionForm optionform;

        private List<string> lines = new List<string>();
        private List<string> newCols = new List<string>();

        private string username;

        private void RetriveOldData()
        {
            using (FileStream fs = new FileStream(InputUC.filepath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string str = sr.ReadLine();
                    while (str != null && str != "")
                    {
                        lines.Add(str);
                        str = sr.ReadLine();
                    }
                }
            }
            foreach (string line in lines)
            {
                string[] temp = line.Split('|');
                //displayTable.Rows.Add(temp);

                string email = temp[0];
                List<string> userDetails = new List<string>(temp);
                userDetails.RemoveAt(0);
                if (!userdetails.ContainsKey(email))
                {
                    userdetails[email] = userDetails;
                }
                else
                {
                    userdetails[email] = userDetails;
                }
            }
            displayTable.AutoResizeColumns();
            LoadDataToDisplayTable();
        }
        private void OnLoadBtnClicked(object sender, EventArgs e)
        {
            //loadBtn.Enabled = false;
            //displayTable.Columns.Clear();
            //displayTable.Columns.Add("E-Mail", "email");
            //displayTable.Columns.Add("Name", "name");
            //displayTable.Columns.Add("DOB", "dob");
            //displayTable.Columns.Add("Phone-no", "phone");
            //displayTable.Columns.Add("ProfileImage", "phone");
            if (File.Exists(headerFilePath))
            {
                using (StreamReader sr = new StreamReader(headerFilePath))
                {
                    string colname;
                    while ((colname = sr.ReadLine()) != null)
                    {
                        displayTable.Columns.Add(colname, colname);
                        newCols.Add(colname);
                        SendNewColName?.Invoke(this, colname);
                    }
                }
            }
            RetriveOldData();
        }
        private void OnFormLoad(object sender, EventArgs e)
        {
            //displayTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetUser(object sender, List<string> user)
        {
            string[] temp = new string[user.Count];
            for(int i = 0; i < user.Count; i++)
            {
                temp[i] = user[i];
            }
            displayTable.Rows.Add(temp);

            string email = user[0];
            List<string> userDetails = new List<string>(user);
            userDetails.RemoveAt(0);
            if (!userdetails.ContainsKey(email))
            {
                userdetails[email] = userDetails;
            }
            else
            {
                userdetails[email] = userDetails;
            }
            
        }

        private void OnAddRowBtnClicked(object sender, EventArgs e)
        {
            inpform.Send("", "new");
            inpform.ShowDialog();
        }

        private void OnAddColBtnClicked(object sender, EventArgs e)
        {
            newColForm = new GetColForm();
            newColForm.SendNewColName += GetNewColName;
            newColForm.Location = addColBtn.PointToScreen(new Point(0, 0));
            newColForm.Show();
        }

        private void GetNewColName(object sender, string newColName)
        {
            newCols.Add(newColName);
            displayTable.Columns.Add(newColName, newColName);
            Width += 100;            
            SendNewColName?.Invoke(this, newColName);
            newColForm?.Dispose();

            using (FileStream fs = new FileStream(headerFilePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(string colname in newCols)
                    {
                        sw.WriteLine(colname);
                    }
                }
            }
        }

        private void OnSaveBtnClicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (FileStream fs = new FileStream(InputUC.filepath, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (KeyValuePair<string, List<string>> entry in userdetails)
                        {
                            string line = entry.Key + "|" + string.Join("|", entry.Value);
                            sw.WriteLine(line);
                        }
                    }
                    MessageBox.Show("File saved Successfully");
                }
                //Close();
            }
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            userCard.Visible = true;
            photoPanel.Visible = true;
            if (e.RowIndex >= 0 && e.RowIndex < displayTable.Rows.Count)
            {
                DataGridViewRow selectedRow = displayTable.Rows[e.RowIndex];
                
                userCard.Controls.Clear();
                userCard.Height = 50;
                profilePicBox.BackgroundImage = new Bitmap(selectedRow.Cells[4].Value?.ToString());
                for (int i = 1; i < displayTable.Columns.Count; i++)
                {
                    string columnName = displayTable.Columns[i].HeaderText;
                    object cellValue = selectedRow.Cells[i].Value;
                    string columnValue = cellValue == null ? "-" : cellValue.ToString(); // Handle null value
                    if (cellValue != null)
                    {
                        Label nameLabel = new Label
                        {
                            Text = columnName.ToUpper(),
                            AutoSize = true,
                            Location = new Point(10, i * 30),
                            Font = new Font("MV Boli", 9F, FontStyle.Bold)
                        };
                        userCard.Controls.Add(nameLabel);

                        Label valueLabel = new Label
                        {
                            Text = columnValue,
                            AutoSize = true,
                            Location = new Point(120, i * 30),
                            Font = new Font("MV Boli", 10F, FontStyle.Regular)
                        };
                        userCard.Controls.Add(valueLabel);
                        userCard.Height += 30;
                    }
                }
            }
        }

        private void OnCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < displayTable.Rows.Count)
            {
                DataGridViewRow selectedRow = displayTable.Rows[e.RowIndex];
                // EditData?.Invoke(null, selectedRow.Cells[0].Value.ToString());
                inpform.Send(selectedRow.Cells[0].Value.ToString(),"edit");
                inpform.ShowDialog();
                LoadDataToDisplayTable();
            }
        }

        private void LoadDataToDisplayTable()
        {
            loadBtn.Enabled = false;
            displayTable.Rows.Clear();
            foreach (KeyValuePair<string, List<string>> entry in userdetails)
            {
                List<string> userDetails = entry.Value;
                string[] rowData = new string[userDetails.Count + 1];
                rowData[0] = entry.Key;
                for (int i = 0; i < userDetails.Count; i++)
                {
                    rowData[i + 1] = userDetails[i];
                }
                displayTable.Rows.Add(rowData);
            }
            displayTable.Rows[0].Selected = false;
            photoPanel.Visible = false;
            userCard.Visible = false;
        }

        private void displayTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (displayTable.Rows.Count != 0)
                {
                    username = displayTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                    optionform = new OptionForm()
                    {
                        Location = displayTable.PointToScreen(e.Location),
                    };
                    optionform.SendOption += GetOption;
                    optionform.ShowDialog();
                    LoadDataToDisplayTable();
                }
            }
        }

        private void GetOption(object sender, string option)
        {
            if(option.ToLower() == "delete")
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete..\n{username}?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    userdetails.Remove(username);
                }
            }
            else if (option.ToLower() == "edit")
            {
                inpform.Send(username, "edit");
                inpform.ShowDialog();
                LoadDataToDisplayTable();
            }
        }

        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            if (sender is Button b && b.Name == "loadBtn")
                importHoverLabel.Text = "Import data from file";
            else
                saveHoverLabel.Text = "Save data";
        }

        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            importHoverLabel.Text = "";
            saveHoverLabel.Text = "";
        }
    }
}
