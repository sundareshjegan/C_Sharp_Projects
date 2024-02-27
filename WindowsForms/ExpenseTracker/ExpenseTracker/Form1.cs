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

            timer.Tick += OnTimerTicked;
            menuTimer.Tick += OnMenuTimerTicked;

            timer.Start();
            expenseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ExpenseManager.OnExpenseUpdated += UpdateDataGridView;
        }

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

        private ExpenseInputForm expenseInputForm;
        private bool isMenuClicked = false;
        private int i = 0, selectedRow;
        private Timer timer = new Timer();
        private Timer menuTimer = new Timer();

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
            expenseInputForm = new ExpenseInputForm();
            expenseInputForm.Location = addPB.PointToScreen(new Point(0, 0));
            expenseInputForm.ShowDialog();
        }

        private void OnMenuPBClick(object sender, EventArgs e)
        {
            menuTimer.Start();
            isMenuClicked = !isMenuClicked;
        }

        private void expenseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deletePanel.Visible = true;
            selectedRow = e.RowIndex;
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

        private void OnDelPBClicked(object sender, EventArgs e)
        {
            ExpenseManager.RemoveExpense(selectedRow);
            deletePanel.Visible = false;
        }
    }
}
