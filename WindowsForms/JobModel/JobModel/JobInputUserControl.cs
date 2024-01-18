using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobModel
{
    public partial class JobModelUserControl : UserControl
    {
        public JobModelUserControl()
        {
            InitializeComponent();
        }

        public string NameValue { get => Name; set => NameTB.Text = value; }
        public int RowValue { get => RowValue; set => RowTB.Value = value; }
        public int ColumnValue { get => ColumnValue; set => ColTB.Value = value; }
        public int PriceValue { get => PriceValue; set => PriceTB.Value = value; }
        public string ModelNameValue { get => ModelNameValue; set => ModelTB.Text = value; }
        public string RNameValue { get => RNameValue; set => RNameTB.Text = value; }

        //public string NameValue { get ; set ; }
        //public int RowValue { get; set; }
        //public int ColumnValue { get; set; }
        //public int PriceValue { get ; set; }
        //public string ModelNameValue { get; set; }
        //public string RNameValue { get ; set; }

        //public string NameValue
        //{
        //    get => NameTB.Text;
        //    set => NameTB.Text = value;
        //}

        //public int Row
        //{
        //    get => (int)RowTB.Value;
        //    set => RowTB.Value = value;
        //}

        //public int Column
        //{
        //    get => (int)ColTB.Value;
        //    set => ColTB.Value = value;
        //}

        //public int Price
        //{
        //    get => (int)PriceTB.Value;
        //    set => PriceTB.Value = value;
        //}

        //public string ModelName
        //{
        //    get => ModelTB.Text;
        //    set => ModelTB.Text = value;
        //}

        //public string RName
        //{
        //    get => RNameTB.Text;
        //    set => RNameTB.Text = value;
        //}

        public Job JobObject = new Job();
        public Model ModelObject = new Model();

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            if (ModelTB.Visible)
            {
                JobObject.Name = NameTB.Text;
                JobObject.Row = (int)RowTB.Value;
                JobObject.Column = (int)ColTB.Value;
                JobObject.Price = (int)PriceTB.Value;
                JobObject.Model = ModelTB.Text;
                JobObject.RName = RNameTB.Text;
                MessageBox.Show("Data Saved!");

                //NameValue = NameTB.Text;
                //RowValue = (int)RowTB.Value;
                //ColumnValue = (int)ColTB.Value;
                //PriceValue = (int)PriceTB.Value;
                //ModelNameValue = ModelTB.Text;
                //RNameValue = RNameTB.Text;

            }
            else
            {
                ModelObject.Name = NameTB.Text;
                ModelObject.Row = (int)RowTB.Value;
                ModelObject.Column = (int)ColTB.Value;
                ModelObject.Price = (int)PriceTB.Value;
                MessageBox.Show("Data Saved!");
                //NameValue = NameTB.Text;
                //RowValue = (int)RowTB.Value;
                //ColumnValue = (int)ColTB.Value;
                //PriceValue = (int)PriceTB.Value;
            }
            //Reset();
        }
        public void HideModelInfo()
        {
            ModelTB.Visible = false;
            RNameTB.Visible = false;
            ModelLabel.Visible = false;
            RNameLabel.Visible = false;
            SubmitButton.Location = ModelTB.Location;
        }
        public void ShowModelInfo()
        {
            ModelTB.Visible = true;
            RNameTB.Visible = true;
            ModelLabel.Visible = true;
            RNameLabel.Visible = true;
            SubmitButton.Location = new Point(RNameTB.Location.X, RNameTB.Location.Y + 50);
        }
        public void ReadOnly(bool status)
        {
            NameTB.ReadOnly = status;
            RowTB.ReadOnly = status;
            ColTB.ReadOnly = status;
            PriceTB.ReadOnly = status;
            ModelTB.ReadOnly = status;
            RNameTB.ReadOnly = status;
        }
        public void Reset()
        {
            NameTB.Text = "";
            RowTB.Value = 0;
            ColTB.Value = 0;
            PriceTB.Value = 0;
            ModelTB.Text = "";
            RNameTB.Text = "";
        }
    }
}
