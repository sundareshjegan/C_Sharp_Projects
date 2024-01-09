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
        int value = 0;
        TextBox valueTextBox = new TextBox();
        public SpinBoxUserControl()
        {
            InitializeComponent();
            valueTextBox.TextChanged += ValueTextBoxTextChanged;
        }

        private void ValueTextBoxTextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(valueTextBox.Text,out int n)) value = n;
            
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
            if (button.Text == "+") value++;
            else if (button.Text == "-") value--;
            Update();
        }

        private void OnDoubleClicked(object sender, EventArgs e)
        {
            valueTextBox.Text = valueLabel.Text;
            valueTextBox.Width = valueLabel.Width;
            valueTextBox.Height = valueLabel.Height;
            valueTextBox.Location = valueLabel.Location;
            valueTextBox.Font = valueLabel.Font;
            valueLabel.Visible = false;
            Controls.Add(valueTextBox);
        }
    }
}
