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

namespace LibraryManager.GUI
{
    public partial class TKeSachCon : Form
    {
        public TKeSachCon()
        {
            InitializeComponent();
        }
        TKeSachCon_BUS Sach = new TKeSachCon_BUS();

        private void txtSachCon_TextChanged(object sender, EventArgs e)
        {
            txtSachCon.Text = Sach.GetSachCon();
        }
    }
}
