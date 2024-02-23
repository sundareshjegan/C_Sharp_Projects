using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation2
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        public event EventHandler<string> SendOption;

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }
        private void OnOptionsBtnClicked(object sender, EventArgs e)
        {
            if(sender is Button b)
            {
                SendOption?.Invoke(this, b.Text);
            }
            Dispose();
        }
    }
}
