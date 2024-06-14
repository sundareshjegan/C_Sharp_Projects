using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3
{
    public partial class CustomPanel : Panel
    {
        public CustomPanel()
        {
            InitializeComponent();
            ControlAdded += OnCustomPanelControlAdded;
            ControlRemoved += OnCustomPanelControlRemoved;
        }

        public int RowMargin { get; set; }

        public int ColumnMargin { get; set; }

        public int RowPadding { get; set; }

        public int ColumnPadding { get; set; }

        public string RowDefinition
        {
            get
            {
                return rowDefinition;
            }
            set
            {
                rowDefinition = value;
                GetRows();
            }
        }

        public string ColumnDefinition
        {
            get
            {
                return columnDefinition;
            }
            set
            {
                columnDefinition = value;
                GetCols();
            }
        }

        private string rowDefinition;
        private string columnDefinition;
        private int count = 0;
        private string[] rows;
        private string[] cols;
        private int[] colWidth;
        private int[] rowWidth;

        private void OnCustomPanelControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void OnCustomPanelControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        //function to get number of rows and its size
        private void GetRows()
        {
            if (rowDefinition == "" || rowDefinition == null) return;
            int totalParts = 0;
            int totalHeight = Height;
            
            rows = rowDefinition.Split(',');
            rowWidth = new int[rows.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i].Contains("*"))
                {
                    if (rows[i].Length == 1)
                    {
                        totalParts += 1;
                    }
                    else
                    {
                        totalParts += int.Parse(rows[i].Replace("*", ""));
                    }
                }
                else
                {
                    totalHeight -= int.Parse(rows[i]);
                }
            }
            int parts = totalHeight / totalParts;

            for (int i = 0; i < rowWidth.Length; i++)
            {
                if (rows[i].Contains("*"))
                {
                    if (rows[i].Length == 1)
                    {
                        rowWidth[i] = parts;
                    }
                    else
                    {
                        rowWidth[i] = parts * int.Parse(rows[i].Replace("*", ""));
                    }
                }
                else
                {
                    rowWidth[i] = int.Parse(rows[i]);
                }
            }
        }

        //function to get no of columns and its size
        private void GetCols()
        {
            if (columnDefinition == "" || columnDefinition == null) return;

            int totalParts = 0;
            int totalWidth = Width;
            if (columnDefinition!="" && !string.IsNullOrEmpty(columnDefinition) && !string.IsNullOrWhiteSpace(columnDefinition))
            {
                cols = columnDefinition.Split(',');
                colWidth = new int[cols.Length];

                for (int i = 0; i < cols.Length; i++)
                {
                    if (cols[i].Contains("*"))
                    {
                        if(cols[i].Length == 1)
                        {
                            totalParts += 1;
                        }
                        else
                        {
                            totalParts += int.Parse(cols[i].Replace("*", ""));
                        }
                    }                             
                    else
                    {
                        totalWidth -= int.Parse(cols[i]);
                    }
                }
                int parts = totalWidth / totalParts;
                
                for(int i = 0; i < colWidth.Length; i++)
                {
                    if (cols[i].Contains("*"))
                    {
                        if(cols[i].Length == 1)
                        {
                            colWidth[i] = parts;
                        }
                        else
                        {
                            colWidth[i] = parts * int.Parse(cols[i].Replace("*", ""));
                        }
                    }
                    else
                    {
                        colWidth[i] = int.Parse(cols[i]);
                    }
                }
            }
        }
    }
}
