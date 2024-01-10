using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            canvasPanel.Controls.Add(panel);
        }
        private Panel panel;
        private Panel prev = null;
        private List<Panel> shapes = new List<Panel>();
        private int x = 0, y = 0;
        private int rectangleId = 0, circleId = 0, triangleId = 0;
        private bool isMouseDown = false, isButtonSelected = false;
        
        private void updateProperty(string name, int id)
        {

        }
        private void OnCanvasPanelMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            x = y = 0;
        }

        private void OnCanvasPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                panel.Size = new Size(e.X - x, e.Y - y);
                //x = e.X;
                //y = e.Y;

            }
        }

        private void OnCanvasPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (isButtonSelected)
            {
                isMouseDown = true;
                x = e.X;
                y = e.Y;
                panel.Location = new Point(e.X, e.Y);
            }
            else
            {
                MessageBox.Show("First select shape below and draw..!");
            }
        }

        private void OnShapeButtonClicked(object sender, EventArgs e)
        {
            isButtonSelected = true;
            if(sender is Button b)
            {
                panel = new Panel();
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.Click += OnPanelClicked;
                panel.MouseDown += OnPanelMouseDown;
                panel.MouseUp += OnPanelMouseUp;
                panel.MouseMove += OnPanelMouseMove;
                switch (b.Text)
                {
                    case "Rectangle":
                        panel.BackgroundImage = Properties.Resources.rectangle;
                        panel.Name = b.Text + " : " + (++rectangleId);
                        break;
                    case "Circle":
                        panel.BackgroundImage = Properties.Resources.circle;
                        panel.Name = b.Text + " : " + (++circleId);
                        break;
                    case "Triangle":
                        panel.BackgroundImage = Properties.Resources.triangle;
                        panel.Name = b.Text + " : " + (++triangleId);
                        break;
                    default:
                        break;
                }
                canvasPanel.Controls.Clear();
                shapes.Add(panel);
                foreach (var p in shapes)
                {
                    canvasPanel.Controls.Add(p);
                }
            }
        }
        private void OnPanelClicked(object sender, EventArgs e)
        {
            Panel currentPanel = sender as Panel;
            MouseEventArgs mouseEvent = e as MouseEventArgs;
            if (currentPanel == null || mouseEvent.Button != MouseButtons.Left) return;

            if (prev != null)
            {
                prev.BorderStyle = BorderStyle.None;
            }
            currentPanel.BorderStyle = BorderStyle.FixedSingle;
            prev = currentPanel;
            propertyLabel.Text = currentPanel.Name.ToString();
        }


        private void OnPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void OnPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Panel currentPanel = sender as Panel;
                currentPanel.Left += e.X - x;
                currentPanel.Top += e.Y - y;
            }
        }

        private void OnPanelMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        { 
            if (prev != null)
            {
                if(sender is Button b)
                {
                    switch (b.Text)
                    {
                        case "Rectangle":
                            rectangleId--;
                            break;
                        case "Circle":
                            circleId--;
                            break;
                        case "Triangle":
                            triangleId--;
                            break;
                    }
                }
                canvasPanel.Controls.Remove(prev);
                shapes.Remove(prev);
                prev = null;
            }
            shapes.Clear();
        }
    }
}
