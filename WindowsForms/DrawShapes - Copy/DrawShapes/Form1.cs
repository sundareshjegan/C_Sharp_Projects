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
        }
        private Panel panel;
        private Panel prevPanel = null;
       // private List<Panel> shapes = new List<Panel>();

        private int x = 0, y = 0;
        private int rectangleId = 0, circleId = 0, triangleId = 0;
        private bool isMouseDown = false, isButtonSelected = false;

        private Image shapeImage = null;
        private string currentImageName = "";        
        
        private void CreatePanel()
        {
            panel = new Panel();
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.BackgroundImage = shapeImage;
            
            panel.Click += OnPanelClicked;
            panel.MouseDown += OnPanelMouseDown;
            panel.MouseUp += OnPanelMouseUp;
            panel.MouseMove += OnPanelMouseMove;
            panel.DoubleClick += OnPanelDoubleClicked;
        }

        private void OnCanvasPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (isButtonSelected)
            {
                isMouseDown = true;
                CreatePanel();
                canvasPanel.Controls.Add(panel);
                panel.BringToFront();

                x = e.X;
                y = e.Y;
                panel.Location = new Point(e.X, e.Y);
            }
            else
            {
                MessageBox.Show("First select shape below and draw..!");
            }
        }

        private void OnCanvasPanelMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            x = y = 0;
            if (panel.Width < 10 || panel.Height < 10)
            {
                canvasPanel.Controls.Remove(panel);
            }
            else
            {
                int id = currentImageName == "Rectangle" ? (++rectangleId) : currentImageName == "Circle" ? (++circleId) : (++triangleId);
                panel.Name = currentImageName + " : " + id;
            }
        }

        private void OnCanvasPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if(e.X < x || e.Y < y)
                {
                    panel.Location = new Point(e.X, e.Y);
                    panel.Size = new Size(x-e.X, y-e.Y);
                }
                else
                panel.Size = new Size(e.X - x, e.Y - y);
            }
        }

        private void OnCanvasPanelClicked(object sender, EventArgs e)
        {
            if (prevPanel == null) return;
            prevPanel.BorderStyle = BorderStyle.None;
            prevPanel = null;
        }

        private void OnShapeButtonClicked(object sender, EventArgs e)
        {
            isButtonSelected = true;
            if(sender is Button b)
            {
                switch (b.Text)
                {
                    case "Rectangle":
                        shapeImage = Properties.Resources.rectangle;
                        currentImageName = b.Text;
                        break;
                    case "Circle":
                        shapeImage = Properties.Resources.circle;
                        currentImageName = b.Text;
                        break;
                    case "Triangle":
                        shapeImage = Properties.Resources.triangle;
                        currentImageName = b.Text;
                        break;
                    default:
                        break;
                }
            }
        }

        private void OnPanelClicked(object sender, EventArgs e)
        {
            Panel currentPanel = sender as Panel;
            MouseEventArgs mouseEvent = e as MouseEventArgs;
            if (currentPanel == null || mouseEvent.Button != MouseButtons.Left) return;

            if (prevPanel != null)
            {
                prevPanel.BorderStyle = BorderStyle.None;
            }
            currentPanel.BorderStyle = BorderStyle.FixedSingle;
            prevPanel = currentPanel;
            propertyLabel.Text = currentPanel.Name.ToString();
        }

        private void OnPanelDoubleClicked(object sender, EventArgs e)
        {
            Panel current = sender as Panel;
            current.BringToFront();
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
            if (prevPanel != null)
            {
                if(sender is Button b)
                {
                    switch (b.Text)
                    {
                        case "Rectangle":
                            --rectangleId;
                            break;
                        case "Circle":
                            --circleId;
                            break;
                        case "Triangle":
                            --triangleId;
                            break;
                    }
                }
                canvasPanel.Controls.Remove(prevPanel);
                //shapes.Remove(prevPanel);
                prevPanel = null;
            }
            //shapes.Clear();
        }
    }
}
