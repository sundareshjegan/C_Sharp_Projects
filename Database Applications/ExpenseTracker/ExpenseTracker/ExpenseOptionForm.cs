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
    public partial class ExpenseOptionForm : Form
    {
        public ExpenseOptionForm()
        {
            InitializeComponent();
            Width = 271;
            Height = 0;

            timer.Interval = 10;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if(Height < 135)
            {
                Height += 7;
            }
        }

        private Timer timer = new Timer();

        public delegate void OptionDelegate(string s);
        public event OptionDelegate SendOption;

        private void CloseBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OnBtnClick(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                SendOption?.Invoke(button.Text.ToLower());
            }
            else if(sender is PictureBox pb)
            {
                SendOption?.Invoke(pb.Name.ToLower());
            }
            Dispose();
        }
    }
}
