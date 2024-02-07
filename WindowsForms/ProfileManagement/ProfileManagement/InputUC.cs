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
        }

        public static string filepath = "D:\\Sundareshwaran\\C_Sharp_Projects\\WindowsForms\\ProfileManagement\\Appdata\\userdetails.txt";

        public event EventHandler<List<string>> SendUserDetails;


        private string name, phone, email, dob, imgPath;
        private List<string> details = new List<string>();
        private List<TextBox> newTextBoxes = new List<TextBox>();

        FileStream fs;
        StreamWriter sw;

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
            name = nameTB.Text;
            phone = phoneTB.Text;
            email = mailTB.Text;
            dob = dobTB.Text;
            imgPath = imgUrlTB.Text;

            if (name != "" && phone != "" && phone.Length == 10 && email != "" && dob != "" && imgPath != "")
            {
                bool isValidEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (isValidEmail)
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
            e.Handled = !Char.IsLetter(e.KeyChar);
        }

        private void InputUC_Load(object sender, EventArgs e)
        {
            
        }

        private void OnPhoneTBKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }
        #endregion

        private void AddNewCol(object sender, string newColName)
        {
            count++;
            Label label = new Label()
            {
                Font = nameLabel.Font,
                Text = newColName,
                BackColor = nameLabel.BackColor,
                ForeColor = nameLabel.ForeColor,
                Location = new Point(nameLabel.Location.X,profileLabel.Location.Y + 50 * count)
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
            fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            string userdata = mailTB.Text + "|" + nameTB.Text + "|" + dobTB.Text + "|" + phoneTB.Text + "|" + imgUrlTB.Text + "|";
            if (newTextBoxes.Count != 0)
            {
                foreach(TextBox tb in newTextBoxes)
                {
                    userdata += tb.Text + "|";
                }
            }
            sw.WriteLine(userdata);
            sw.Flush();
            SendUserDetails?.Invoke(this, details);
            sw.Close();
            fs.Close();

            SendUserDetails?.Invoke(this, details);
        }
    }
}
