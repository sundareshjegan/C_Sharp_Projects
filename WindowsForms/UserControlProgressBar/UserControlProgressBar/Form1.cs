using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlProgressBar
{
    public partial class Form1 : Form
    {
        Label label = new Label();
        public Form1()
        {
            InitializeComponent();
            widthHeightUserControl1.ValuesChanged += OnValuesChanged;
            canvasPanel.Controls.Add(label);
        }

        private void OnValuesChanged(object sender, EventArgs e)
        {

            int width = widthHeightUserControl1.CurrentWidth * canvasPanel.Width /100;
            int height = widthHeightUserControl1.CurrentHeight * canvasPanel.Height / 100;
            widthHeightUserControl1.CurrentHeight = height;
            widthHeightUserControl1.CurrentWidth = width;

            label.Width = width;
            label.Height = height;

            label.Location = new Point(10, 10);
            label.BorderStyle = BorderStyle.FixedSingle;

            
        }
    }
}
