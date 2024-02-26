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
    public partial class ExpenseInputForm : Form
    {
        public ExpenseInputForm()
        {
            InitializeComponent();
            StartAnimation();

            categoryTB.DataSource= ExpenseManager.categories;

      
        }

        private void StartAnimation()
        {
            DoubleBuffered = true;
            gifImage = Properties.Resources.bluegradient;
            animationTimer = new Timer();
            animationTimer.Interval = 100;
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
            ExpenseManager.AddExpense(expense);
            Dispose();
        }

        private void NameTB_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "Name")
                NameTB.Text = "";

        }

        private void DescriptionTBClick(object sender, EventArgs e)
        {
            if (descriptionTB.Text == "Description")
                descriptionTB.Text = "";
        }
    }
}
