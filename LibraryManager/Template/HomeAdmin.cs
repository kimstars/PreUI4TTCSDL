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
    public partial class HomeAdmin : UserControl
    {
        Home_BUS homeAdmin = new Home_BUS();
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            long ts = homeAdmin.GetTongSach();
            int ts1 = Convert.ToInt32(ts);
            lbTongSach.Text = ts1.ToString();
            long dg = homeAdmin.GetTongDG();
            int dg1 = Convert.ToInt32(dg);
            lbTongDG.Text = dg1.ToString();
            long ds = homeAdmin.GetTongDS();
            int ds1 = Convert.ToInt32(ds);
            lbTongDS.Text = ds1.ToString();

            DataTable sldg = homeAdmin.LoadSLDG();
            for (int i = 0; i < sldg.Rows.Count; i++)
            {
                
                chartDG.Series["DocGia"].Points.AddXY(sldg.Rows[i]["NAM"].ToString(), sldg.Rows[i]["SL"]);
            }

            long sc = homeAdmin.GetSachCo();
            int sc1 = Convert.ToInt32(sc);
            chartSach.Series["sach"].Points.AddXY(" ", sc1.ToString());
            long sm = homeAdmin.GetSachMuon();
            int sm1 = Convert.ToInt32(sm);
            chartSach.Series["sach"].Points.AddXY(" ", sm1.ToString());
        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }
    }
}
