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
        string imgPath = @"";
        NhanVien nv = new NhanVien();
        TaiKhoan tk = new TaiKhoan();

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

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All file (*.*)|(*.*)";
                dlg.Title = "Chon anh";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgPath = dlg.FileName.ToString();
                    imageAvt.Image = Image.FromFile(imgPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            nv.TenNhanVien = txtName.Text;
            nv.NgaySinh = pickerBirthday.Value;
            nv.Email = txtEmail.Text;
            nv.SDT = txtSDT.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;
            nv.GioiTinh = cbGioitinh.Text;
            nv.MaNhanVien = lbMaNV.Text;
            nv.TenDangNhap = lbTenDangNhap.Text;

            if (nvBus.Sua(nv))
            {
                MessageBox.Show("Cập nhật thành công!!");
            }


            if (imgPath != "")
            {
                nvBus.LuuAnh(MaNhanVien, imgPath);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
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

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtNewpass1.Text != txtNewpass2.Text)
                MessageBox.Show("Nhập lại mật khẩu mới!!");
            else
            {
                tk.MatKhau = txtNewpass1.Text;
            }
            if (nvBus.Sua(nv))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!!");
            }

        }

   
    }
}
