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
    public partial class HomeHello : UserControl
    {
        public HomeHello()
        {
            InitializeComponent();
        }
        Home_BUS homeHello = new Home_BUS();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            GUI.FrmDangKy newform = new GUI.FrmDangKy();
            newform.Show();
        }

        private void HomeHello_Load(object sender, EventArgs e)
        {
            long ts = homeHello.GetTongSach();
            int ts1 = Convert.ToInt32(ts);
            lbTongSach.Text = ts1.ToString();

            long dg = homeHello.GetTongDG();
            int dg1 = Convert.ToInt32(dg);
            lbTongDG.Text = dg1.ToString();

            long ds = homeHello.GetTongDS();
            int ds1 = Convert.ToInt32(ds);
            lbTongDS.Text = ds1.ToString();

            long tl = homeHello.GetTongTL();
            int tl1 = Convert.ToInt32(tl);
            lbTongTL.Text = tl1.ToString();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            GUI.Hello_TacGia newform = new GUI.Hello_TacGia();
            newform.Show();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            GUI.Hello_TheLoai newform = new GUI.Hello_TheLoai();
            newform.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GUI.TimKiem4Hello newform = new GUI.TimKiem4Hello(txtSearch.Text);
            newform.Show();
        }
    }
}
