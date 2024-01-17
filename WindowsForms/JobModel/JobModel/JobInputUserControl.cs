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
    public partial class JobInputUserControl : UserControl
    {
        public JobInputUserControl()
        {
            InitializeComponent();
        }

        List<JobInputUserControl> jobs = new List<JobInputUserControl>();

        public string Name { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public int Price { get; set; }

        public string Model { get; set; }

        public string RName { get; set; }


        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            Name = NameTB.Text;
            Row = (int)RowTB.Value;
            Column = (int)ColTB.Value;
            Price = (int)PriceTB.Value;
            Model = ModelTB.Text;
            RName = RNameTB.Text;

            jobs.Add(this);
            MessageBox.Show("Created Successfully");
        }
    }
}
