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
using LibraryManager.DTO;

namespace LibraryManager.Template
{
    public partial class HomeHello : UserControl
    {
        HomeHello_BUS homeHello = new HomeHello_BUS();
        public HomeHello()
        {
            InitializeComponent();
        }

        DauSach_BUS dsBus = new DauSach_BUS();
        private void HomeHello_Load(object sender, EventArgs e)
        {
            lbTongSach.Text = homeHello.GetTongSach();
            lbTongDG.Text = homeHello.GetTongDG();
            lbTongDS.Text = homeHello.GetTongDS();
            lbTongTL.Text = homeHello.GetTongTL();

            DataTable sachhot = homeHello.Get2Anh();
            pbSach1.BackgroundImage = dsBus.LoadAnh(sachhot.Rows[0]["madausach"].ToString());
            pbSach2.BackgroundImage = dsBus.LoadAnh(sachhot.Rows[1]["madausach"].ToString());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tkiem = txtTimKiem.Text;
            //panelShow.Controls.Clear();

            //UserControl temp = new Template.TimSach();
            //panelShow.Controls.Add(temp);
        }
    }
}
