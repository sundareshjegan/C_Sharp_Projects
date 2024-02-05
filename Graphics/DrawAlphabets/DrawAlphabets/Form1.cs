using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAlphabets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private bool isMouseDown = false;
        private bool enabled = true;

        List<Point> points = new List<Point>();
        List<List<Point>> A1 = new List<List<Point>>();
        Point[] pointArr;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                // Draw the letter "A"
                path.AddLine(50, 100, 100, 0);
                path.AddLine(100, 0, 150, 100);
                path.AddLine(70, 60, 130, 60);

                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            points.Add(e.Location);
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enabled = !enabled;
            if (enabled)
            {
                A1.Add(points);
            }
        }
            

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
