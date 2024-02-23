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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            inputUC1.OnSave += OnSaveInvoked;
        }

        private void OnSaveInvoked(object sender, string s)
        {
            if (s == "close")
            {
                Dispose();
            }
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
