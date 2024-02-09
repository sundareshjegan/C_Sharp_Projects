using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.IO;

namespace ProfileManagement
{
    public partial class InputUC : UserControl
    {
        public InputUC()
        {
            InitializeComponent();

            gifImage = Properties.Resources.bg6;
            animationTimer = new Timer();
            animationTimer.Interval = 100; 
            animationTimer.Tick += AnimationTimer_Tick;
            totalFrames = gifImage.GetFrameCount(System.Drawing.Imaging.FrameDimension.Time);
            animationTimer.Start();

            Form1.SendNewColName += AddNewCol;
            Form1.EditData += SetData;
        }

        public static string filepath = "D:\\Sundareshwaran\\C_Sharp_Projects\\WindowsForms\\ProfileManagement\\Appdata\\userdetails.txt";

        public event EventHandler<List<string>> SendUserDetails;

        private List<string> details = new List<string>();
        private List<TextBox> newTextBoxes = new List<TextBox>();

        private string mode = "";

        private Image gifImage;
        private Timer animationTimer;
        private int currentFrame;
        private int totalFrames;

        private int count = 0;

        #region gif animation events
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % totalFrames;
            Invalidate();
        }
        private void InputUC_Paint(object sender, PaintEventArgs e)
        {
            if (gifImage != null)
            {
                gifImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Time, currentFrame);
                e.Graphics.DrawImage(gifImage, ClientRectangle);
            }
        }
        #endregion

        #region validateEvents
        private void OnTextBoxTextChanged(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && phoneTB.Text != "" && phoneTB.Text.Length == 10 && mailTB.Text != "" && dobTB.Text != "" && imgUrlTB.Text != "")
            {
                bool isValidEmail = Regex.IsMatch(mailTB.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

                if ((isValidEmail && mode == "edit" && Form1.userdetails.ContainsKey(mailTB.Text)) || mode=="new" && isValidEmail && !Form1.userdetails.ContainsKey(mailTB.Text))
                {
                    SubmitBtn.Enabled = true;
                    SubmitBtn.UseWaitCursor = false;
                    SubmitBtn.BackColor = Color.LightGreen;
                }
                else
                {
                    SubmitBtn.Enabled = false;
                    SubmitBtn.UseWaitCursor = true;
                    SubmitBtn.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
        }

        private void OnNameTBKeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = (!Char.IsLetter(e.KeyChar))||(e.KeyChar=='\b');
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != '\b';
        }

        private void InputUC_Load(object sender, EventArgs e)
        {
            
        }

        private void OnPhoneTBKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }
        #endregion

        private void AddNewCol(object sender, string newColName)
        {
            if (newColName == "") return;
            count++;
            Label label = new Label()
            {
                Font = nameLabel.Font,
                Text = newColName,
                Size = profileLabel.Size,
                BackColor = nameLabel.BackColor,
                ForeColor = nameLabel.ForeColor,
                Location = new Point(profileLabel.Location.X,profileLabel.Location.Y + 50 * count)
            };
            TextBox textbox = new TextBox()
            {
                Font = nameTB.Font,
                Size = nameTB.Size,
                Location = new Point(imgUrlTB.Location.X, imgUrlTB.Location.Y + 50 * count)
            };
            SubmitBtn.Location = new Point(SubmitBtn.Location.X,SubmitBtn.Location.Y + 50);

            newTextBoxes.Add(textbox);
            Controls.Add(label);
            Controls.Add(textbox);
            SendUserDetails.Invoke(sender, details);
        }

        public void SetUCData(string email,string mode)
        {
            this.mode = mode;
            if (mode.ToLower() == "new")
            {
                mailTB.Enabled = true;
                ClearData();
                return;
            }
            foreach (Control c in Controls)
            {
                if (c is TextBox t)
                {
                    t.Text = "";
                }
            }
            List<string> newdata = Form1.userdetails[email];
            mailTB.Text = email;
            mailTB.Enabled = false;
            nameTB.Text = newdata[0];
            dobTB.Value = DateTime.Parse(newdata[1]);
            phoneTB.Text = newdata[2];
            imgUrlTB.Text = newdata[3];
            profileBox.BackgroundImage = new Bitmap(newdata[3]);
            if (newdata.Count > 4)
            {
                for (int i = 4; i < newdata.Count; i++)
                {

                    newTextBoxes[i-4].Text = newdata[i];
                }
            }
        }
        private void SetData(object sender, string email)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox t)
                {
                    t.Text = "";
                }
            }
            List<string> newdata = Form1.userdetails[email];
            mailTB.Text =email;
            nameTB.Text = newdata[0];
            //dobTB.Text = newdata[1].ToString();
            phoneTB.Text = newdata[2];
            imgUrlTB.Text = newdata[3];
            profileBox.BackgroundImage = new Bitmap(newdata[3]);
            if(newdata.Count > 4)
            {
                for (int i = 0; i < newTextBoxes.Count; i++)
                {
                    newTextBoxes[i].Text = newdata[4 + i];
                }
            }
        }

        private void OnProfileBoxClicked(object sender, EventArgs e)
        {
            OpenFileDialog imagefileDialog = new OpenFileDialog();
            if(imagefileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    profileBox.BackgroundImage = new Bitmap(imagefileDialog.FileName);
                    imgUrlTB.Text = imagefileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Invalid File type..!");
                }
            }
        }

        private void OnBrouseBtnClicked(object sender, EventArgs e)
        {
            OnProfileBoxClicked(sender, e);
        }

        private void OnSubmitBtnClicked(object sender, EventArgs e)
        {
            details.Add(mailTB.Text);
            details.Add(nameTB.Text);
            details.Add(dobTB.Text);
            details.Add(phoneTB.Text);
            details.Add(imgUrlTB.Text);

            if (newTextBoxes.Count != 0)
            {
                foreach(TextBox tb in newTextBoxes)
                {
                    details.Add(tb.Text);
                }
            }
            SendUserDetails?.Invoke(this, details);
            ClearData();
        }

        private void ClearData()
        {
            foreach(Control c in Controls)
            {
                if(c is TextBox t)
                {
                    t.Text = "";
                }
            }
            profileBox.BackgroundImage = Properties.Resources.addUserImage;
            SubmitBtn.Enabled = false;
            SubmitBtn.BackColor = Color.FromArgb(255, 192, 192);
            details.Clear();
        }
    }
}
