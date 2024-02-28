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
            categoryTB.DataSource = ExpenseManager.categories;
            ExpenseManager.OnCategoryUpdated += UpdateCategory;
        }

        public ExpenseInputForm(Expense expense, int id)
        {
            InitializeComponent();
            StartAnimation();
            categoryTB.DataSource = ExpenseManager.categories;
            ExpenseManager.OnCategoryUpdated += UpdateCategory;

            //update the form with existing data
            saveBtn.Text = "Edit";
            editExpenseId = id;

            amountTB.Visible = false;
            NameTB.Text = expense.Name;
            amountNumericUpDown.Value = expense.Amount;
            categoryTB.Text = expense.Category;
            descriptionTB.Text = expense.Description;
            dateTimePicker.Value = expense.Date;
        }
        
        private int editExpenseId = 0;

        private void UpdateCategory(object sender, string e)
        {
            categoryTB.DataSource = null;
            categoryTB.DataSource = ExpenseManager.categories;
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
            Expense expense = new Expense()
            {
                Name = NameTB.Text,
                Amount = (int)amountNumericUpDown.Value,
                Date = dateTimePicker.Value,
                Category = categoryTB.Text,
                Description = descriptionTB.Text,
            };

            if (saveBtn.Text == "Edit")
            {
                ExpenseManager.UpdateExpense(expense, editExpenseId);
            }
            else
            {
                ExpenseManager.AddExpense(expense);
            }
            Dispose();
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

    }
}
