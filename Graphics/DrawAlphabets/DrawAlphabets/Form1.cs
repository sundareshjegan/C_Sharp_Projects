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
        }
        private bool isMouseDown = false;
        private bool enabled = true;

        List<Point> points = new List<Point>();
        List<List<Point>> A1 = new List<List<Point>>();
        Point[] pointArr;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (enabled && points.Count>1)
            {
                pointArr = new Point[points.Count];
                for (int i = 0; i < points.Count; i++)
                {
                    pointArr[i] = points[i];
                }
                graphics.DrawLines(new Pen(Color.Red, 2),pointArr);
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
