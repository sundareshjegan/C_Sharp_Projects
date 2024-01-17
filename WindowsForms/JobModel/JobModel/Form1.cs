using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnCreateButtonClicked(object sender, EventArgs e)
        {
            if (JobRadioButton.Checked)
            {
                CanvasPanel.Controls.Clear();
                CanvasPanel.Controls.Add(new JobInputUserControl());
            }
            else if(ModelRadioButton.Checked)
            {
                CanvasPanel.Controls.Clear();
                CanvasPanel.Controls.Add(new ModelInputUserControl());
            }
            else
            {
                MessageBox.Show("Please select Job/Model");
            }
        }

        private void OnJobRadioButtonClicked(object sender, EventArgs e)
        {

        }
    }
}
