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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                txtMatkhau.PasswordChar = '\0';
                txtMatkhau1.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '•';
                txtMatkhau1.PasswordChar = '•';
            }
            
        }

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
        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtMatkhau.Text;
            string pass1 = txtMatkhau.Text;
            bool check1, check2, check3,check4;
            check1 = check2 = check3 = check4 = true;
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
            else if(pass != pass1)
            {
                errorProvider1.SetError(lbMsg, "Mật khẩu không khớp nhau !");
                lbMsg.Text = "Mật khẩu không khớp nhau !!";

                check3 = false;

            } else 
            {
                lbMsg.Text = "";
                errorProvider1.SetError(lbMsg, null);
                check2 = true;
            }

            if (btnToggle.Checked)
            {
                check4 = true;
            }

            if (check1 && check2 && check3 && check4)
            {
                TaiKhoan tk = new TaiKhoan(user,pass);

                if (tkBus.DangKy(tk,false))
                {
                    MessageBox.Show("Đăng ký thành công !!. Quay trở lại đăng nhập nào!! ");
                    this.Hide();
                    frmLogin newlogin = new frmLogin();
                    newlogin.Show();

                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin !");
                }

                

            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!tkBus.checkTonTaiTK(txtUsername.Text))
            {
                errorProvider1.SetError(lbMsg, "Tài khoản đã tồn tại !");
                lbMsg.Text = "Tài khoản đã tồn tại !";
            }
            else
            {
                lbMsg.Text = "";
                errorProvider1.SetError(lbMsg, null);
            }
        }
    }
}
