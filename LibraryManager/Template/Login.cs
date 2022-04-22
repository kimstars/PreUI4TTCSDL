
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


namespace LibraryManager
{
    public partial class Login : UserControl
    {

        public Login()
        {
            InitializeComponent();
        }
        // đăng nhập cho độc giả

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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            bool check1, check2, check3;
            check1 = check2 = check3 = true;
            if(user.Trim() == string.Empty)
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
            }else if (!CheckPassword(pass))
            {
                errorProvider1.SetError(lbMsg, "Không được để trống!!");
                check2 = false;
            }
            else
            {
                lbMsg.Text = "";
                check2 = true;
            }

            if (btnToggle.Checked)
            {
                check3 = true;
            }

            if(check1 && check2 && check3)
            {

                TaiKhoan_BUS tk = new TaiKhoan_BUS();

                if (tk.DangNhap(user,pass))
                {
                    MessageBox.Show("Đăng nhập thành công !!" );

                }
                else
                {
                    MessageBox.Show("Không tồn tại độc giả nào có mã " + user, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

            }

            




        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }
    }
}
