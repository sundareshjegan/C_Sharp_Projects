using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BigLabel(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OnCreateButtonClicked(object sender, EventArgs e)
        {
            int rows = (int)rowsTB.Value;
            int cols = (int)colsTB.Value;
            int panelWidth = canvasPanel.Width/rows;
            int panelHeight = canvasPanel.Height/cols;
            int distance = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Panel panel = new Panel
                    {
                        Size = new Size(panelWidth, panelHeight),
                        Location = new Point(j * (panelWidth + distance), i * (panelHeight + distance)),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    canvasPanel.Controls.Add(panel);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
