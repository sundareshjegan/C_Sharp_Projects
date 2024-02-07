using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inpform.SendUserDetailsToMainForm += GetUser;
        }
        public static event EventHandler<string> SendNewColName;

        private string headerFilePath = "D:\\Sundareshwaran\\C_Sharp_Projects\\WindowsForms\\ProfileManagement\\Appdata\\cols.txt";
        private InputForm inpform = new InputForm();
        private GetColForm newColForm;
        private List<string> lines = new List<string>();

        private void RetriveOldData()
        {
            FileStream fs = new FileStream(InputUC.filepath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str != null)
            {
                lines.Add(str);
                str = sr.ReadLine();
            }
            foreach(string line in lines)
            {
                string[] temp = line.Split('|');
                displayTable.Rows.Add(temp);
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            RetriveOldData();
            displayTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetUser(object sender, List<string> user)
        {
            FileStream fs = new FileStream(InputUC.filepath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str != null)
            {
                lines.Add(str);
                str = sr.ReadLine();
            }
            string[] temp = lines[lines.Count - 1].Split('|');
            displayTable.Rows.Add(temp);
        }
        private void OnAddRowBtnClicked(object sender, EventArgs e)
        {
            inpform.ShowDialog();
        }

        private void OnAddColBtnClicked(object sender, EventArgs e)
        {
            newColForm = new GetColForm();
            newColForm.SendNewColName += GetNewColName;
            newColForm.Location = addColBtn.PointToScreen(new Point(0, 0));
            newColForm.Show();
        }

        private void GetNewColName(object sender, string newColName)
        {
            displayTable.Columns.Add(newColName, newColName);
            Width += 100;
            //FileStream fs = new FileStream(headerFilePath, FileMode.Append, FileAccess.Read);
            //StreamWriter sw = new StreamWriter(fs);
            
            SendNewColName?.Invoke(this, newColName);
            newColForm?.Dispose();
        }
    }
}
