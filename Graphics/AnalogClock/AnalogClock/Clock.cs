using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Clock : UserControl
    {
        public Clock()
        {
            DoubleBuffered = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private Rectangle rect;
        private Pen pen = new Pen(Color.Black, 3);
        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            rect = new Rectangle(-1,-1,Width, Height);
            e.Graphics.DrawEllipse(pen, rect);
        }
        private Timer timer = new Timer();
    }
}
