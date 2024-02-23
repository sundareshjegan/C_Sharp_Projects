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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        public event EventHandler<string> SendCategory;

        private void OnOkBtnClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(categoryTB.Text))
                SendCategory?.Invoke(this, categoryTB.Text);
            Dispose();
        }

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
