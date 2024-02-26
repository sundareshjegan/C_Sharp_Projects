using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProgram
{
    public partial class Calender : UserControl 
    {
        public Calender()
        {
            InitializeComponent();
            for(int i = 1945; i <= 2090; i++)
            {
                yearCB.Items.Add(i.ToString());
            }
            LoadLabels();
        }

        List<Label> dateLabels = new List<Label>();

        private void LoadLabels()
        {
            dateLabels.Add(l1);
            dateLabels.Add(l2);
            dateLabels.Add(l3);
            dateLabels.Add(l4);
            dateLabels.Add(l5);
            dateLabels.Add(l6);
            dateLabels.Add(l7);
            dateLabels.Add(l8);
            dateLabels.Add(l9);
            dateLabels.Add(l10);
            dateLabels.Add(l11);
            dateLabels.Add(l12);
            dateLabels.Add(l13);
            dateLabels.Add(l14);
            dateLabels.Add(l15);
            dateLabels.Add(l16);
            dateLabels.Add(l17);
            dateLabels.Add(l18);
            dateLabels.Add(l19);
            dateLabels.Add(l20);
            dateLabels.Add(l21);
            dateLabels.Add(l22);
            dateLabels.Add(l23);
            dateLabels.Add(l24);
            dateLabels.Add(l25);
            dateLabels.Add(l26);
            dateLabels.Add(l27);
            dateLabels.Add(l28);
            dateLabels.Add(l29);
            dateLabels.Add(l30);
            dateLabels.Add(l31);
            dateLabels.Add(l32);
            dateLabels.Add(l33);
            dateLabels.Add(l34);
            dateLabels.Add(l35);
            dateLabels.Add(l36);
            dateLabels.Add(l37);
            dateLabels.Add(l38);
            dateLabels.Add(l39);
            dateLabels.Add(l40);
            dateLabels.Add(l41);
        }

        private void ResetLabels()
        {
            foreach (Label l in dateLabels)
            {
                l.ForeColor = Color.Black;
                l.BackColor = this.BackColor;
                l.Text = "";
                l.BorderStyle = BorderStyle.None;
            }
        }

        private void SetLabelDate(int startIndex,int endIndex)
        {
            try
            {
                int count = 0, j = 0;
                for (int i = startIndex; j < endIndex; i++, j++)
                {
                    dateLabels[i].Text = (++count).ToString();
                    dateLabels[i].BorderStyle = BorderStyle.Fixed3D;
                }
            }
            catch (Exception e) { }
            
        }
        
        private void GetCurrentDate()
        {
            if(yearCB.Text!="" && monthCB.Text != "")
            {
                int month = monthCB.SelectedIndex + 1;
                int year = Int32.Parse(yearCB.Text);

                DateTime datetime = new DateTime(year, month, 1);
                string day = datetime.DayOfWeek.ToString();

                int startIndex = GetStartDate(day.ToString());
                int endIndex = GetNoOfDays(month, year);
                SetLabelDate(startIndex, endIndex);
            }
        }

        private int GetStartDate(string day)
        {
            int val = 0;
            switch (day)
            {
                case "Monday":
                    val = 1;
                    break;
                case "Tuesday":
                    val = 2;
                    break;
                case "Wednesday":
                    val = 3;
                    break;
                case "Thursday":
                    val = 4;
                    break;
                case "Friday":
                    val = 5;
                    break;
                case "Saturday":
                    val = 6;
                    break;
                case "Sunday":
                    val = 0;
                    break;
            }
            return val;
        }

        private int GetNoOfDays(int month,int year)
        {
            if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if(month == 2 && year%400==0 || (year%4==0 && year %100 !=0))
            {
                return 29;
            }
            else if(month == 2)
            {
                return 28;
            }
            return 30;
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            ResetLabels();
            GetCurrentDate();
        }

        private void OnTodayBtnClicked(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            int date = now.Day;

            DateTime datetime = new DateTime(year,month,date);
            monthCB.Text = GetMonth(month);
            yearCB.Text = year.ToString();
            dateLabels[26].ForeColor = Color.White;
            dateLabels[26].BackColor = Color.Blue;
        }

        private string GetMonth(int month)
        {
            string monthName = "";
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;

            }
            return monthName;
        }

    }
}
