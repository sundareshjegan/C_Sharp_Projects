using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlProgressBar
{
    public partial class WidthHeightUserControl : UserControl
    {
        public WidthHeightUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler ValuesChanged;

        private bool isMouseDown = false;
        private int previousMouseX;
        private double value = 0;

        public int CurrentWidth
        {
            get
            {
                return widthProgressBar.Value;
            }
            set
            {
                widthLabel.Text = value.ToString();
            }
        }
        public int CurrentHeight
        {
            get
            {
                return heightProgressBar.Value;
            }
            set
            {
                heightLabel.Text = value.ToString();
            }
        }
        private void OnWidthProgressBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            isMouseDown = true;
            previousMouseX = e.X;
        }

        private void OnWidthProgressBarMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            previousMouseX = 0;
        }

        private void OnWidthProgressBarMouseMoved(object sender, MouseEventArgs e)
        {
            if (!isMouseDown || widthProgressBar.Value < 0) return;
            if (widthProgressBar.Value >= 100)
            {
                widthProgressBar.Value -= 1;
            }
            if (previousMouseX <= e.X)
            {
                value += 0.6;
                if (value >= 1)
                {
                    widthProgressBar.Value += 1;
                    value = 0;
                }
            }
            else if (widthProgressBar.Value > 0)
            {
                value += 0.6;
                if (value >= 1)
                {
                    widthProgressBar.Value -= 1;
                    value = 0;
                }
            }
            previousMouseX = e.X;
            ValuesChanged?.Invoke(this,EventArgs.Empty);
        }

        private void OnHeightProgressBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            isMouseDown = true;
            previousMouseX = e.X;
        }

        private void OnHeightProgressBarMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            previousMouseX = 0;
        }

        private void OnHeightProgressBarMouseMoved(object sender, MouseEventArgs e)
        {
            if (!isMouseDown || heightProgressBar.Value < 0) return;
            if(heightProgressBar.Value >= 100)
            {
                heightProgressBar.Value -= 1;
            }
            else if (previousMouseX <= e.X)
            {
                value += 0.6;
                if (value >= 1)
                {
                    heightProgressBar.Value += 1;
                    value = 0;
                }
            }
            else if (heightProgressBar.Value > 0)
            {
                value += 0.6;
                if (value >= 1)
                {
                    heightProgressBar.Value -= 1;
                    value = 0;
                }
            }
            previousMouseX = e.X;
            ValuesChanged?.Invoke(this,EventArgs.Empty);
        }


    }
}
