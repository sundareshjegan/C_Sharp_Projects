using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ToggleButtonExample
{
    public partial class Form1 : Form
    {
        private bool isToggled = false;

        public Form1()
        {
            InitializeComponent();
            InitializeToggleButton();
        }

        private void InitializeToggleButton()
        {
            ToggleButton toggleButton = new ToggleButton();
            toggleButton.Size = new Size(70, 30);
            toggleButton.Location = new Point(50, 50);

            toggleButton.Toggled += (sender, e) =>
            {
                isToggled = !isToggled;
                // Do something when the button is toggled
                Console.WriteLine("Toggled: " + isToggled);
            };

            Controls.Add(toggleButton);
        }
    }

    public class ToggleButton : Control
    {
        private bool isToggled = false;
        private Timer animationTimer;
        private int circleX;

        public event EventHandler Toggled;

        public ToggleButton()
        {
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Width = 70;
            Height = 30;

            animationTimer = new Timer();
            animationTimer.Interval = 15;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int targetX = isToggled ? Width - (Height - 4) - 2 : 2;
            int speed = 4;

            if (circleX < targetX)
            {
                circleX = Math.Min(targetX, circleX + speed);
            }
            else if (circleX > targetX)
            {
                circleX = Math.Max(targetX, circleX - speed);
            }
            else
            {
                animationTimer.Stop();
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = CreateRoundedRectanglePath(ClientRectangle, 10))
            using (SolidBrush brush = new SolidBrush(isToggled ? Color.Green : Color.Gray))
            {
                e.Graphics.FillPath(brush, path);
            }

            int circleSize = Height - 4;

            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(brush, circleX, 2, circleSize, circleSize);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            isToggled = !isToggled;
            animationTimer.Start();

            Toggled?.Invoke(this, EventArgs.Empty);
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rectangle.Location, new Size(diameter, diameter));

            // Top left arc
            path.AddArc(arc, 180, 90);
            path.AddLine(rectangle.Left + radius, rectangle.Top, rectangle.Right - radius, rectangle.Top);

            // Top right arc
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            path.AddLine(rectangle.Right, rectangle.Top + radius, rectangle.Right, rectangle.Bottom - radius);

            // Bottom right arc
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            path.AddLine(rectangle.Right - radius, rectangle.Bottom, rectangle.Left + radius, rectangle.Bottom);

            // Bottom left arc
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.AddLine(rectangle.Left, rectangle.Bottom - radius, rectangle.Left, rectangle.Top + radius);

            path.CloseFigure();

            return path;
        }
    }
}
