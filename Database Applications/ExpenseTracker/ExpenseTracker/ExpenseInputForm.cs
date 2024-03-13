using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class ExpenseInputForm : Form
    {
        public ExpenseInputForm()
        {
            InitializeComponent();
            StartAnimation();
            SetCategory();
            DBManager.OnAddCategoryUpdated += DBManager_OnDbUpdated;
          //  categoryTB.DataSource = ExpenseManager.categories;
          //  ExpenseManager.OnCategoryUpdated += UpdateCategory;
        }

        private void DBManager_OnDbUpdated(object sender, string e)
        {
            SetCategory();
        }

        public ExpenseInputForm(Expense expense, int id)
        {
            InitializeComponent();
            StartAnimation();
          //  categoryTB.DataSource = ExpenseManager.categories;
          //  ExpenseManager.OnCategoryUpdated += UpdateCategory;

            //update the form with existing data
            saveBtn.Text = "Edit";
            editExpenseId = id;

            //amountTB.Visible = false;
            //NameTB.Text = expense.Name;
            //amountNumericUpDown.Value = expense.Amount;
            //categoryTB.Text = expense.Category;
            //descriptionTB.Text = expense.Description;
            //dateTimePicker.Value = expense.Date;
        }
        
        private int editExpenseId = 0 ;
        private int updateId = 0;

        private void UpdateCategory(object sender, string e)
        {
            // categoryTB.DataSource = ExpenseManager.categories;
        }

        private void StartAnimation()
        {
            //to set height of the form to 0
            Height = 0;
            //to set gif animations
            DoubleBuffered = true;
            gifImage = Properties.Resources.bluegradient;
            animationTimer = new Timer();
            animationTimer.Interval = 20;
            animationTimer.Tick += AnimationTimer_Tick;
            totalFrames = gifImage.GetFrameCount(System.Drawing.Imaging.FrameDimension.Time);
            animationTimer.Start();
        }

        #region animation properties
        private Image gifImage;
        private Timer animationTimer;
        private int currentFrame;
        private int totalFrames;
        #endregion

        #region gif animation events
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % totalFrames;
            Invalidate();

            //To increase Height of the Form While Loading
            if(Height < 350)
            {
                Height += 30;
            }
        }
        private void OnExpenseInputFormPaint(object sender, PaintEventArgs e)
        {
            if (gifImage != null)
            {
                gifImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Time, currentFrame);
                e.Graphics.DrawImage(gifImage, ClientRectangle);
            }
        }
        #endregion

        private void OnAmountTBClick(object sender, EventArgs e)
        {
            amountTB.Visible = false;
        }

        private void OncancelBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OnSaveBtnClicked(object sender, EventArgs e)
        {
            if (categoryCB.Text == "")
            {
                MessageBox.Show("Select Category");
            }
            else if (NameTB.Text == "" || NameTB.Text == "Name")
            {
                MessageBox.Show("Enter name for your Budget");
            }
            else
            {
                Expense expense = new Expense
                {
                    Date = dateTimePicker.Value,
                    Category = categoryCB.Text,
                    Name = NameTB.Text,
                    Amount = (int)amountNumericUpDown.Value,
                    Description = descriptionTB.Text
                };

                if (saveBtn.Text == "Edit")
                {
                    if (DBManager.UpdateExpense(expense, updateId))
                        MessageBox.Show($"Your {expense.Category} limit Budget is exceeded");
                }
                else
                {

                    if (DBManager.AddExpense(expense))
                    {
                        MessageBox.Show($"Your {expense.Category} limit Budget is exceeded");
                    }
                }
                Dispose();
            }
            
        }

        private void OnNameTBClick(object sender, EventArgs e)
        {
            if (NameTB.Text == "Name") 
                NameTB.Text = "";
        }

        private void DescriptionTBClick(object sender, EventArgs e)
        {
            if (descriptionTB.Text == "Description")
                descriptionTB.Text = "";
        }

        private void OnAddCategoryBtnClicked(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.Location = addCategoryBtn.PointToScreen(new Point(0, 0));
            addCategoryForm.ShowDialog();
        }

        public  void SetData(Expense expense)
        {
            updateId = expense.Id;
            saveBtn.Text = "Edit";
            amountTB.Visible = false;
            dateTimePicker.Value = expense.Date;
            categoryCB.Text = expense.Category;
            NameTB.Text = expense.Name;
            amountNumericUpDown.Value = (decimal)expense.Amount;
            descriptionTB.Text = expense.Description;

        }

        public void SetCategory()
        {
            categoryCB.Items.Clear();

            string query = "SELECT CAT_NAME FROM categories";
            MySqlDataReader reader = DBManager.GetReader(query);
            while (reader.Read())
            {
                if (reader.GetString(0) != "Others")
                    categoryCB.Items.Add(reader.GetString(0));
            }
            reader.Close();
            categoryCB.Items.Add("Others");
        }

        private void ExpenseInputForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                OnSaveBtnClicked(sender, e);
            }
        }

        private void ExpenseInputForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
