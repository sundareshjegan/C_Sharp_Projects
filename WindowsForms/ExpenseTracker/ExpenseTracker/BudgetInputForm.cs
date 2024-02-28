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
    public partial class BudgetInputForm : Form
    {
        public BudgetInputForm()
        {
            InitializeComponent();
        }

        public static int GetMonthNumber(string monthName)
        {
            monthName = monthName.ToLower();
            int monthNumber = 0;
            switch (monthName)
            {
                case "january":
                    monthNumber = 1;
                    break;
                case "february":
                    monthNumber = 2;
                    break;
                case "march":
                    monthNumber = 3;
                    break;
                case "april":
                    monthNumber = 4;
                    break;
                case "may":
                    monthNumber = 5;
                    break;
                case "june":
                    monthNumber = 6;
                    break;
                case "july":
                    monthNumber = 7;
                    break;
                case "august":
                    monthNumber = 8;
                    break;
                case "september":
                    monthNumber = 9;
                    break;
                case "october":
                    monthNumber = 10;
                    break;
                case "november":
                    monthNumber = 11;
                    break;
                case "december":
                    monthNumber = 12;
                    break;
            }

            return monthNumber;
        }

        private void OnOKBtnClicked(object sender, EventArgs e)
        {
            ExpenseManager.SetBudget(GetMonthNumber(monthCB.Text)-1, (int)budgetNumericUpdown.Value);
            Dispose();
        }

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OnMonthCBTextChanged(object sender, EventArgs e)
        {
            budgetNumericUpdown.Value = ExpenseManager.monthExpenseList[GetMonthNumber(monthCB.Text) - 1][0];
        }
    }
}
