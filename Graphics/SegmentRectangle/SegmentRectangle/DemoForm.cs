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
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private bool isMouseDown = false;
        private int rectWidth = 0, rectHeight = 0, rectX = 0, rectY = 0;
        private int minWidth = 200, minHeight = 100;
        private Rectangle rect;
        private Pen pen;
        private Graphics g;
        private void DemoForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            rectX = e.X;
            rectY = e.Y;
        }


        private void DemoForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (rectWidth < minWidth || rectHeight < minHeight)
            {
                rectWidth = minWidth;
                rectHeight = minHeight;
            }
            Invalidate();
        }
    

        private void DemoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                rectWidth = e.X - rectX;
                rectHeight = e.Y - rectY;
                Invalidate();
            }
        }
        private void DemoForm_Paint(object sender, PaintEventArgs e)
        {
            pen = new Pen(Color.Black, 2);
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);

            g.DrawRectangle(pen, rect);
        }
    }
}
