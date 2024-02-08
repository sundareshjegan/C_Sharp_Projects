using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inpform.SendUserDetailsToMainForm += GetUser;
        }
        public static event EventHandler<string> SendNewColName;
        public static event EventHandler<string> EditData;

        public static Dictionary<string, List<string>> userdetails = new Dictionary<string, List<string>>();

        private string headerFilePath = "D:\\Sundareshwaran\\C_Sharp_Projects\\WindowsForms\\ProfileManagement\\Appdata\\newcols.txt";

        private InputForm inpform = new InputForm();
        private GetColForm newColForm;

        private List<string> lines = new List<string>();
        private List<string> newCols = new List<string>();

        private void RetriveOldData()
        {
            FileStream fs = new FileStream(InputUC.filepath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str!=null && str != "")
            {
                lines.Add(str);
                str = sr.ReadLine();
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

        private void OnFormLoad(object sender, EventArgs e)
        {
            displayTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            //inpform = new InputForm();
            inpform.ShowDialog();
            //saveBtn.Enabled = true;
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
                //string imageUrlColumnName = "ProfileImage";
                //int imageUrlColumnIndex = displayTable.Columns.Cast<DataGridViewColumn>()
                //    .FirstOrDefault(col => col.HeaderText == imageUrlColumnName)?.Index ?? -1;

                //if (imageUrlColumnIndex != -1)
                //{
                //    string imageUrl = selectedRow.Cells[imageUrlColumnIndex].Value?.ToString();
                //    if (!string.IsNullOrEmpty(imageUrl))
                //    {
                //        profilePicBox.BackgroundImage = new Bitmap(imageUrl);
                //    }
                //    else
                //    {
                //        profilePicBox.Image = null;
                //    }
                //}
            }
        }

        private void OnCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < displayTable.Rows.Count)
            {
                DataGridViewRow selectedRow = displayTable.Rows[e.RowIndex];
                EditData?.Invoke(this, selectedRow.Cells[0].Value.ToString());
                inpform.ShowDialog();
                LoadDataToDisplayTable();
            }
        }

        private void LoadDataToDisplayTable()
        {
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
        }
    }
}
