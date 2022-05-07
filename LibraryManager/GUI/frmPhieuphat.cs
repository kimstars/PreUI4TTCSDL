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
    public partial class frmPhieuphat : Form
    {
        BienbanVP_BUS bbvp_bus = new BienbanVP_BUS();

        public frmPhieuphat()
        {
            InitializeComponent();
        }

        private void txtMadg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
