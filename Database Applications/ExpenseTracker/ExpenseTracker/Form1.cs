using MySql.Data.MySqlClient;
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
            menuTimer.Interval = 1;
            filterTimer.Interval = 10;

            timer.Tick += OnTimerTicked;
            menuTimer.Tick += OnMenuTimerTicked;
            filterTimer.Tick += OnFilterTimerTick;
            
            timer.Start();
            menuTimer.Start();

            DBManager.GetConnection(); // to get connection between sql and program.
            UpdateDataGridView(this, "select * from expenses");

            DBManager.OnDbUpdated += UpdateDataGridView;
        }

        private ExpenseInputForm expenseInputForm;
        private bool isMenuClicked = false, isFilterClicked = false, isOptionsBtnClicked = false;

        private int i = 0 , row = 0;

        private Timer timer = new Timer();
        private Timer menuTimer = new Timer();
        private Timer filterTimer = new Timer();

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
                    optionsPanel.Width += 20;
                    Width += 20;
                }

            }
            else if (!isMenuClicked )
            {
                if(optionsPanel.Width > 70)
                {
                    optionsPanel.Width -= 20;
                    Width -= 20;
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

        private void UpdateDataGridView(object sender, string query)
        {
            try
            {
               // DBManager.Connection.Open();
               // query = "SELECT * FROM expenses";
                MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    expenseDataGridView.DataSource = dataTable;
                    expenseDataGridView.Columns[0].Visible = false;
                    expenseDataGridView.ClearSelection();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred update data grid view: " + ex.Message);
            }
            finally
            {
               // DBManager.Connection.Close();
            }
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

        private void OnMenuBtnClicked(object sender, EventArgs e)
        {
            isMenuClicked = !isMenuClicked;
        }

        private void OnHomeBtnClicked(object sender, EventArgs e)
        {
            dashboardPanel.Visible = !dashboardPanel.Visible;
            DisplayExpensePieChart();
            DashboardDisplayMonthBudgets();
        }
        private void DisplayExpensePieChart()
        {
            Dictionary<string, float> categoryExpenses = new Dictionary<string, float>();
            
            MySqlCommand command = new MySqlCommand("SELECT CATEGORY, SUM(AMOUNT) AS TOTAL_EXPENSE FROM expenses GROUP BY CATEGORY", DBManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string categoryName = reader["CATEGORY"].ToString();
                float totalExpense = Convert.ToSingle(reader["TOTAL_EXPENSE"]);
                categoryExpenses.Add(categoryName, totalExpense);
            }
            reader.Close();

            // Populate the pie chart with the data
            chart1.Series.Clear();
            //chart1.Titles.Add("Expense Distribution by Category");
            System.Windows.Forms.DataVisualization.Charting.Series series = chart1.Series.Add("Expenses");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var pair in categoryExpenses)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }
        }
        private void DashboardDisplayMonthBudgets()
        {
            dashMonNameLabel.Text = dashMonBudgetLabel.Text = "";
            MySqlCommand command = new MySqlCommand("SELECT MONTH_NAME, MONTHLY_BUDGET FROM Months", DBManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string monthName = reader["MONTH_NAME"].ToString();
                int monthlyBudget = Convert.ToInt32(reader["MONTHLY_BUDGET"]);

                //string formattedText = string.Format("{0,20} -  {1}", monthName.ToUpper(), monthlyBudget); // Adjust the width as needed

                dashMonNameLabel.Text += string.Format("{0,-20} \n",monthName.ToUpper());
                dashMonBudgetLabel.Text += " - "+monthlyBudget + "\n";
            }
            reader.Close();
        }
        

        private void OnAddExpenseBtnClicked(object sender, EventArgs e)
        {
            isMenuClicked = true;
            isOptionsBtnClicked = !isOptionsBtnClicked;
            isFilterClicked = false;

            expenseInputForm = new ExpenseInputForm();
            expenseInputForm.Location = Cursor.Position;
            expenseInputForm.ShowDialog();
        }
        private void OnFilterExpenseBtnClicked(object sender, EventArgs e)
        {
            isOptionsBtnClicked = !isOptionsBtnClicked;
            //isMenuClicked = !isMenuClicked;
            isFilterClicked = !isFilterClicked;
            filterTimer.Start();
            LoadFilterCategoryData();
            LoadFilterDate();
        }
        private void OnCategoryBtnClicked(object sender, EventArgs e)
        {
            isOptionsBtnClicked = !isOptionsBtnClicked;
            isMenuClicked = true;

            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.Location = Cursor.Position;
            addCategoryForm.ShowDialog();
        }
        private void OnBudgetBtnClicked(object sender, EventArgs e)
        {
            isOptionsBtnClicked = !isOptionsBtnClicked;
            BudgetInputForm budgetInputForm = new BudgetInputForm();
            budgetInputForm.Location = Cursor.Position;
            budgetInputForm.ShowDialog();
            DashboardDisplayMonthBudgets();
        }

        private void OnOptionMouseEnter(object sender, EventArgs e)
        {
            //isMenuClicked = true;
            //menuTimer.Start();
            if (sender is Button button)
            {
                button.BackColor = Color.Black;
                button.ForeColor = Color.White;
            }
        }

        private void OnOptionMouseLeave(object sender, EventArgs e)
        {
            //if(isOptionsBtnClicked)
            //    isMenuClicked = true;
            //else
            //    isMenuClicked = false;
            if (sender is Button button)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.DodgerBlue;
            }
        }

        private void OnExpenseDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = e.RowIndex;
            if(e.Button == MouseButtons.Right)
            {
                ExpenseOptionForm expenseOptionForm = new ExpenseOptionForm();
                expenseOptionForm.Location = Cursor.Position;
                expenseOptionForm.SendOption += GetOption;
                expenseOptionForm.ShowDialog();
            }
        }

        private void OnExpenseDataGridViewRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            float totalAmount = 0;
            for (int i = 0; i < expenseDataGridView.Rows.Count; i++)
            {
                totalAmount += (float)expenseDataGridView.Rows[i].Cells[4].Value;
            }
            totalAmountLabel.Text = totalAmount.ToString();
        }

        private void GetOption(string option)
        {
            if(option == "edit")
            {
                //expenseInputForm = new ExpenseInputForm(ExpenseManager.ExpensesList[selectedRowIndex], selectedRowIndex);
                //Expense selectedExpense = selectedRow.DataBoundItem as Expense;
                //expenseInputForm = new ExpenseInputForm(selectedExpense, selectedExpense.Id-1);

                //MessageBox.Show(expenseDataGridView.Rows[row].Cells[1].Value.ToString() + "\n"+
                //     expenseDataGridView.Rows[row].Cells[2].Value.ToString() + "\n" +
                //     expenseDataGridView.Rows[row].Cells[3].Value.ToString() + "\n" +
                //     expenseDataGridView.Rows[row].Cells[4].Value.ToString() + "\n" +
                //     expenseDataGridView.Rows[row].Cells[5].Value.ToString()
                //    );

                Expense expense = new Expense()
                {
                    //Date = expenseDataGridView.Rows[row].Cells[1].Value,
                    Id = (int)expenseDataGridView.Rows[row].Cells[0].Value,
                    Date = DateTime.Parse(expenseDataGridView.Rows[row].Cells[1].Value.ToString()),
                    Category = expenseDataGridView.Rows[row].Cells[2].Value.ToString(),
                    Name = expenseDataGridView.Rows[row].Cells[3].Value.ToString(),
                    Amount = float.Parse(expenseDataGridView.Rows[row].Cells[4].Value.ToString()),
                    Description = expenseDataGridView.Rows[row].Cells[5].Value.ToString()

                };
               
                expenseInputForm = new ExpenseInputForm();
                expenseInputForm.SetData(expense);
                expenseInputForm.Location = Cursor.Position;
                expenseInputForm.ShowDialog();
            }

            else if(option == "delete")
            {
                Expense expense = new Expense()
                {
                    //Date = expenseDataGridView.Rows[row].Cells[1].Value,
                    Id = (int)expenseDataGridView.Rows[row].Cells[0].Value,
                    Date = DateTime.Parse(expenseDataGridView.Rows[row].Cells[1].Value.ToString()),
                    Category = expenseDataGridView.Rows[row].Cells[2].Value.ToString(),
                    Name = expenseDataGridView.Rows[row].Cells[3].Value.ToString(),
                    Amount = float.Parse(expenseDataGridView.Rows[row].Cells[4].Value.ToString()),
                    Description = expenseDataGridView.Rows[row].Cells[5].Value.ToString()
                };
                DBManager.DeleteExpense(expense);
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
            UpdateDataGridView(null,"select * from expenses");
        }

        private void FilterCategoryCBTextChanged(object sender, EventArgs e)
        {
            string selectedCategory = filterCategoryCB.Text;
            string query = $"select * from expenses where category = '{selectedCategory}' ";
            UpdateDataGridView(null, query);
        }

        private void FilterMonthCBTextChanged(object sender, EventArgs e)
        {
            int selectedMonth = DBManager.GetMonthNumber(filterMonthCB.Text);
            string query = $"select * from expenses where MONTH(date) = {selectedMonth} ";
            UpdateDataGridView(null, query);
        }

        private void FilterDatePickerValueChanged(object sender, EventArgs e)
        {
            //DBManager.GetMinAndMaxDate();
            //DateTime fromDate = filterFromDatePicker.Value;
            //DateTime toDate = filterFromDatePicker.Value;
            string FromDate = filterFromDatePicker.Value.ToString("yyyy-MM-dd");
            string ToDate = filterToDatePicker.Value.ToString("yyyy-MM-dd");

            // Call this two line after creating seprate functions
            string query = $"select * from expenses where Date between '{FromDate}' and '{ToDate}'";
            UpdateDataGridView(null, query);
        }

        private void LoadFilterCategoryData()
        {
            filterCategoryCB.Items.Clear();
            try
            {
                string query = "SELECT CAT_NAME FROM categories";
                MySqlDataReader reader = DBManager.GetReader(query);

                while (reader.Read())
                {
                    // Assuming column index 0 contains the values for the combo box
                    if (reader.GetString(0) != "Others")
                        filterCategoryCB.Items.Add(reader.GetString(0));
                }
                reader.Close();
                filterCategoryCB.Items.Add("Others");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in category filter section: " + ex.Message);
            }
            finally
            {
                //DBManager.Connection.Close();
            }

        }

        private void LoadFilterDate()
        {
            string query = "SELECT MIN(DATE) FROM expenses";
            MySqlDataReader reader = DBManager.GetReader(query);

            while (reader.Read())
            {
                filterFromDatePicker.MinDate = DateTime.Parse(reader.GetString(0));
                filterToDatePicker.MinDate = DateTime.Parse(reader.GetString(0));
                filterFromDatePicker.Value = filterFromDatePicker.MinDate;
            }

            reader.Close();

            

            query = "SELECT MAX(DATE) FROM expenses";
            MySqlDataReader maxReader = DBManager.GetReader(query);
            while (maxReader.Read())
            {
                filterFromDatePicker.MaxDate = DateTime.Parse(maxReader.GetString(0));
                filterToDatePicker.MaxDate = DateTime.Parse(maxReader.GetString(0));
                filterToDatePicker.Value = filterToDatePicker.MaxDate;
            }
            //to load months in the filter month combobox
            maxReader.Close();

            filterMonthCB.Items.Clear();

            for (int i = filterFromDatePicker.MinDate.Month; i <= filterToDatePicker.MaxDate.Month; i++)
            {
                filterMonthCB.Items.Add(DBManager.GetMonthName(i));
            }
            
        }


    }
}
