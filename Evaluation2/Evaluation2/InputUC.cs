using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation2
{
    public partial class InputUC : UserControl
    {
        public InputUC()
        {
            InitializeComponent();
        }

        internal static List<Expenses> expensesList = new List<Expenses>();

        public event EventHandler<string> OnSave;

        private static int spentAmount = 0, budget = 5000;

        private void OnSaveBtnClicked(object sender, EventArgs e)
        {
            if(nameTB.Text!="" && categoryTB.Text != "")
            {
                Expenses expense = new Expenses()
                {
                    Name = nameTB.Text,
                    Category = categoryTB.Text,
                    Amount = (int)amountTB.Value,
                    Date = dateTB.Value,
                    Description = descriptionTB.Text,
                };
                expensesList.Add(expense);
                BudgetCheck();
                OnSave?.Invoke(this, "close");
            }
            else
            {
                MessageBox.Show("Please Fill Mandatory data");
            }
        }

        private void OnAddCategoryBtnClicked(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.SendCategory += GetCategory;
            addCategory.Location = addCategoryBtn.PointToScreen(new Point(0, 0));
            addCategory.ShowDialog();
        }

        private void amountTB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OnCategoryKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GetCategory(object sender, string categoryName)
        {
            categoryTB.Items.Add(categoryName);
        }

        private void BudgetCheck()
        {
            foreach(Expenses expense in expensesList)
            {
                spentAmount += expense.Amount;
            }
            if(spentAmount > budget)
            {
                MessageBox.Show("Warning..!\n You crossed your budget");
            }
        }
    }
}
