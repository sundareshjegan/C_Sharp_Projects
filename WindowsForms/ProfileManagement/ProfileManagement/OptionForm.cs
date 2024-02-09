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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        public event EventHandler<string> SendOption;
        private void OnDeleteBtnClick(object sender, EventArgs e)
        {
            if(sender is Button b)
            {
                SendOption?.Invoke(this, b.Text);
            }
            Dispose();
        }
    }
}
