using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClickAndDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        Pen pen = new Pen(Color.Black, 3);
        List<Point> points = new List<Point>();
        Point[] arr = new Point[10];
        int i = 5;
        int xPos = 100, yPos = 100;
        GraphicsPath path = new GraphicsPath();
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //e.Graphics.DrawLine(pen, new Point(100,100),new Point(500,500));
            //g.DrawRectangle(pen,new Rectangle(new Point(100,100),new Size(300,200)));
            g.SmoothingMode = SmoothingMode.AntiAlias;
           // g.DrawArc(pen, new Rectangle(new Point(100, 100), new Size(50, 50)),0,90);
           // g.DrawArc(pen, new Rectangle(new Point(200, 100), new Size(50, 50)),90,180);
            //g.DrawArc(pen, new Rectangle(new Point(300, 100), new Size(50, 50)),0,360);

            path.AddLine(new PointF(300, 300),new PointF(400,450));
            path.AddLine(new PointF(400, 450),new PointF(200,350));
            path.AddLine(new PointF(200, 350),new PointF(400,350));
            path.AddLine(new PointF(400, 350),new PointF(200,450));
            path.AddLine(new PointF(200, 450),new PointF(300,300));

            g.DrawPath(pen,path);

        }

       
        private void OnFormClicked(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = e as MouseEventArgs;
            points.Add(mouseEvent.Location);        
        }
    }
}
