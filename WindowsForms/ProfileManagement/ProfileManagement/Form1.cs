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
        private InputForm inpform = new InputForm();
        private GetColForm newColForm;

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
            //inpform = new InputForm();
            new InputForm().Show();
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
            displayTable.Columns.Add(newColName, newColName);
            Width += 100;
            newColForm?.Dispose();
        }
    }
}
