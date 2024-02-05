using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            inpform.SendUserDetailsAsArray += GetUser;
            
        }
        InputForm inpform = new InputForm();

        public List<UserDetails> users = new List<UserDetails>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetUser(object sender, UserDetails user)
        {
            users.Add(user);
            string[] arr =
            {
                
            };
            displayTable.Rows.Add(arr);
        }
        private void OnAddRowBtnClicked(object sender, EventArgs e)
        {
            inpform.Show();
        }

        private void OnDisplayTableCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void displayTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
