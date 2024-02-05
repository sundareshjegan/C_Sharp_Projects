using System;
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

        public event EventHandler<UserDetails> SendUserDetailsAsArray;
        
        private void GetData(object sender, UserDetails user)
        {
            SendUserDetailsAsArray?.Invoke(this, user);
        }
        private void InputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
