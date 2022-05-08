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
using LibraryManager.Template;
namespace LibraryManager.GUI
{
    public partial class FrmBienbanVP : Form
    {
        BienbanVP_BUS bbvp_bus = new BienbanVP_BUS();
        Xu_ly_tra xlt = new Xu_ly_tra();
        string madocgia = "";
        string ngaytra = "";
        string maVP = "";
        public FrmBienbanVP()
        {
            InitializeComponent();
        }
        public FrmBienbanVP(string madg, string date)
        {
            madocgia = madg;
            ngaytra = madg;
            InitializeComponent();
        }
        private void txtMadg_TextChanged(object sender, EventArgs e)
        {
            txtTendg.Text = bbvp_bus.Get_tendg(txtMadg.Text);
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            txtTennv.Text = bbvp_bus.Get_tennv(txtManv.Text);
        }

        private void FrmBienbanVP_Load(object sender, EventArgs e)
        {
            txtMadg.Text = madocgia;
            txtNgaytra.Text = ngaytra;
            txtTendg.Text = bbvp_bus.Get_tendg(txtMadg.Text);
            AutoTaoMaVP();

        }
        
        private void AutoTaoMaVP()
        {
            string index = (bbvp_bus.Get_slVP() - 1).ToString();
            maVP = "VP000000";
            maVP = maVP.Substring(0, 8 - index.Length) + index;
            txtMaVP.Text = maVP;

        }
    }
}
