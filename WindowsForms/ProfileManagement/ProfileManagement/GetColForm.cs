using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProfileManagement
{
    public partial class GetColForm : Form
    {
        public GetColForm()
        {
            InitializeComponent();
            gifImage = Properties.Resources.bg6;
            animationTimer = new Timer();
            animationTimer.Interval = 100;
            animationTimer.Tick += AnimationTimer_Tick;
            totalFrames = gifImage.GetFrameCount(System.Drawing.Imaging.FrameDimension.Time);
            animationTimer.Start();
        }

        public event EventHandler<string> SendNewColName;

        private Image gifImage;
        private Timer animationTimer;
        private int currentFrame;
        private int totalFrames;

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % totalFrames;
            Invalidate();
        }
        private void OnGetColFormPaint(object sender, PaintEventArgs e)
        {
            if (gifImage != null)
            {
                gifImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Time, currentFrame);
                e.Graphics.DrawImage(gifImage, ClientRectangle);
            }
        }
        private void OnOkBtnClicked(object sender, EventArgs e)
        {
            if (newColTB.Text != "")
                SendNewColName?.Invoke(this, newColTB.Text);
        }

        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
