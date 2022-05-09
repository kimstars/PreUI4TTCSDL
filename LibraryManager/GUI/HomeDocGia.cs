using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.DTO;
using LibraryManager.BUS;
namespace LibraryManager.GUI
{
    public partial class HomeDocGia : Form
    {
        public HomeDocGia()
        {
            InitializeComponent();
        }
        HomeDocGia_BUS DocGia = new HomeDocGia_BUS();
        private void btnThongbao_Click(object sender, EventArgs e)
        {
            //hideChildForm();
            //GUI.SachTreHan newNhap = new GUI.SachTreHan(); hient thi form thke sach tre han cua Thuy
            //newNhap.Show();
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            // hien thi sach chua tra
        }

        private void btnQLPhieuMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnQLViPham_Click(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            // hien thi form thong tin dgia
        }

        private void btnThuNghiem_Click(object sender, EventArgs e)
        {
            // nhu thu nghiem trang chu
        }

        private void btnSachDaMuon_Click(object sender, EventArgs e)
        {
            //hideChildForm();
            //GUI.SachDaMuon newNhap = new GUI.SachDaMuon(); hient thi form thke sach da muon cua Thuy
            //newNhap.Show();
        }

        private void btnSachDangMuon_Click(object sender, EventArgs e)
        {
            //hideChildForm();
            //GUI.SachChuaTra newNhap = new GUI.SachChuaTra(); hient thi form thke sach chua tra cua Thuy
            //newNhap.Show();
        }

        private void txtDaMuon_TextChanged(object sender, EventArgs e)
        {

            txtDaMuon.Text = DocGia.GetSachDaMuon("DG000001");
        }

        private void txtDangMuon_TextChanged(object sender, EventArgs e)
        {
            txtDangMuon.Text = DocGia.GetSachDangMuon("DG000001");
        }
    }
}
