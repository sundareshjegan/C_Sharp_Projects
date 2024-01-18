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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        JobModelUserControl jobModel  = new JobModelUserControl();
        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            //if (JobRadioButton.Checked)
            //{
            //    EditForm edit = new EditForm(jobModel.JobObject);
                
            //}
            EditForm edit = new EditForm(jobModel);
            jobModel.ReadOnly(false);
            //jobModel = edit.EditedUserControl;
            edit.ShowDialog();

            //jobModel.NameValue = edit.EditedUserControl.NameValue;
            //jobModel.Row = edit.EditedUserControl.Row;
            //jobModel.Column = edit.EditedUserControl.Column;
            //jobModel.Price = edit.EditedUserControl.Price;
            //jobModel.ModelName = edit.EditedUserControl.ModelName;
            //jobModel.RName = edit.EditedUserControl.RName;
        }
        private void OnCreateButtonClicked(object sender, EventArgs e)
        {
            //CanvasPanel.Controls.Clear();
            jobModel.Reset();
            jobModel.ReadOnly(false);
            if (JobRadioButton.Checked)
            {
                CanvasPanel.Controls.Add(jobModel);
                jobModel.ShowModelInfo();
            }
            else if (ModelRadioButton.Checked)
            {
                CanvasPanel.Controls.Add(jobModel);
                jobModel.HideModelInfo();
            }
            else
            {
                MessageBox.Show("Select Job/Model");
            }
            
        }

        private void OnViewButtonClicked(object sender, EventArgs e)
        {
            jobModel.ReadOnly(true);
            if (JobRadioButton.Checked)
            {
                jobModel.NameValue = jobModel.JobObject.Name;
                jobModel.ColumnValue = jobModel.JobObject.Column;
                jobModel.PriceValue = jobModel.JobObject.Price;
                jobModel.ModelNameValue = jobModel.JobObject.Model;
                jobModel.RNameValue = jobModel.JobObject.RName;
                CanvasPanel.Controls.Add(jobModel);
            }
            else if (ModelRadioButton.Checked)
            {
                jobModel.NameValue = jobModel.ModelObject.Name;
                jobModel.RowValue = jobModel.ModelObject.Row;
                jobModel.ColumnValue = jobModel.ModelObject.Column;
                jobModel.PriceValue = jobModel.ModelObject.Price;
                jobModel.HideModelInfo();
                CanvasPanel.Controls.Add(jobModel);
            }
        }

        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            jobModel.Reset();
        }
    }
}
