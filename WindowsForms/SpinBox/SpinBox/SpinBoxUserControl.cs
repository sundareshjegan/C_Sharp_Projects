using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinBox
{
    public partial class SpinBoxUserControl : UserControl
    {
        public SpinBoxUserControl()
        {
            InitializeComponent();
            valueTextBox.TextChanged += ValueTextBoxTextChanged;
            valueTextBox.KeyPress += OnEnterKeyPress;
            valueTextBox.Multiline = true;
        }


        private int value = 0;
        private int min = - 5;
        private int max = 100;

        private bool isMouseDown = false;
        private int previousMouseX;
        private double tempValue = 0;

        TextBox valueTextBox = new TextBox();

        

        private void ValueTextBoxTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(valueTextBox.Text, out int n)) value = n;
            else if(n > max) value = max;
            else value = min;
            Update();
        }

        private void Update()
        {
            valueLabel.Text = value.ToString();
            valueTextBox.Text = value.ToString();
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;
            if (button.Text == "+" && value < max) value++;
            else if (button.Text == "-" && value > min) value--;
            Update();
        }

        private void OnDoubleClicked(object sender, EventArgs e)
        {
            valueTextBox.Size = new Size((int)(Width * 0.2), (int)(Height * 0.2));
            valueTextBox.TextAlign = HorizontalAlignment.Center;
            valueTextBox.Text = valueLabel.Text;
            valueTextBox.Location = valueLabel.Location;
            valueTextBox.Font = valueLabel.Font;
            valueTextBox.Focus();
            valueTextBox.Dock = DockStyle.Fill;

            valueLabel.Visible = false;
            valueTextBox.Visible = true;
            Controls.Add(valueTextBox);
        }

        private void OnSpinBoxUserControlMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            isMouseDown = true;
            previousMouseX = e.X;
        }

        private void SpinBoxUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            previousMouseX = 0;
        }

        private void SpinBoxUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown) return;
            if (value >= max)
            {
                value -= 1;
            }
            if (previousMouseX <= e.X)
            {
                tempValue += 0.6;
                if (tempValue >= 1)
                {
                    value++;
                    tempValue = 0;
                }
            }
            else if (value > min)
            {
                tempValue += 0.6;
                if (tempValue >= 1)
                {
                    value--;
                    tempValue = 0;
                }
            }
            previousMouseX = e.X;
            Update();
        }

        private void OnEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                value = max;
                valueTextBox.Visible = false;
                valueLabel.Visible = true;
                valueLabel.Text = value.ToString();
            }
        }
    }
}
