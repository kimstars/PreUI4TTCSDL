using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using LibraryManager.BUS;
using LibraryManager.DTO;


namespace LibraryManager.Template
{
    public partial class ThemDocgia : UserControl
    {

        public ThemDocgia()
        {
            InitializeComponent();
        }

        public string ID2
        {
            get { return txtTaikhoan.Text; }
            set { txtTaikhoan.Text = value; }

        }




        private bool validateAll(ref string MaDocGia, string HoTen, string gender, string DiaChi, string sdt, string soCMND, string username)
        {
            if (string.IsNullOrEmpty(HoTen))
            {
                MessageBox.Show(
                "Vui lòng nhập họ và tên",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (int.Parse(DateTime.UtcNow.ToString("yyyy")) - birthdayPicker.Value.Year < 15)
            {
                MessageBox.Show(
                "Vui lòng chọn ngày sinh chính xác!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(DiaChi))
            {
                MessageBox.Show(
                "Vui lòng nhập địa chỉ của bạn!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(sdt) || sdt.Length > 10)
            {
                MessageBox.Show(
                "Vui lòng nhập chính xác số điện thoại của bạn!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(soCMND))
            {
                MessageBox.Show(
                "Vui lòng nhập số cmnd của bạn!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show(
                "Vui lòng nhập tên đăng nhập !",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else
            {
                return true;
            }
        }



        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            string MaDocGia = txtMaDG.Text;
            string HoTen = txtHoten.Text;
            string NgaySinh = birthdayPicker.Text;
            string gender = cbGender.Text;
            string DiaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string soCMND = txtCMND.Text;
            string ngayDK = ngayDKPicker.Text;
            string username = txtTaikhoan.Text;

            if (validateAll(ref MaDocGia, HoTen, gender, DiaChi, sdt, soCMND, username))
            {
                DocGia dg = new DocGia();
                dg.MaDocGia = txtMaDG.Text;
                dg.TenDocGia = txtHoten.Text;
                dg.NgaySinh = birthdayPicker.Value;
                dg.GioiTinh = cbGender.Text;
                dg.DiaChi = txtDiachi.Text;
                dg.SDT = txtSDT.Text;
                dg.CMND = txtCMND.Text;
                dg.NgayDangKi = ngayDKPicker.Value;
                dg.TenDangNhap = txtTaikhoan.Text;
                dg.MatKhau = txtMatkhau.Text;

                if (dgBus.Them(dg))
                {
                    MessageBox.Show(
                    "Thêm thông tin thành công !!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                    "Trùng mã độc giả !!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }


                btnDeleteInfo.Visible = true;
                btnEditInfo.Visible = true;
            }
        }


        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            string MaDocGia = txtMaDG.Text;
            string HoTen = txtHoten.Text;
            string NgaySinh = birthdayPicker.Text;
            string gender = cbGender.Text;
            string DiaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string soCMND = txtCMND.Text;
            string ngayDK = ngayDKPicker.Text;
            string username = txtTaikhoan.Text;

            if (validateAll(ref MaDocGia, HoTen, gender, DiaChi, sdt, soCMND, username))
            {
                DocGia dg = new DocGia();
                dg.MaDocGia = txtMaDG.Text;
                dg.TenDocGia = txtHoten.Text;
                dg.NgaySinh = birthdayPicker.Value;
                dg.GioiTinh = cbGender.Text;
                dg.DiaChi = txtDiachi.Text;
                dg.SDT = txtSDT.Text;
                dg.CMND = txtCMND.Text;
                dg.NgayDangKi = ngayDKPicker.Value;
                dg.TenDangNhap = txtTaikhoan.Text;


                if (dgBus.UpdateOne(dg))
                {
                    
                    txtMaDG.Text = "";
                    txtHoten.Text = "";
                    birthdayPicker.Text = "";
                    cbGender.Text = "";
                    txtDiachi.Text = "";
                    txtSDT.Text = "";
                    txtCMND.Text = "";
                    ngayDKPicker.Text = "";
                    txtTaikhoan.Text = "";
                }


                MessageBox.Show(
                "Nhập thông tin thành công !!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông báo", "Bạn có chắc chắn xóa dòng dữ liệu này không ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                dgvInfo.Rows.RemoveAt(rowCurrent);
        }

        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {
            if (tkBus.checkTonTaiTK(txtTaikhoan.Text))
            {
                lbMess.Text = "Tên đăng nhập đã tồn tại!";
            }
            else
            {
                lbMess.Text = "";
            }


        }

        private void btnClearLoad_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "";
            txtMaDG.Text = "";
            txtMatkhau.Text = "";
            txtHoten.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            txtCMND.Text = "";
            cbGender.Text = "";

            txtMaDG.Text = dgBus.CreateNext_MaDG();
            txtMaDG.ReadOnly = true;


        }

        int rowCurrent = 1;

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowCurrent = e.RowIndex;
            if (rowCurrent >= 0)
            {

                txtMaDG.Text = dgvInfo.Rows[rowCurrent].Cells["MaDocGia"].Value.ToString();
                txtHoten.Text = dgvInfo.Rows[rowCurrent].Cells["TenDocGia"].Value.ToString();
                birthdayPicker.Value = DateTime.Parse(dgvInfo.Rows[rowCurrent].Cells["NgaySinh"].Value.ToString());
                cbGender.Text = dgvInfo.Rows[rowCurrent].Cells["GioiTinh"].Value.ToString();
                txtDiachi.Text = dgvInfo.Rows[rowCurrent].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvInfo.Rows[rowCurrent].Cells["SDT"].Value.ToString();
                txtCMND.Text = dgvInfo.Rows[rowCurrent].Cells["CMND"].Value.ToString();
                ngayDKPicker.Value = DateTime.Parse(dgvInfo.Rows[rowCurrent].Cells["NgayDangKi"].Value.ToString());
                txtTaikhoan.Text = dgvInfo.Rows[rowCurrent].Cells["TenDangNhap"].Value.ToString();
            }

            btnDeleteInfo.Visible = true;
            btnEditInfo.Visible = true;
            txtMaDG.ReadOnly = false;
        }


        DocGia_BUS dgBus = new DocGia_BUS();
        private void QLInfoDocgia_Load(object sender, EventArgs e)
        {
            dgvInfo.DataSource = dgBus.GetList();

            txtMaDG.Text = dgBus.CreateNext_MaDG();
            txtMaDG.ReadOnly = true;




        }
    }
}
