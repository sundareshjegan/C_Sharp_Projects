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
    public partial class TimerOptions : Form
    {
        public TimerOptions()
        {
            InitializeComponent();
            mainForm = new Form1();
        }
        Form1 mainForm;
        public event EventHandler<String> OnTimerOptionClick;
        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button b = sender as Button;
            OnTimerOptionClick?.Invoke(this,b.Text);
            this.Dispose();
        }
    }
}
