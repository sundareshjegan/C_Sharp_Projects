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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 100;
            menuTimer.Interval = 5;
            filterTimer.Interval = 10;

            timer.Tick += OnTimerTicked;
            menuTimer.Tick += OnMenuTimerTicked;
            filterTimer.Tick += OnFilterTimerTick;
            
            timer.Start();
            expenseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DBManager.GetConnection(); // to get connection between sql and program.
        }

        private ExpenseInputForm expenseInputForm;
        private bool isMenuClicked = false, isFilterClicked = false;
        private int i = 0, selectedRowIndex;
        private Timer timer = new Timer();
        private Timer menuTimer = new Timer();
        private Timer filterTimer = new Timer();
        private DataGridViewRow selectedRow = null;

        private void OnFilterTimerTick(object sender, EventArgs e)
        {
            if (isFilterClicked)
            {
                if (filterOptionsPanel.Height < 90)
                {
                    filterOptionsPanel.Width += 10;
                    filterOptionsPanel.Height += 10;
                }
            }
            else if (!isFilterClicked)
            {
                if (filterOptionsPanel.Height > 0)
                {
                    filterOptionsPanel.Height -= 10;
                }
            }
        }

        private void OnMenuTimerTicked(object sender, EventArgs e)
        {
            if (isMenuClicked)
            {
                if (optionsPanel.Width < 200)
                {
                    optionsPanel.Width += 10;
                    Width += 10;
                }

            }
            else if (!isMenuClicked)
            {
                if (optionsPanel.Width > 50)
                {
                    optionsPanel.Width -= 10;
                    Width -= 10;
                }
            }
        }

        private void OnTimerTicked(object sender, EventArgs e)
        {
            if (headingLabel.Location.X > Width)
            {
                headingLabel.Location = new Point(0, 21);
                i = 0;
            }
            else headingLabel.Location = new Point(7 * i, 21);
            i++;
        }

        private void UpdateDataGridView(object sender, string e)
        {
            
        }

        private void OnPictureBoxMouseEnter(object sender, EventArgs e)
        {
            if(sender is PictureBox pb)
                pb.BackColor = Color.Gainsboro;
            if (sender is Label label)
                label.Parent.BackColor = Color.Gainsboro;
        }

        private void OnPictureBoxMouseLeave(object sender, EventArgs e)
        {
            //expenseDataGridView.Sort(,ListSortDirection.);
            if (sender is PictureBox pb)
                pb.BackColor = Color.Transparent;
            if (sender is Panel panel)
                panel.BackColor = Color.Transparent;
            if (sender is Label label)
                label.BackColor = Color.Transparent;
        }

        private void OnAddExpenseBtnClicked(object sender, EventArgs e)
        {
            isMenuClicked = false;
            isFilterClicked = false;
            expenseInputForm = new ExpenseInputForm();
            //expenseInputForm.Location = addExpenseBtn.PointToScreen(new Point(0, 0));
            expenseInputForm.Location = Cursor.Position;
            expenseInputForm.ShowDialog();
        }
        private void OnFilterExpenseBtnClicked(object sender, EventArgs e)
        {
            filterTimer.Start();
            isFilterClicked = !isFilterClicked;
            LoadFilterData();
        }
        private void OnCategoryBtnClicked(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.Location = Cursor.Position;
            addCategoryForm.ShowDialog();
        }
        private void OnBudgetBtnClicked(object sender, EventArgs e)
        {
            BudgetInputForm budgetInputForm = new BudgetInputForm();
            budgetInputForm.Location = Cursor.Position;
            budgetInputForm.ShowDialog();
        }

        private void OnExpenseDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void GetOption(string option)
        {
            if(option == "edit")
            {
                //expenseInputForm = new ExpenseInputForm(ExpenseManager.ExpensesList[selectedRowIndex], selectedRowIndex);
                Expense selectedExpense = selectedRow.DataBoundItem as Expense;
                expenseInputForm = new ExpenseInputForm(selectedExpense, selectedExpense.Id-1);
                expenseInputForm.Location = Cursor.Position;
                expenseInputForm.ShowDialog();
            }
            else if(option == "delete")
            {
                ExpenseManager.RemoveExpense(selectedRowIndex);
            }
        }

        private void FilterDatePickerDropDown(object sender, EventArgs e)
        {
            filterMonthCB.Enabled = filterDayCB.Enabled = false;
        }

        private void FilterCBKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OnFilterCBClick(object sender, EventArgs e)
        {
            filterMonthCB.Enabled = filterDayCB.Enabled = true;
            filterFromDatePicker.Enabled = filterToDatePicker.Enabled = false;
        }

        private void FilterResetBtnClick(object sender, EventArgs e)
        {
            filterMonthCB.Enabled = filterDayCB.Enabled = filterFromDatePicker.Enabled = filterToDatePicker.Enabled = true;
            filterCategoryCB.Text = "Select";
            UpdateDataGridView(sender,"reset");
            //LoadFilterData();
        }

        private void FilterCBTextChanged(object sender, EventArgs e)
        {
            
        }

        private void FilterDatePickerValueChanged(object sender, EventArgs e)
        {
            
        }

        private void MenuMouseEnter(object sender, EventArgs e)
        {
            menuTimer.Start();
            isMenuClicked = true;
        }

        private void MenuMouseLeave(object sender, EventArgs e)
        {
            isMenuClicked = false;
        }

        private void expenseDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void OnExpenseDataGridViewRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int totalAmount = 0;
            for (int i = 0; i < expenseDataGridView.Rows.Count; i++)
            {
                //totalAmount += (int)expenseDataGridView.Rows[i].Cells[4].Value;
            }
            totalAmountLabel.Text = totalAmount.ToString();
        }
        private void LoadFilterData()
        { 
            
        }
    }
}
