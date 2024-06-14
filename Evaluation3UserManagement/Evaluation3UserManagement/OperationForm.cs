using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Evaluation3UserManagement
{
    public partial class OperationForm : Form
    {
        public OperationForm()
        {
            InitializeComponent();
            UserManager.OnCurrentUserChanged += UserManagerOnCurrentUserChanged;
        }

        private void UserManagerOnCurrentUserChanged(object sender, EventArgs e)
        {
            loggedInUserNameLabel.Text = UserManager.CurrentUser.UserName;
            levelLabel.Text = UserManager.CurrentUser.Level.ToString();
            UpdateGrid();
        }

        private void OnloggedInUserNameLabelClicked(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            loggedInUserNameLabel.Text = UserManager.CurrentUser.UserName;
            levelLabel.Text = UserManager.CurrentUser.Level.ToString();
            UpdateGrid();
        }

        private void OnAddUserBtnClicked(object sender, EventArgs e)
        {
            AddUserForm addForm = new AddUserForm();
            addForm.SetData("add");
            addForm.ShowDialog();
        }

        private void OnUpdateBtnClicked(object sender, EventArgs e)
        {
            if(UserManager.CurrentUser.Level == UserLevel.Admin)
            {
                MessageBox.Show("Default username and password cannot be updated");
                return;
            }

            AddUserForm addForm = new AddUserForm();
            addForm.SetData("update");
            addForm.ShowDialog();
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            deletePanel.Visible = true;
            userNameDeleteCB.DataSource = null;
            List<string> usernames = UserManager.GetUserNamesBelowLevel(UserManager.CurrentUser.Level);
            userNameDeleteCB.DataSource = usernames;
        }

        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            if(userNameDeleteCB.Text == "")
            {
                MessageBox.Show("Select Username");
            }
            UserManager.DeleteUser(userNameDeleteCB.Text);
            List<string> usernames = UserManager.GetUserNamesBelowLevel(UserManager.CurrentUser.Level);
            MessageBox.Show("Deleted Successfully");
            deletePanel.Visible = false;
            userNameDeleteCB.DataSource = usernames;
            UpdateGrid();
        }

        private void CloseLabel(object sender, EventArgs e)
        {
            deletePanel.Visible = false;
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UserManager.GetUserNameAndRoleBelowLevel(UserManager.CurrentUser.Level);
        }
    }
}
