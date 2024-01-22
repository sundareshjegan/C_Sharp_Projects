using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveArithOperations
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private string result;
        private float num1, num2;
        private string op = "+";

        public event EventHandler<string> OnResultSent;

        private void OnInputValueChanged(object sender, EventArgs e)
        {
            CalculateResult(op);
        }

        internal void CalculateResult(string op)
        {
            this.op = op;
            num1 = (int)num1TB.Value;
            num2 = (int)num2TB.Value;
            switch (this.op)
            {
                case "+":
                    result = (num1 + num2).ToString();
                    break;
                case "-":
                    result = (num1 - num2).ToString();
                    break;
                case "x":
                    result = (num1 * num2).ToString();
                    break;
                case "÷":
                    if (num2 == 0) result = "Cannot Divide By Zero";
                    else result = (num1 / num2).ToString();
                    break;
                    
            }
            OnResultSent?.Invoke(this, result);
        }
    }
}
