using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegmentRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private bool isMouseDown = false;
        private bool isSegmentsCreated = false;
        private int segments = 1, segmentIndex = 0;
        private int commonWidth, commonHeight;
        private int rectWidth = 0, rectHeight = 0, rectX = 0, rectY = 0;
        private int minWidth = 200, minHeight = 100;

        private List<Rectangle> rectangles = new List<Rectangle>();
        private List<Color> rectColors = new List<Color>();

        private Graphics g;
        private Rectangle rect, selectedRectangle;
        private Color selectedColor=Color.Black;
        private Pen pen;
        private Point[] points;


        private void OnSegmentNumericUpDownValueChanged(object sender, EventArgs e)
        {
            if (rect.Width<minWidth)
            {
                MessageBox.Show("Draw Rectangle and then Select Segments..!");
                return;
            }
            isSegmentsCreated = true;
            segments = (int)SegmentNumericUpDown.Value;
            SegmentsComboBox.Items.Clear();
            for (int i = 1; i <= segments; i++)
            {
                SegmentsComboBox.Items.Add(i.ToString());
            }
            CreateSegments();
        }

        private void OnSegmentComboBoxSelectedValueChanged(object sender, EventArgs e)
        {
            segmentIndex = int.Parse(SegmentsComboBox.SelectedItem.ToString());
            CanvasPanel.Invalidate();
        }

        #region Check Box Events

        private void OnAllCheckBoxCheckChanged(object sender, EventArgs e)
        {
            SegmentsComboBox.Enabled = !AllCheckBox.Checked;
            CanvasPanel.Invalidate();
        }

        private void OnFillCheckBoxChanged(object sender, EventArgs e)
        {
            CanvasPanel.Invalidate();
        }

        private void OnHorizontalCheckBoxCheckChanged(object sender, EventArgs e)
        {
            CreateSegments();
        }

        #endregion


        #region CanvasPanelEvents
        private void OnCanvasPanelPaint(object sender, PaintEventArgs e)
        {
            pen = new Pen(Color.Black, 2);
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

            rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);
            g.DrawRectangle(pen, rect);
        
            if(rectangles.Count != 0 && segmentIndex!=0)
            {
                pen = new Pen(selectedColor, 2);
                if (IsFillCheckBox.Checked)
                {
                    rectColors[segmentIndex-1] = selectedColor;
                    g.FillRectangle(new SolidBrush(selectedColor), rectangles[segmentIndex - 1]);
                }
                 if(AllCheckBox.Checked)
                {
                    for (int i= 0;i < rectangles.Count;i++)
                    {
                        g.FillRectangle(new SolidBrush(rectColors[i]), rectangles[i]);
                    }
                }
                else
                {
                    g.DrawRectangle(pen, rectangles[segmentIndex - 1]);
                }
            }
        }

        private void OnCanvasPanelMouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            rectX = e.X;
            rectY = e.Y;
        }

        private void OnCanvasPanelMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (rectWidth < minWidth || rectHeight < minHeight)
            {
                rectWidth = minWidth;
                rectHeight = minHeight;
            }
            CanvasPanel.Invalidate();
        }

        private void OnCanvasPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                rectWidth = e.X - rectX;
                rectHeight = e.Y - rectY;
                CanvasPanel.Invalidate();
            }
        }

        #endregion

        private void OnColorSelectButtonClicked(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                selectedColor = cd.Color;
                ColorPanel.BackColor = selectedColor;
            }
            CanvasPanel.Invalidate();
        }

        #region UserDefined Functions
        private void CalculatePoints()
        {
            points = new Point[2 * segments];
            if (IsHorizontalCheckBox.Checked)
            {
                int x = 0;
                int y = rectY;
                commonHeight = rectHeight / segments;

                for (int i = 0; i < 2 * segments; i++)
                {
                    if (i % 2 == 0)
                    {
                        x = rectX;
                        y += commonHeight;
                    }
                    else
                        x = rectWidth + rectX;
                    points[i] = new Point(x, y);
                }
            }
            else
            {
                int x = rectX;
                int y = 0;
                commonWidth = rectWidth / segments;

                for (int i = 0; i < 2 * segments; i++)
                {
                    if (i % 2 == 0)
                    {
                        x += commonWidth;
                        y = rectY;
                    }
                    else
                        y = rectHeight + rectY;
                    points[i] = new Point(x, y);
                }
            }
        }
        private void CreateSegments()
        {
            isSegmentsCreated = true;
            for (int i = 1; i <= segments; i++)
            {
                rectangles.Clear();
                if (IsHorizontalCheckBox.Checked)
                {
                    commonHeight = rectHeight / segments;
                    rectangles.Add(new Rectangle(rectX, rectY, rectWidth, commonHeight));
                    rectColors.Add(Color.Empty);
                    int y = rectY + commonHeight;

                    for (int j = 1; j < segments - 1; j++)
                    {
                        rectangles.Add(new Rectangle(rectX, y, rectWidth, commonHeight));
                        rectColors.Add(Color.Empty);
                        y += commonHeight;
                    }
                }
                else
                {
                    rectangles.Clear();
                    commonWidth = rectWidth / segments;
                    rectangles.Add(new Rectangle(rectX, rectY, commonWidth, rectHeight));
                    rectColors.Add(Color.Empty);
                    int x = rectX + commonWidth;
                    for (int j = 1; j < segments - 1; j++)
                    {
                        rectangles.Add(new Rectangle(x, rectY, commonWidth, rectHeight));
                        rectColors.Add(Color.Empty);
                        x += commonWidth;
                    }
                }
            }
            CanvasPanel.Invalidate();
        }
        #endregion
    }
}
