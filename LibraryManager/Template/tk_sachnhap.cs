using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Template
{
    public partial class tk_sachnhap : UserControl
    {
        public tk_sachnhap()
        {
            InitializeComponent();
        }

        private void tk_sachnhap_Load(object sender, EventArgs e)
        {
            mtxtNgaynhap.Text = DateTime.Now.ToString("dd/mm/yyyy");
            mtxtNgayden.Text = DateTime.Now.ToString("dd/mm/yyyy");
        }
    }
}
