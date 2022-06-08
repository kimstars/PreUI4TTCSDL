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
    public partial class Admin_ThemNV : UserControl
    {
        public Admin_ThemNV()
        {
            InitializeComponent();
        }

        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();
        private bool CheckPassword(string passwd)
        {

            if (passwd.Length < 6)
            {
                lbMsg.Text = "Mật khẩu tối thiếu là 6 kí tự.";
                return false;
            }
            if (passwd.Contains(" "))
            {
                lbMsg.Text = "Mật khẩu không chứa khoảng trắng.";
                return false;
            }


            return true;
        }
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtMatKhau.Text;
            string pass1 = txtMatKhau1.Text;
            bool check1, check2, check3;
            check1 = check2 = check3 = true;
            if (user.Trim() == string.Empty)
            {

                errorProvider1.SetError(lbMsg, "Không được để trống!!");
                lbMsg.Text = "Bạn phải nhập Tên đăng nhập!!";
                check1 = false;
            }
            else
            {
                lbMsg.Text = "";
                check1 = true;
            }

            if (pass.Trim() == string.Empty)
            {
                errorProvider1.SetError(lbMsg, "Không được để trống!!");
                lbMsg.Text = "Bạn phải nhập mật khẩu!!";
                check2 = false;
            }
            else if (!CheckPassword(pass))
            {
                errorProvider1.SetError(lbMsg, "Không được để trống!!");
                check2 = false;
            }
            else if (pass != pass1)
            {
                errorProvider1.SetError(lbMsg, "Mật khẩu không khớp nhau !");
                lbMsg.Text = "Mật khẩu không khớp nhau !!";

                check3 = false;

            }
            else
            {
                lbMsg.Text = "";
                errorProvider1.SetError(lbMsg, null);
                check2 = true;
            }

            

            if (check1 && check2 && check3 )
            {
                TaiKhoan tk = new TaiKhoan(user, pass);

                if (tkBus.DangKy(tk,true))
                {
                    MessageBox.Show("Đăng ký thành công !! Hãy điền thông tin nhân viên");
                    panelThongtin.Show();
                    txtMatKhau.Text = "";
                    txtMatKhau1.Text = "";

                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin !");
                }



            }
        }
        NhanVien_BUS nvBus = new NhanVien_BUS();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv1 = new NhanVien();
            nv1.TenNhanVien = txtTenNV.Text;
            nv1.MaNhanVien = txtMaNV.Text;
            nv1.NgaySinh = pickerBirthday.Value;
            nv1.GioiTinh = cbGioitinh.Text;
            nv1.Email = txtEmail.Text;
            nv1.SDT = txtSDT.Text;
            nv1.DiaChi = txtDiaChi.Text;
            nv1.CMND = txtCMND.Text;
            nv1.TenDangNhap = txtUsername.Text;
            nv1.ChucVu = "nhân viên";

            if (nvBus.Them(nv1))
            {
                MessageBox.Show("Thêm thành công một nhân viên");
                dgvThongTin.DataSource = nvBus.GetList();
            }
            else
            {
                MessageBox.Show("Thêm thành công một nhân viên");
            }



        }

        private void Admin_ThemNV_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = nvBus.CreateNext_MaMT();

            dgvThongTin.DataSource = nvBus.GetList();
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            if(cmnd.Length >= 12)
            {
                MessageBox.Show("Số cmnd có độ dài tối đa 12 kí tự!");
                
            }
        }
    }
}
