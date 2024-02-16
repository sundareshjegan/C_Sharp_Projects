using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickAndDraw
{
    public partial class ShapesChooseForm : Form
    {
        public ShapesChooseForm()
        {
            InitializeComponent();
        }

        public event EventHandler<string> SendShape;
        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                SendShape.Invoke(this, button.Text);
                Dispose();
            }
        }
    }
}
