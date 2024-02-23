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

        private Rectangle rect;
        private Graphics g;
        private Pen pen = new Pen(Color.Red, 3);

        private ShapesChooseForm shapeForm;

        private List<Rectangle> rectangles = new List<Rectangle>();

        private bool isMouseDown = false;
        private int startX, startY,endX, endY;

        public delegate void DelegateName(string s, int n);

        private void OnFormPaint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            foreach (Rectangle r in rectangles)
            {
                g.DrawRectangle(pen, r);
            }
            if(rect != null)
            {
                rect = new Rectangle(startX, startY, endX - startX, endY - startY);
                g.DrawRectangle(pen, rect);
            }
            
        }

        #region ButtonEvents
        private void OnDrawShapeBtnClicked(object sender, EventArgs e)
        {
            shapeForm = new ShapesChooseForm();
            shapeForm.SendShape += SetShapeText;
            shapeForm.Location = drawShapeBtn.PointToClient(new Point(0, 0));
            shapeForm.ShowDialog();
        }
        #endregion

        #region MouseEvents
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startX = e.X;
            startY = e.Y;
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            endX = e.X;
            endY = e.Y;
            rectangles.Add(rect);
            Invalidate();
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {   
                endX = e.X;
                endY = e.Y;
                Invalidate();
            }
        }
        #endregion

        #region UserDefined Functions
        private void SetShapeText(object sender, string shapeName)
        {
            drawShapeBtn.Text = shapeName;
        }
        #endregion
    }
}
