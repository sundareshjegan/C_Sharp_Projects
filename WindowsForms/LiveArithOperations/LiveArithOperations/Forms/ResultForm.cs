using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveArithOperations
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            inp = new InputForm();
            inp.Show();
        }
        private InputForm inp;
        public delegate void SendOperator(string op);
        public event SendOperator OnOperatorSent;

        private void OnRadioButtonClicked(object sender, EventArgs e)
        {
            inp.OnResultSent += UpdateResult;
            if (sender is RadioButton r){
                OnOperatorSent?.Invoke(r.Text);
            }
        }
        private void UpdateResult(object s,float result) 
        {
            ResultLabel.Text = result.ToString();
        }
    }
}
