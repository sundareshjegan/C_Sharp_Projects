using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeShift
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        int currentRow = 0;  
        int currentCol = 0;  
        int labelMargin = 10; 
        public Form1()
        {
            InitializeComponent();
        }

        private Label CreateLabels(int width, int height)
        {
            Label label = new Label()
            {
                Width = width,
                Height = height,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Magenta
            };
            return label;
        }
        private void OnCreateButtonClicked(object sender, EventArgs e)
        {
            int width = (int)widthInputBox.Value;
            int height = (int)heightInputBox.Value;

            Label label = CreateLabels(width, height);
            int x = currentCol * (label.Width + labelMargin);
            int y = currentRow * (label.Height + labelMargin);
            label.Location = new Point(x, y);
            canvasPanel.Controls.Add(label);
            labels.Add(label);

            currentCol++;
            if (currentCol * (label.Width + labelMargin) >= canvasPanel.Width)
            {
                currentRow++;
                currentCol = 0;
            }
        }
    }
}
