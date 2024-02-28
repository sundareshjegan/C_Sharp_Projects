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
            menuTimer.Interval = 10;
            filterTimer.Interval = 10;

            timer.Tick += OnTimerTicked;
            menuTimer.Tick += OnMenuTimerTicked;
            filterTimer.Tick += OnFilterTimerTick;

            timer.Start();
            expenseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ExpenseManager.OnExpenseUpdated += UpdateDataGridView;
        }

        private void OnFilterTimerTick(object sender, EventArgs e)
        {
            filterOptionsPanel.Width += 10;
            if (isFilterClicked)
            {
                if (filterOptionsPanel.Height < 90)
                {
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

        private ExpenseInputForm expenseInputForm;
        private bool isMenuClicked = false, isFilterClicked = false;
        private int i = 0, selectedRow;
        private Timer timer = new Timer();
        private Timer menuTimer = new Timer();
        private Timer filterTimer = new Timer();

        private void OnMenuTimerTicked(object sender, EventArgs e)
        {
            if (isMenuClicked)
            {
                if (optionsPanel.Width < 210)
                {
                    optionsPanel.Width += 10;
                }

            }
            else if (!isMenuClicked)
            {
                if (optionsPanel.Width > 70)
                {
                    optionsPanel.Width -= 10;
                }
            }
        }

        private void UpdateDataGridView(object sender, string e)
        {
            expenseDataGridView.DataSource = null;
            expenseDataGridView.DataSource = ExpenseManager.ExpensesList;
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

        private void OnPictureBoxMouseEnter(object sender, EventArgs e)
        {
            if(sender is PictureBox pb)
                pb.BackColor = Color.Gainsboro;
            if (sender is Label label)
                label.Parent.BackColor = Color.Gainsboro;
        }

        private void OnPictureBoxMouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
                pb.BackColor = Color.Transparent;
            if (sender is Panel panel)
                panel.BackColor = Color.Transparent;
            if (sender is Label label)
                label.BackColor = Color.Transparent;
        }

        private void OnPlusPBClick(object sender, EventArgs e)
        {
            isFilterClicked = false;
            expenseInputForm = new ExpenseInputForm();
            expenseInputForm.Location = addPB.PointToScreen(new Point(0, 0));
            expenseInputForm.ShowDialog();
        }

        private void OnMenuPBClick(object sender, EventArgs e)
        {
            menuTimer.Start();
            isMenuClicked = !isMenuClicked;
        }

        private void OnExpenseDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            deletePanel.Visible = true;
            selectedRow = e.RowIndex;
        }

        private void OnExpenseDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.Button == MouseButtons.Right && selectedRow >= 0)
            {
                ExpenseOptionForm expenseOptionForm = new ExpenseOptionForm();
                expenseOptionForm.Location = Cursor.Position;
                expenseOptionForm.SendOption += GetOption;
                expenseOptionForm.ShowDialog();
            }
            
        }

        private void GetOption(string option)
        {
            if(option == "edit")
            {
                expenseInputForm = new ExpenseInputForm(ExpenseManager.ExpensesList[selectedRow], selectedRow);
                expenseInputForm.Location = Cursor.Position;
                expenseInputForm.ShowDialog();
            }
        }

        private void OnCategoryPBClicked(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.Location = categoryPB.PointToScreen(new Point(0, 0));
            addCategoryForm.ShowDialog();
        }

        private void OnBudgetClicked(object sender, EventArgs e)
        {
            BudgetInputForm budgetInputForm = new BudgetInputForm();
            budgetInputForm.Location = budgetPB.PointToScreen(new Point(0, 0));
            budgetInputForm.ShowDialog();
        }

        private void OnFilterPBClicked(object sender, EventArgs e)
        {
            filterTimer.Start();
            isFilterClicked = !isFilterClicked;
            LoadFilterData();
        }

        private void FilterDatePickerDropDown(object sender, EventArgs e)
        {
            filterMonthCB.Enabled = filterDayCB.Enabled = false;
        }

        private void FilterCBKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OnFilterCBDropDown(object sender, EventArgs e)
        {

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
            LoadFilterData();
        }

        private void FilterCBTextChanged(object sender, EventArgs e)
        {
            List<Expense> filteredData = new List<Expense>();

            foreach(Expense expense in ExpenseManager.ExpensesList)
            {
                // only Category 
                if (filterCategoryCB.Text != "Select" && filterMonthCB.Text == "Select" && filterCategoryCB.Text == expense.Category && !filteredData.Contains(expense))
                {
                    filteredData.Add(expense);
                }

                // only Month
                if (filterCategoryCB.Text == "Select" && filterMonthCB.Text == ExpenseManager.MonthNumberAndName[expense.Date.Month] && !filteredData.Contains(expense))
                {
                    filteredData.Add(expense);
                }


                //if(filterMonthCB.Text != "Select" && filterMonthCB.Text == ExpenseManager.MonthNumberAndName[expense.Date.Month] && !filteredData.Contains(expense))
                //{
                //    filteredData.Add(expense);
                //}
                //if (filterDayCB.Text != "Select" && filterDayCB.Text == expense.Date.Date.ToString() && !filteredData.Contains(expense))
                //{
                //    filteredData.Add(expense);
                //}


                // Both Category and Month
                if ( filterCategoryCB.Text != "Select"  &&  filterMonthCB.Text != "Select" )
                {
                    if(expense.Category == filterCategoryCB.Text && filterMonthCB.Text == ExpenseManager.MonthNumberAndName[expense.Date.Month] && !filteredData.Contains(expense))
                    {
                        filteredData.Add(expense);
                    }
                }

            }
            expenseDataGridView.DataSource = null;
            expenseDataGridView.DataSource = filteredData;
          
        }

        private void FilterDatePickerValueChanged(object sender, EventArgs e)
        {
            filterToDatePicker.MinDate = filterFromDatePicker.Value;
            List<Expense> filteredData = new List<Expense>();
            foreach (Expense expense in ExpenseManager.ExpensesList)
            {
               if (expense.Date >= filterFromDatePicker.Value && expense.Date <= filterToDatePicker.Value)
                  filteredData.Add(expense);
            }
            expenseDataGridView.DataSource = null;
            expenseDataGridView.DataSource = filteredData;
        }

        private void OnDelPBClicked(object sender, EventArgs e)
        {
            ExpenseManager.RemoveExpense(selectedRow);
            deletePanel.Visible = false;
        }
        private void LoadFilterData()
        { 
            HashSet<string> category = new HashSet<string>() { "Select" };
            HashSet<string> month = new HashSet<string>() {"Select"};
            HashSet<string> days = new HashSet<string>() { "Select" };

            filterToDatePicker.MinDate = filterFromDatePicker.Value;


            foreach (Expense expense in ExpenseManager.ExpensesList)
            {
                category.Add(expense.Category);
                month.Add(ExpenseManager.MonthNumberAndName[expense.Date.Month]);
                days.Add(expense.Date.Date.ToString());
            }

            filterCategoryCB.DataSource = null;
            filterMonthCB.DataSource = null;
            filterDayCB.DataSource = null;

            filterCategoryCB.DataSource = category.ToList();
            filterMonthCB.DataSource = month.ToList();
            filterDayCB.DataSource = days.ToList();
        }
    }
}
