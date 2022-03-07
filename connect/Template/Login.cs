using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace connect
{
    public partial class Login : DevExpress.XtraEditors.XtraUserControl
    {
        private model.THUVIEN123Entities2 db = daoo.dbService.db;
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

                dxErrorProvider1.SetError(lbMsg, "ko được để trống!!");
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
                dxErrorProvider1.SetError(lbMsg, "ko được để trống!!");
                lbMsg.Text = "Bạn phải nhập mật khẩu!!";
                check2 = false;
            }else if (!CheckPassword(pass))
            {
                dxErrorProvider1.SetError(lbMsg, "ko được để trống!!");
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

                int cnt = db.DOCGIAs.Where(p => p.MaDocGia == user).ToList().Count;

                if (cnt == 0)
                {
                    MessageBox.Show("Không tồn tại độc giả nào có mã " + user, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                model.DOCGIA nv = db.DOCGIAs.Where(p => p.MaDocGia == user).FirstOrDefault();

                if (nv.MatKhau != pass)
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            




        }
    }
}
