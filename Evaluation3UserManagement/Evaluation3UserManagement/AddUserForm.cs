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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        private void OnAddUserBtnClicked(object sender, EventArgs e)
        {
            if(addUserBtn.Text == "Add User")
            {
                if (userNameLabel.Text == "" || passwordTB.Text == "" || nameTB.Text == "" || levelComboBox.Text == "")
                {
                    WarningLabel.Text = "Enter all details";
                    return;
                }
                if (UserManager.IsUserExists(userNameTB.Text))
                {
                    WarningLabel.Text = "Username already exists..!";
                    return;
                }
                UserManager.AddUser(new User()
                {
                    UserName = userNameTB.Text,
                    Name = nameTB.Text,
                    Password = passwordTB.Text,
                    Level = UserManager.GetLevel(levelComboBox.Text)
                });
                MessageBox.Show("User added Successfully");
                Dispose();
            }
            else if(addUserBtn.Text == "Update")
            {
                UserManager.UpdateUser(new User()
                {
                    Name = nameTB.Text,
                    Password = passwordTB.Text,
                    Level = UserManager.GetLevel(levelComboBox.Text)
                });
                MessageBox.Show("User Updated Successfully");
                Dispose();
            }
        }

        public void SetData(string operation)
        {
            if (operation == "add")
            {
                UpdateComboBoxBasedOnLevels();
                userNameTB.Enabled = true;
                addUserBtn.Text = "Add User";
            }
            else if(operation == "update")
            {
                levelComboBox.Items.Clear();
                #region add items
                levelComboBox.Items.Add("Administrator");
                levelComboBox.Items.Add("Manager");
                levelComboBox.Items.Add("Supervisor");
                levelComboBox.Items.Add("Operator");
                #endregion
                nameTB.Text = UserManager.CurrentUser.Name;
                userNameTB.Enabled = false;
                userNameTB.Text = UserManager.CurrentUser.UserName;
                passwordTB.Text = UserManager.CurrentUser.Password;
                levelComboBox.Enabled = false;
                levelComboBox.Text = UserManager.CurrentUser.Level.ToString();
                addUserBtn.Text = "Update";
            }
        }

        private void UpdateComboBoxBasedOnLevels()
        {
            if (UserManager.CurrentUser.Level == UserLevel.Admin)
            {
                levelComboBox.Items.Add("Administrator");
                levelComboBox.Items.Add("Manager");
                levelComboBox.Items.Add("Supervisor");
                levelComboBox.Items.Add("Operator");
            }
            else if (UserManager.CurrentUser.Level == UserLevel.Administrator)
            {
                levelComboBox.Items.Add("Manager");
                levelComboBox.Items.Add("Supervisor");
                levelComboBox.Items.Add("Operator");
            }
            else if (UserManager.CurrentUser.Level == UserLevel.Manager)
            {
                levelComboBox.Items.Add("Supervisor");
                levelComboBox.Items.Add("Operator");
            }
            else if (UserManager.CurrentUser.Level == UserLevel.Supervisor)
            {
                levelComboBox.Items.Add("Operator");
            }
            else
            {
                levelLabel.Visible = levelComboBox.Visible = false;
            }
        }
    }
}
