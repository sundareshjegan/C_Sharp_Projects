using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobModel
{
    public partial class EditForm : Form
    {
        public EditForm(JobModelUserControl userControlToEdit)
        {
            InitializeComponent();
            //EditedUserControl = new JobModelUserControl
            //{
            //    NameValue = userControlToEdit.NameValue,
            //    Row = userControlToEdit.Row,
            //    Column = userControlToEdit.Column,
            //    Price = userControlToEdit.Price,
            //    ModelName = userControlToEdit.ModelName,
            //    RName = userControlToEdit.RName
            //};
            Controls.Add(userControlToEdit);
        }
        //public JobModelUserControl EditedUserControl;
    }
}
