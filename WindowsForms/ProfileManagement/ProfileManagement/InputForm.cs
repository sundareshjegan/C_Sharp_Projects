﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileManagement
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            inputUC1.SendUserDetails += GetData;
        }

        public event EventHandler<List<string>> SendUserDetailsToMainForm;
        
        private void GetData(object sender, List<string> user)
        {
            if(sender is Form1 f)
            {
                Height += 50;
            }
            else
            {
                SendUserDetailsToMainForm?.Invoke(this, user); 
                Hide();
            }
        }
        public void Send(string email,string mode)
        {
            inputUC1.SetUCData(email,mode);
        }
    }
}
