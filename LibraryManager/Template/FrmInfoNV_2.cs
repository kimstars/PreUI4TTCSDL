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
    public partial class FrmInfoNV_2 : Form
    {
        string user = "load from parent form";
        MatKhau_BUS mkBus = new MatKhau_BUS();
        public FrmInfoNV_2()
        {
            InitializeComponent();
        }

        private void btnSubChangePass_Click(object sender, EventArgs e)
        {
            string passwd = txtOldPass.Text;
            if (!mkBus.CheckExist(user, passwd))
            {
                errorProvider1.SetError(lbMsg, "Mật khẩu cũ không đúng!!");
                lbMsg.Text = "Mật khẩu cũ chưa đúng";
            }
            else
            {
            
            }
        }
    }
}
