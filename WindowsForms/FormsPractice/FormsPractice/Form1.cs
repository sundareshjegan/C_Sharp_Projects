using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPractice
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        int distance = 0;
        int rows=1, cols=1;
        Label prev = null;
        public Form1()
        {
            InitializeComponent();
            Event event1 = new Event();
            event1.Event4 += Event1_Event4;
            event1.Event5 += Event1_Event5;
        }

        private int Event1_Event4(int a, int b)
        {
            return -1;
        }

        private void Event1_Event5(int a, int b)
        {

        }

        private void Event1_Event1(object sender, int e)
        {
            
        }

        private void OnCreateButtonClicked(object sender, EventArgs e)
        {
            CreateLabels();
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            //rowsTB.Value = 1;
            //colsTB.Value = 1;
            canvasPanel.Controls.Clear();
        }

        private void OnFormResized(object sender, EventArgs e)
        { 
            int labelWidth = canvasPanel.Width / cols;
            int labelHeight = canvasPanel.Height / rows;
            int count = 0;
            foreach (Label label in labels)
            {                
                label.Size = new Size(labelWidth, labelHeight);
                label.Location = new Point((count % cols) * (labelWidth + distance), (count / cols) * (labelHeight + distance));
                count++;
            }
        }

        private void OnLableClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            MouseEventArgs mouseEvent = e as MouseEventArgs;
            if (label == null || mouseEvent.Button != MouseButtons.Left) return;

            if (prev != null)
            {
                prev.BackColor = Color.White;
                prev.ForeColor = Color.Black;
            }

            label.BackColor = Color.Black;
            label.ForeColor = Color.White;
            prev = label;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void rowsTB_ValueChanged(object sender, EventArgs e)
        {
            //CreateLabels();
        }

        private void colsTB_ValueChanged(object sender, EventArgs e)
        {
            //CreateLabels();

        }

        private void CreateLabels()
        {
            canvasPanel.Controls.Clear();
            rows = (int)rowsTB.Value;
            cols = (int)colsTB.Value;
            int currentTotal = rows * cols;
            int existingTotal = labels.Count;
            int diff = existingTotal - currentTotal;
            if(diff > 0 )
            {
                while (diff-- > 0)
                {
                    Label label = labels[labels.Count - 1];
                    label.Click -= OnLableClick;
                    labels.Remove(label);
                }
            }
            else
            {
                while(diff++ < 0)
                {
                    Label label = new Label()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font(Font.FontFamily, 14),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    label.Click += OnLableClick;
                    labels.Add(label);
                }
            }
            int labelWidth = canvasPanel.Width / cols;
            int labelHeight = canvasPanel.Height / rows;
            int i = 0, j = 0,counter=0;
            foreach (Label label in labels)
            {
                label.Location = new Point(j * (labelWidth + distance), i * (labelHeight + distance));
                label.Size = new Size(labelWidth, labelHeight);
                canvasPanel.Controls.Add(label);
                j++;
                label.Text = (++counter) + "";
                if (j == cols)
                {
                    i++;
                    j = 0;
                }
            }

        }
    }
}
