using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3UserManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnLoginBtnClicked(object sender, EventArgs e)
        {
            if (UserManager.IsUserExists(userNameTB.Text))
            {
                if(UserManager.GetUserDetails(userNameTB.Text).Password == passwordTB.Text)
                {
                    if(userNameTB.Text.ToLower()=="admin")
                        new OperationForm().ShowDialog();
                    UserManager.UpdateCurrentUser(userNameTB.Text);
                }
                else
                {
                    loginWarningLabel.Text = "Incorrect password";
                }
            }
            else
            {
                loginWarningLabel.Text = "Username does not exists..!";
            }
        }
    }
}
