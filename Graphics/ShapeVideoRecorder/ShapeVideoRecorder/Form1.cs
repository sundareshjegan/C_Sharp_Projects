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
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            PlayPauseButton.BackgroundImage = playImage;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        Timer timer;
        #region Variables
        private bool isMouseDown = false;
        private bool isPlay = false;

        private Image playImage = Properties.Resources.PlayImage;
        private Image pauseImage = Properties.Resources.PauseImage;
        private Pen pen = new Pen(Color.Black, 2);
        private List<IShapes> shapes = new List<IShapes>();
        private List<IShapes> drawnShapes = new List<IShapes>();

        private int startX, startY, endX, endY, index = 0;
        private Point[] trianglePoints = new Point[3];
   
     
        private IShapes currentShape;

        static int width,height;
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
            if(PlayPauseButton.BackgroundImage == playImage)
            {
                isPlay = true;
                PlayPauseButton.BackgroundImage = pauseImage;
            }
            else
            {
                isPlay = false;
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
                //PlayPauseButton.Visible = false;
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

            if (isPlay && PlayPauseButton.Visible && index < shapes.Count)
            {
                if (drawnShapes.Count != 0)
                {
                    foreach(IShapes shape in drawnShapes)
                    {
                        if(shape is CustomRectangle rect)
                        {
                            e.Graphics.DrawRectangle(pen,rect.StartX,rect.StartY, rect.EndX-rect.StartX, rect.EndY-rect.StartY);
                        }
                        else if(shape is Circle c)
                        {
                            e.Graphics.DrawEllipse(pen, c.GetCircle());
                        }
                        else if(shape is Triangle t)
                        {
                            e.Graphics.DrawPolygon(pen, t.GetTrianglePoints());
                        }
                    }
                }
                currentShape = shapes[index];
                if(currentShape is CustomRectangle r)
                {
                    e.Graphics.DrawRectangle(pen, r.StartX, r.StartY, width, height);
                    if (width < r.EndX-r.StartX)
                    {
                        width++;
                    }
                    if (height <r.EndY-r.StartY)
                    {
                        height++;
                    }
                    if ((width >= r.EndX-r.StartX)&& (height >= r.EndY - r.StartY))
                    {
                        width = 0;
                        height = 0;
                        index++;
                        drawnShapes.Add(r);
                    }
              

                }
                else if (currentShape is Circle c)
                {
                    if (width < c.EndX - c.StartX)
                    {
                        width++;
                    }
                    if (height < c.EndY - c.StartY)
                    {
                        height++;
                    }
                    e.Graphics.DrawEllipse(pen, c.StartX, c.StartY, width, height);
                    if (!((width < c.EndX - c.StartX) && (height < c.EndY - c.StartY)))
                    {
                        width = height = 0;
                        index++;
                        drawnShapes.Add(c);
                    }
                }
                else if (currentShape is Triangle t)
                {
                    if (width < t.EndX - t.StartX)
                    {
                        width++;
                    }
                    if (height < t.EndY - t.StartY)
                    {
                        height++;
                    }
                    trianglePoints[0] = new Point((t.StartX + t.EndX) / 2, t.StartY);
                    trianglePoints[1] = new Point(t.EndX, t.EndY);
                    trianglePoints[2] = new Point(t.StartX, t.EndY);
                    e.Graphics.DrawPolygon(pen, trianglePoints);
                    if (!((width < t.EndX - t.StartX) && (height < t.EndY - t.StartY)))
                    {
                        width = height = 0;
                        index++;
                        drawnShapes.Add(t);
                    }
                }
            }
            else
            {
                timer.Stop();
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
                        e.Graphics.DrawRectangle(pen, rect.StartX, rect.StartY, rect.EndX-rect.StartX, rect.EndY- rect.StartY );
                       
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
                    if (shape is CustomRectangle rect)
                    {
                        e.Graphics.DrawRectangle(pen, rect.StartX, rect.StartY, rect.EndX - rect.StartX, rect.EndY - rect.StartY);
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
