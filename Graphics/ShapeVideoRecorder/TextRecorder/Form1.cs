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
            timer.Interval = 1000;
            timer.Tick += OnTimerTick;
            font = new Font(fontName, fontSize);
        }

        private void OnTimerButtonClicked(object sender, string buttonText)
        {
            speedLabel.Text = "Speed : "+buttonText;
            if (buttonText.Contains("Slow"))
            {
                timer.Interval = 1000;
                
            }
            else if (buttonText.Contains("Medium"))
            {
                timer.Interval = 500;
            }
            else
            {
                timer.Interval = 100;
            }
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
        private TimerOptions popup;
        private SizeF textSize;
        private RectangleF rectangle;

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
                PlayPauseButton.BackgroundImage = Properties.Resources.PlayImage;
                index = 0;
            }
            Invalidate();
        }

        
        #region FormEvents
        private void OnFormPaint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(typedText))
            {
                e.Graphics.DrawString(typedText, font, brush, textPosition);
                textSize = e.Graphics.MeasureString(typedText, font);
                rectangle = new RectangleF(textPosition.X, textPosition.Y, textSize.Width + 10, textSize.Height);
                if(!timer.Enabled)e.Graphics.DrawRectangle(pen, Rectangle.Round(rectangle));
            }
        }
        private void OnFormKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                typedText += e.KeyChar;
                tempText = typedText;
            }
            if (e.KeyChar == '\b' && typedText.Length > 1)
            {
                typedText = tempText.Substring(0, typedText.Length - 1);
            }
            Invalidate();
        }
        private void OnFormMouseDown(object sender, MouseEventArgs e)
        {
            textPosition = e.Location;
            Invalidate();
        }
        private void OnFormClicked(object sender, EventArgs e)
        {
            popup?.Dispose();
        }
        #endregion

        #region ButtonEvents
        private void OnPlayPauseButtonClicked(object sender, EventArgs e)
        {
            if (typedText == "")
            {
                MessageBox.Show("Start type something..!");
                return;
            }
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
        private void OnTimerButtonClicked(object sender, MouseEventArgs e)
        {
            popup?.Dispose();
            popup = new TimerOptions();
            popup.Location = speedLabel.PointToScreen(new Point(0, 0));
            popup.OnTimerOptionClick += OnTimerButtonClicked;
            popup.Show();
        }
        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            typedText = "";
            Invalidate();
        }
        #endregion
    }
}
