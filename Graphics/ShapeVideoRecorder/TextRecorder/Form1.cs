using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRecorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += OnTimerTick;
            font = new Font(fontName, fontSize);
        }

        private string typedText = "", tempText="";
        private string fontName = "Arial";
        private float fontSize = 14;
        private int index = 0;

        private Pen pen = new Pen(Color.Black, 2);
        private Brush brush = Brushes.Black;
        private Font font;
        private Point textPosition;
        private Timer timer = new Timer();

        private void OnTimerTick(object sender, EventArgs e)
        {
            if(index < tempText.Length)
            {
                index++;
                typedText = tempText.Substring(0,index);
            }
            else
            {
                timer.Stop();
                index = 0;
            }
            Invalidate();
        }

        private void OnFormMouseDown(object sender, MouseEventArgs e)
        {
            textPosition = e.Location;
            Invalidate();
        }

        private void OnFormPaint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(typedText))
            {
                e.Graphics.DrawString(typedText, font, brush, textPosition);
                SizeF textSize = e.Graphics.MeasureString(typedText, font);
                RectangleF rectangle = new RectangleF(textPosition.X, textPosition.Y, textSize.Width+10, textSize.Height);
                e.Graphics.DrawRectangle(pen, Rectangle.Round(rectangle));
            }
        }

        private void OnFormKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                typedText += e.KeyChar;
                tempText = typedText;
                Invalidate();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            typedText = "";
            Invalidate();
        }

        private void OnPlayPauseButtonClicked(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                PlayPauseButton.BackgroundImage = Properties.Resources.PlayImage;
                timer.Stop();
            }
            else
            {
                PlayPauseButton.BackgroundImage = Properties.Resources.PauseImage;
                timer.Start();
            }
        }
    }
}
