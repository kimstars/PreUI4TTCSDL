using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.BUS;

namespace LibraryManager.Template
{
    public partial class testLogin : Form
    {
        public testLogin()
        {
            InitializeComponent();
        }

        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            tkBus.ktramatkhau(txtUsername.Text, txtPassword.Text);

            
        }
    }
}
