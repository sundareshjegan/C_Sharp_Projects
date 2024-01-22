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
            inp.OnResultSent += UpdateResult;
            inp.Show();
        }

        private InputForm inp;

        private void OnRadioButtonClicked(object sender, EventArgs e)
        {
            if (sender is RadioButton r)
            {
                inp.CalculateResult(r.Text);
            }
        }
        private void UpdateResult(object s, string result)
        {
            ResultLabel.Text = result;
        }
    }
}
