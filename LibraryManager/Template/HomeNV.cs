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
    public partial class HomeNV : UserControl
    {
        Home_BUS homeNV = new Home_BUS();
        public HomeNV()
        {
            InitializeComponent();
        }

        private void HomeNV_Load(object sender, EventArgs e)
        {
            long ts = homeNV.GetTongSach();
            int ts1 = Convert.ToInt32(ts);
            lbTongSach.Text = ts1.ToString();
            long dg = homeNV.GetTongDG();
            int dg1 = Convert.ToInt32(dg);
            lbTongDG.Text = dg1.ToString();
            long ds = homeNV.GetTongDS();
            int ds1 = Convert.ToInt32(ds);
            lbTongDS.Text = ds1.ToString();

            DataTable sachmoi = homeNV.LoadSachMoi();
            dgvSachMoi.DataSource = sachmoi;

            DataTable muon = homeNV.LoadPhieuMuon();
            dgvMuonTra.DataSource = muon;
            DataTable tra = homeNV.LoadPhieuTra();
            dgvMuonTra.DataSource = tra;
            muon.Merge(tra);
            DataTable result = muon;
            dgvMuonTra.DataSource = muon;

            long sc = homeNV.GetSachCo();
            int sc1 = Convert.ToInt32(sc);
            chartSach.Series["sach"].Points.AddXY(" ", sc1.ToString());
            long sm = homeNV.GetSachMuon();
            int sm1 = Convert.ToInt32(sm);
            chartSach.Series["sach"].Points.AddXY(" ", sm1.ToString());
        }
    }
}
