using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ShapeVideoRecorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        Timer timer;
        #region Variables
        private bool isMouseDown = false;

        private Image playImage = Properties.Resources.PlayImage;
        private Image pauseImage = Properties.Resources.PauseImage;
        private Pen pen = new Pen(Color.Black, 2);
        private List<IShapes> shapes = new List<IShapes>();

        private int startX, startY, endX, endY, index = 0;
        private Point[] trianglePoints = new Point[3];
   
        private CustomRectangle rect;
        private Triangle triangle;
        private Circle circle;


        static int x, y;
        #endregion

        #region MouseEvents
        private void OnFormMouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startX = e.X;
            startY = e.Y;
        }
        private void OnFormMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            endX = e.X;
            endY = e.Y;
            Invalidate();
        }

        private void OnPlayPauseButtonClicked(object sender, EventArgs e)
        {
            PlayPauseButton.BackgroundImage = playImage;
            if(PlayPauseButton.BackgroundImage == playImage)
            {
                PlayPauseButton.BackgroundImage = pauseImage;
            }
            else
            {
                PlayPauseButton.BackgroundImage = playImage;
            }
            timer.Start();

        }

        private void OnFormMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                endX = e.X;
                endY = e.Y;
                Invalidate();
            }
        }
        #endregion

        private void OnOptionButtonClicked(object sender, EventArgs e)
        {
            if (OptionButton.Text == "StartRecording")
            {
                OptionButton.Text = "Stop";
                ShapeCB.Enabled = true;
            }
            else if (OptionButton.Text == "Stop")
            {
                PlayPauseButton.Visible = true;
                OptionButton.Text = "StartRecording";
                ShapeCB.Enabled = false;
            }
        }

        private void OnFormPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (PlayPauseButton.Text == "Play" && index < shapes.Count)
            {
                if (shapes[index] is CustomRectangle r)
                {
                    rect = new CustomRectangle();
                    if (x < r.EndX)
                    {
                        x += 1;
                    }
                    if (y < r.EndY)
                    {
                        y += 1;
                    }
                    if (!(x < r.EndX && y < r.EndY))
                    {
                      //  x = shapes[index].StartX;
                       // y = shapes[index].StartY;
                        index++;
                    }
                    rect.StartX = r.StartX;
                    rect.StartY = r.StartY;
                    rect.EndX = x;
                    rect.EndY = y;

                    e.Graphics.DrawRectangle(pen, rect.GetRectangle());
                }
                else if (shapes[index] is Triangle t)
                {
                    triangle = new Triangle();
                    if (x < t.EndX)
                    {
                        x += 1;
                    }
                    if (y < t.EndY)
                    {
                        y += 1;
                    }
                    if (!(x < t.EndX && y < t.EndY))
                    {
                        x = shapes[index].StartX;
                        y = shapes[index].StartY;
                        index++;
                    }
                    triangle.StartX = t.StartX;
                    triangle.StartY = t.StartY;
                    triangle.EndX = x;
                    triangle.EndY = y;
                    e.Graphics.DrawPolygon(pen, triangle.GetTrianglePoints());
                }
                else if (shapes[index] is Circle c)
                {
                    circle = new Circle();
                    if (x < c.EndX)
                    {
                        x += 1;
                    }
                    if (y < c.EndY)
                    {
                        y += 1;
                    }
                    if (!(x < c.EndX && y < c.EndY))
                    {
                        x = shapes[index].StartX;
                        y = shapes[index].StartY;
                        index++;
                    }
                    circle.StartX = c.StartX;
                    circle.StartY = c.StartY;
                    circle.EndX = x;
                    circle.EndY = y;

                    e.Graphics.DrawEllipse(pen, circle.GetCircle());
                }
            }


            else
            {
                if (ShapeCB.Enabled)
                {
                    if (ShapeCB.Text == "Rectangle")
                    {
                        CustomRectangle rect = new CustomRectangle()
                        {
                            StartX = startX,
                            StartY = startY,
                            EndX = endX,
                            EndY = endY
                        };
                        e.Graphics.DrawRectangle(pen, rect.GetRectangle());
                        if (!isMouseDown) shapes.Add(rect);
                    }
                    else if (ShapeCB.Text == "Triangle")
                    {
                        Triangle t = new Triangle()
                        {
                            StartX = startX,
                            StartY = startY,
                            EndX = endX,
                            EndY = endY
                        };
                        e.Graphics.DrawPolygon(pen, t.GetTrianglePoints());
                        if (!isMouseDown) shapes.Add(t);
                    }
                    else if (ShapeCB.Text == "Circle")
                    {
                        Circle c = new Circle()
                        {
                            StartX = startX,
                            StartY = startY,
                            EndX = endX,
                            EndY = endY
                        };
                        e.Graphics.DrawEllipse(pen, c.GetCircle());
                        if (!isMouseDown) shapes.Add(c);
                    }
                }
                foreach (IShapes shape in shapes)
                {
                    if (shape is CustomRectangle r)
                    {
                        e.Graphics.DrawRectangle(pen, r.GetRectangle());
                    }
                    else if (shape is Triangle t)
                    {
                        e.Graphics.DrawPolygon(pen, t.GetTrianglePoints());
                    }
                    else if (shape is Circle c)
                    {
                        e.Graphics.DrawEllipse(pen, c.GetCircle());
                    }
                }
            }

        }
    }
}
