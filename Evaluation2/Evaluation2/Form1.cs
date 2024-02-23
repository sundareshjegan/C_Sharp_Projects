using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Evaluation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private InputForm inpForm;
        private int selectedIndex = 0;

        private void OnAddBtnClicked(object sender, EventArgs e)
        {
            inpForm = new InputForm();
            inpForm.ShowDialog();
            UpdateDataGridView(InputUC.expensesList);
        }

        private void OnViewBtnClicked(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Location = viewBtn.PointToScreen(new Point(0, 0));
            options.SendOption += GetOption;
            options.ShowDialog();

            cb.Visible = viewBtn.Text == "Category Filter" || viewBtn.Text == "Month wise" || viewBtn.Text == "Day wise";
            rangePanel.Visible = viewBtn.Text == "Custom Date" || viewBtn.Text == "Total Expenses";

            if (viewBtn.Text == "Category Filter")
            {
                HashSet<string> categories = new HashSet<string>();
                cb.Size = viewBtn.Size;
                cb.Items.Clear();
                foreach (Expenses expense in InputUC.expensesList)
                {
                    categories.Add(expense.Category);
                }
                foreach (string cat in categories)
                {
                    cb.Items.Add(cat);
                }
            }
            else if (viewBtn.Text == "Month wise")
            {
                HashSet<string> categories = new HashSet<string>();
                cb.Size = viewBtn.Size;
                cb.Items.Clear();
                foreach (Expenses expense in InputUC.expensesList)
                {
                    categories.Add(expense.Date.Month.ToString());
                }
                foreach (string cat in categories)
                {
                    cb.Items.Add(cat);
                }
            }
            else if( viewBtn.Text == "Day wise")
            {
                HashSet<string> categories = new HashSet<string>();
                cb.Size = viewBtn.Size;
                cb.Items.Clear();
                foreach (Expenses expense in InputUC.expensesList)
                {
                    categories.Add(expense.Date.Date.ToString());
                }
                foreach (string cat in categories)
                {
                    cb.Items.Add(cat);
                }
            }
            else
            {
                cb.Size = new Size(0, 0);
            }

            UpdateDataGridView(InputUC.expensesList);
        }

        private void GetOption(object sender, string e)
        {
            viewBtn.Text = e;
        }

        private void UpdateDataGridView(List<Expenses> newData)
        {
            expenseDataGridView.DataSource = null;
            expenseDataGridView.DataSource = newData;
        }

        private void OnCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIndex >= 0)
                {
                    InputUC.expensesList.RemoveAt(selectedIndex);
                    UpdateDataGridView(InputUC.expensesList);
                }
            }
            catch (Exception ex)
            { }            
        }

        private void OnEditBtnClicked(object sender, EventArgs e)
        {
            UpdateDataGridView(InputUC.expensesList);
        }

        private void OnCbValueChanged(object sender, EventArgs e)
        {
            if (viewBtn.Text == "Month wise")
            {
                List<Expenses> filterdata = new List<Expenses>();
                foreach (Expenses expense in InputUC.expensesList)
                {
                    if (expense.Date.Month.ToString().ToLower() == cb.Text)
                    {
                        filterdata.Add(expense);
                    }
                }
                UpdateDataGridView(filterdata);
            }
            else if (viewBtn.Text == "Day wise")
            {
                List<Expenses> filterdata = new List<Expenses>();
                foreach (Expenses expense in InputUC.expensesList)
                {
                    if (expense.Date.Date.ToString().ToLower() == cb.Text)
                    {
                        filterdata.Add(expense);
                    }
                }
                UpdateDataGridView(filterdata);
            }
            else if(viewBtn.Text == "Category Filter")
            {
                List<Expenses> filterdata = new List<Expenses>();
                foreach (Expenses expense in InputUC.expensesList)
                {
                    if (expense.Category == cb.Text)
                        filterdata.Add(expense);
                }
                UpdateDataGridView(filterdata);
            }
        }

        private void OnCustomDateOkBtnClicked(object sender, EventArgs e)
        {
            if(viewBtn.Text == "Total Expenses")
            {
                int totalSpent = 0;
                foreach (Expenses expense in InputUC.expensesList)
                {
                    if (expense.Date >= startDatePicker.Value && expense.Date <= endDatePicker.Value)
                    {
                        totalSpent += expense.Amount;
                    }
                }
                MessageBox.Show(totalSpent.ToString());
            }
            else
            {
                List<Expenses> filterdata = new List<Expenses>();
                foreach (Expenses expense in InputUC.expensesList)
                {
                    if (expense.Date >= startDatePicker.Value && expense.Date <= endDatePicker.Value)
                    {
                        filterdata.Add(expense);
                    }
                    UpdateDataGridView(filterdata);
                }
            }
        }
    }
}
