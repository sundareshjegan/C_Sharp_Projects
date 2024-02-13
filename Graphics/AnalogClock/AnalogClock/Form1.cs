using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            clock.Dock = DockStyle.Fill;
            Controls.Add(clock);
        }
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;

        Clock clock = new Clock();

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.Visible = true;
            
            contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Show Message", null, ShowMessage_Click);
            contextMenuStrip.Items.Add("Exit", null, Exit_Click);
            
            notifyIcon.ContextMenuStrip = contextMenuStrip;
        }
        private void ShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, this is a notification!");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            notifyIcon.Dispose();
            Application.Exit();
        }
    }
}
