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
            timer.Tick += OnTimerTicked;
            timer.Start();
            expenseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ExpenseManager.OnDataUpdated += UpdateDataGridView;
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

        private void OnTimerTicked(object sender, EventArgs e)
        {
            if (headingLabel.Location.X > Width)
            {
                headingLabel.Location = new Point(0, 21);
                i = 0;
            }
            else headingLabel.Location = new Point(7 * i, 21);
            i++;
            if (isMenuClicked)
            {
                if(optionsPanel.Width < 210)
                    optionsPanel.Width += 50;
            }
            else if(!isMenuClicked){
                if (optionsPanel.Width > 80)
                    optionsPanel.Width -= 50;
            }
        }

        private void OnPictureBoxMouseEnter(object sender, EventArgs e)
        {
            if(sender is PictureBox pb)
                pb.BackColor = Color.Gainsboro;
        }

        private void OnPictureBoxMouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
                pb.BackColor = Color.White;
        }

        private void OnPlusPBClick(object sender, EventArgs e)
        {
            expenseInputForm = new ExpenseInputForm();
            expenseInputForm.Location = addPB.PointToScreen(new Point(0, 0));
            expenseInputForm.ShowDialog();
        }

        private void OnFilterPBClick(object sender, EventArgs e)
        {

        }

        private void expenseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
   
                delPB.Visible = true;
                selectedRow = e.RowIndex;
           
        }

        private void OnMenuPBClick(object sender, EventArgs e)
        {
            isMenuClicked = !isMenuClicked;
            //if (isMenuClicked)
            //{
            //    optionsPanel.Width = 220;
            //}
            //else
            //{
            //    optionsPanel.Width = 67;
            //}
        }

        private void delPB_Click(object sender, EventArgs e)
            
        {
            ExpenseManager.RemoveExpense(selectedRow);
            delPB.Visible = false;
        }
    }
}
