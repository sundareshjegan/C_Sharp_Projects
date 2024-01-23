using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegmentRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int segments;
        private Graphics g;
        private Pen pen = new Pen(Color.Blue, 2);
        private Rectangle rect;
        private void OnSegmentNumericUpDownValueChanged(object sender, EventArgs e)
        {
            segments = (int)SegmentNumericUpDown.Value;
        }
        
        private void OnSegmentsComboBoxDropDown(object sender, EventArgs e)
        {
            SegmentsComboBox.Items.Clear();
            for (int i = 1; i <= segments; i++)
            {
                SegmentsComboBox.Items.Add(i.ToString());
            }
        }

        private void OnCanvasPanelPaint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            rect = new Rectangle(new Point(40, 40), new Size(600, 300));
            g.DrawRectangle(pen, rect);
        }
    }
}
