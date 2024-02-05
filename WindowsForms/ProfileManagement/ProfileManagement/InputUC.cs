using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileManagement
{
    public partial class InputUC : UserControl
    {
        public InputUC()
        {
            InitializeComponent();
        }

        private string name, phone, email, dob,imgPath;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagefileDialog = new OpenFileDialog();
            if(imagefileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.BackgroundImage = new Bitmap(imagefileDialog.FileName);
                    imgUrlTB.Text = imagefileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Invalid File type..!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        public event EventHandler<UserDetails> SendUserDetails;

        private void InputUC_Load(object sender, EventArgs e)
        {

        }

        private void OnSubmitBtnClicked(object sender, EventArgs e)
        {
            name = nameTB.Text;
            phone = phoneTB.Text;
            email = mailTB.Text;
            dob = dobTB.Text;
            imgPath = imgUrlTB.Text;

            if(name=="" || phone=="" || phone.Length!=10 || email=="" || dob=="" || imgPath == "")
            {
                MessageBox.Show("Enter Valid Data..!");
            }
            else
            {
                UserDetails user = new UserDetails()
                {
                    
                };
                SendUserDetails?.Invoke(this, user);
            }
        }
    }
}
