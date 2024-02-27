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
            UpdateComboBoxes();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private bool isShrink = false;
        private List<Panel> panels = new List<Panel>();

        private void OnFormLoad(object sender, EventArgs e)
        {
            panels.Add(AddCategoryPanel);
            panels.Add(UpdateCategoryPanel);
            panels.Add(DeleteCategoryPanel);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(!isShrink && Width < 520)
            {
                Width += 10;
            }
            else if (isShrink && Width > 170)
            {
                Width -= 10;
            }
        }

        public event EventHandler<string> CategoryChanged;
        private Timer timer = new Timer();
        
        private void UpdateComboBoxes()
        {
            deleteCategoryCB.DataSource = existingCategoryCB.DataSource = null;
            existingCategoryCB.DataSource = ExpenseManager.categories;
            deleteCategoryCB.DataSource = ExpenseManager.categories;
        }

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            isShrink = true;
            operationsPanel.Controls.Clear();
        }

        private void ResetTextBoxes()
        {
            existingCategoryCB.Text = updatedCategoryTB.Text = deleteCategoryCB.Text = newCategoryTB.Text = "";
            //addWarningLabel.Text = deleteWarningLabel.Text = updateWarningLabel.Text = "";
        }

        private void OnAddBtnClicked(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (ExpenseManager.categories.Contains(newCategoryTB.Text))
            {
                addWarningLabel.ForeColor = Color.Red;
                addWarningLabel.Text = "Category already exists";
            }
            else if(bt.Text == "Add" && newCategoryTB.Text!="" && !string.IsNullOrWhiteSpace(newCategoryTB.Text))
            {
                ExpenseManager.AddCategory(newCategoryTB.Text);
                addWarningLabel.ForeColor = Color.DodgerBlue;
                addWarningLabel.Text = "Category added Successfully..!";
            }
            ResetTextBoxes();
        }

        private void OnUpdateBtnClicked(object sender, EventArgs e)
        {
            if (ExpenseManager.categories.Contains(updatedCategoryTB.Text))
            {
                updateWarningLabel.ForeColor = Color.Red;
                updateWarningLabel.Text = "Category already exists";
            }
            else
            {
                ExpenseManager.UpdateCategory(existingCategoryCB.Text, updatedCategoryTB.Text);
                UpdateComboBoxes();
                updateWarningLabel.ForeColor = Color.DodgerBlue;
                updateWarningLabel.Text = "Category Updated Successfully";
            }
            ResetTextBoxes();
        }

        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            ExpenseManager.RemoveCategory(deleteCategoryCB.Text);
            deleteWarningLabel.Text = deleteCategoryCB.Text + " Deleted Successfully";
            UpdateComboBoxes();
            ResetTextBoxes();
        }

        private void OnOptionsBtnClicked(object sender, EventArgs e)
        {
            timer.Start();
            isShrink = false;
            Button button = sender as Button;
            if(button.Text == "Add Category")
            {
                operationsPanel.Controls.Clear();
                panels[0].Visible = true;
                operationsPanel.Controls.Add(panels[0]);
            }
            else if (button.Text == "Update Category")
            {
                operationsPanel.Controls.Clear();
                panels[1].Visible = true;
                operationsPanel.Controls.Add(panels[1]);
            }
            else if (button.Text == "Delete Category")
            {
                operationsPanel.Controls.Clear();
                panels[2].Visible = true;
                operationsPanel.Controls.Add(panels[2]);
            }
            ResetTextBoxes();
        }

        private void OnCloseBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OnComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
