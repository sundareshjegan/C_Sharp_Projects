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
            
            num1 = (int)num1TB.Value;
            num2 = (int) num2TB.Value;
            //r = 
            //r.Show();

        }
        
        private float result;
        private int num1,num2;
        
        public event EventHandler<float> OnResultSent;
        private void CalculateResult(string op)
        {
            ResultForm r = new ResultForm();-+
            r.OnOperatorSent += CalculateResult;
            switch (op)
            {
                case "+":
                    result = num1+ num2;
                    break;
                case "-":
                    result = num1- num2;
                    break;
                case "x":
                    result = num1* num2;
                    break;
                case "÷":
                    result = num2/ num2;
                    break;
            }
            OnResultSent?.Invoke(this,result);
        }
    }
}
