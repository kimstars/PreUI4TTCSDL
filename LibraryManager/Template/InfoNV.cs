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
    public partial class InfoNV : UserControl
    {
        public InfoNV()
        {
            InitializeComponent();
        }
        public InfoNV(string MaNV)
        {
            InitializeComponent();
            MaNhanVien = MaNV;
        }


        string MaNhanVien = "NV000001";


        NhanVien_BUS nvBus = new NhanVien_BUS();
        private void InfoNV_Load(object sender, EventArgs e)
        {
            DataTable ThongTin = nvBus.LoadThongTinNV(MaNhanVien);

            imageAvt.Image = nvBus.LoadAnh(MaNhanVien);

            lbHoTen.Text = ThongTin.Rows[0]["TenNhanVien"].ToString();
            txtName.Text = ThongTin.Rows[0]["TenNhanVien"].ToString();
            lbMaNV.Text = MaNhanVien;
            lbTenDangNhap.Text = ThongTin.Rows[0]["TenDangNhap"].ToString();
            lbChucvu.Text = ThongTin.Rows[0]["ChucVu"].ToString();
            txtSDT.Text = ThongTin.Rows[0]["SDT"].ToString();
            txtDiaChi.Text = ThongTin.Rows[0]["DiaChi"].ToString().Trim();
            txtCMND.Text = ThongTin.Rows[0]["CMND"].ToString();
            txtEmail.Text = ThongTin.Rows[0]["Email"].ToString();
            pickerBirthday.Value = (DateTime)ThongTin.Rows[0]["NgaySinh"];

            cbGioitinh.Text = ThongTin.Rows[0]["GioiTinh"].ToString();
         


        }
    }
}
