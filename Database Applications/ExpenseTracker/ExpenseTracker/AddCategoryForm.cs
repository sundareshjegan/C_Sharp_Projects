using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExpenseTracker
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
            Width = 258;
            Height = 320;
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            SetUpdateBox();
        }

        private bool isShrink = false;
        private List<Panel> panels = new List<Panel>();

        private void OnFormLoad(object sender, EventArgs e)
        {
            panels.Add(AddCategoryPanel);
            panels.Add(UpdateCategoryPanel);
            panels.Add(DeleteCategoryPanel);

            //MonthCB.DataSource = new BindingSource(ExpenseManager.MonthNumberAndName,null);
            //MonthCB.DisplayMember = "Value";

            //addCategoryMonthCB.DataSource = new BindingSource(ExpenseManager.MonthNumberAndName, null);
            //addCategoryMonthCB.DisplayMember = "Value";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(!isShrink && Width < 610)
            {
                Width += 10;
            }
            else if (isShrink && Width > 255)
            {
                Width -= 10;
            }
        }

        //public event EventHandler<string> CategoryChanged;
        private Timer timer = new Timer();

        private void ResetWarningLabels()
        {
            addWarningLabel.Text = "";
            updateWarningLabel.Text = "";
            deleteWarningLabel.Text = "";
        }

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            isShrink = true;
            operationsPanel.Controls.Clear();
        }

        private void ResetTextBoxes()
        {
            deleteCategoryCB.Text = newCategoryTB.Text = addCategoryMonthCB.Text = "";
            existingCategoryCB.Text = updatedCategoryTB.Text = UpdateMonthCB.Text = "";
            catBudgetTB.Value = newBudgetCB.Value = 1;
            //addWarningLabel.Text = deleteWarningLabel.Text = updateWarningLabel.Text = "";
        }

        private void OnAddBtnClicked(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if(newCategoryTB.Text == "")
            {
                addWarningLabel.Text = "Enter Category Name";
            }
            else if(addCategoryMonthCB.Text=="")
            {
                addWarningLabel.Text = "Select Month";
            }
            else
            {
                try
                {
                    DBManager.AddCategory(newCategoryTB.Text, DBManager.GetMonthNumber(addCategoryMonthCB.Text), (int)catBudgetTB.Value);
                    addWarningLabel.Text = "Category added Successfully..!";
                    ResetTextBoxes();
                    SetUpdateBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Category already existed   " + ex.Message);
                }
            }            
        }

        private void OnUpdateBtnClicked(object sender, EventArgs e)
        {
            try
            {
                DBManager.UpdateCategory(existingCategoryCB.Text, updatedCategoryTB.Text, (int)newBudgetCB.Value);
                updateWarningLabel.Text = "Category Updated Successfully";
                SetUpdateBox();
                ResetTextBoxes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            //if(deleteCategoryCB.Text == "Others")
            //{
            //    deleteWarningLabel.Text = "You cannot delete others category..!";
            //}
            //else
            //{
            // //   ExpenseManager.RemoveCategory(deleteCategoryCB.Text);


            //    deleteWarningLabel.Text = deleteCategoryCB.Text + " Deleted Successfully";
            //    UpdateComboBoxes();
            //}
            if (deleteCategoryCB.Text == "Others")
            {
                deleteWarningLabel.Text = "Please Select Category";
            }
            else
            {
                DBManager.DeleteCategory(deleteCategoryCB.Text);
                SetUpdateBox();
                ResetTextBoxes();
            }
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
                Height = panels[1].Height;
            }
            else if (button.Text == "Update Category")
            {
                operationsPanel.Controls.Clear();
                panels[1].Visible = true;
                operationsPanel.Controls.Add(panels[1]);
                Height = panels[1].Height;
            }
            else if (button.Text == "Delete Category")
            {
                operationsPanel.Controls.Clear();
                panels[2].Visible = true;
                operationsPanel.Controls.Add(panels[2]);
                Height = panels[1].Height;
            }
            ResetTextBoxes();
            ResetWarningLabels();
        }

        private void OnCloseBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OnComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ExistingCategoryCBTextChanged(object sender, EventArgs e)
        {
            updatedCategoryTB.Text = existingCategoryCB.Text;
            try
            {
              //  newBudgetCB.Value = (int)ExpenseManager.categoryDict[existingCategoryCB.Text][MonthCB.SelectedIndex][0];
            }
            catch (Exception ex) {
            }
        }

        private void OnBtnMouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.DodgerBlue;
            button.BackColor = Color.White;
        }

        private void OnBtnMouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DodgerBlue;
            button.ForeColor = Color.White;
        }

        private void SetUpdateBox()
        {
            existingCategoryCB.Items.Clear();
            deleteCategoryCB.Items.Clear();

            string query = "SELECT CAT_NAME FROM categories";
            MySqlDataReader reader = DBManager.GetReader(query);
            while (reader.Read())
            {
                if (reader.GetString(0) != "Others")
                {
                    existingCategoryCB.Items.Add(reader.GetString(0));
                    deleteCategoryCB.Items.Add(reader.GetString(0));
                };
            }
            reader.Close();
        }
    }
}
