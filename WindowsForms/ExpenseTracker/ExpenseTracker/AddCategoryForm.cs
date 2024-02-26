using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }
        public event EventHandler<string> CategoryChanged;

        private void OnBtnClicked(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if(bt.Text == "Add" && newCategoryTB.Text!="" && !string.IsNullOrWhiteSpace(newCategoryTB.Text))
            {
                CategoryChanged?.Invoke(this, newCategoryTB.Text);
            }
            Dispose();
        }

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
