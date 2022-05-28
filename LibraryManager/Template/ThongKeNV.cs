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
    public partial class ThongKeNV : UserControl
    {
        Home_BUS tknv = new Home_BUS();
        public ThongKeNV()
        {
            InitializeComponent();
        }
        Home_BUS homeAdmin = new Home_BUS();
        private void ThongKeNV_Load(object sender, EventArgs e)
        {
            DataTable tiencoc = tknv.LoadTienCoc();
            for (int i = tiencoc.Rows.Count-1; i>=0; i--)
            {

                chartDG.Series["TienCoc"].Points.AddXY(tiencoc.Rows[i]["Thang"].ToString(), tiencoc.Rows[i]["Tien"]);
            }
            DataTable sl = tknv.LoadSLTL();
            for (int i = 0; i < sl.Rows.Count; i++)
            {

                chart1.Series["SoLuong"].Points.AddXY(sl.Rows[i]["TenTheLoai"].ToString(), sl.Rows[i]["SL"]);
            }


            //circle process percent
            long sm =  homeAdmin.GetALLSachMuon();
            int sm1 = Convert.ToInt32(sm);

            long sct = homeAdmin.GetSachChuaTra();
            int sc1 = Convert.ToInt32(sct);

            
            int p = (int)(sc1 * 100 / (sm1));
            circleProcessPercent.ValueByTransition = p;

            lbP_muon.Text += " : " + sm1.ToString();
            lbP_sanco.Text += " : " + sc1.ToString();
        }
    }
}
