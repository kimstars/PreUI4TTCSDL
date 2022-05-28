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
    public partial class DanhSachDG : UserControl
    {
        public DanhSachDG()
        {
            InitializeComponent();
        }
        DocGia_BUS dgBus = new DocGia_BUS();

        private void DanhSachDG_Load(object sender, EventArgs e)
        {
            dgvDG.DataSource = dgBus.GetList();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            string type = cbFilterDG.Text;

            if (keyword != "")
            {
                dgvDG.DataSource = dgBus.TimKiem(keyword);
            }
            else
            {
                dgvDG.DataSource = dgBus.GetList();
            }
        }
        int rowIcurrent = 0;
        string MaDocGiaCurrent;
        DocGia dg = new DocGia();
        private void dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIcurrent = e.RowIndex;
            if (rowIcurrent >= 0)
            {
                DataGridViewRow row = dgvDG.Rows[e.RowIndex];
                MaDocGiaCurrent = row.Cells["MaDocGia"].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtDiachi.Text = row.Cells[3].Value.ToString();
                pickerBirthday.Value = DateTime.Parse(row.Cells[4].Value.ToString()); ;
                cbGender.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtCMND.Text = row.Cells[7].Value.ToString();
                txtTendangnhap.Text = row.Cells[9].Value.ToString();

                dg.MaDocGia = row.Cells["MaDocGia"].Value.ToString();
                dg.TenDocGia = row.Cells["TenDocGia"].Value.ToString();
                dg.DiaChi = row.Cells["DiaChi"].Value.ToString();
                dg.NgaySinh = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                dg.NgayDangKi = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                dg.CMND = row.Cells["MaDocGia"].Value.ToString();
                dg.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                dg.SDT = row.Cells["SDT"].Value.ToString();
                dg.GioiTinh = row.Cells["GioiTinh"].Value.ToString();

            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu?", "Lưu thông tin độc giả?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgBus.Sua(dg))
                {
                    MessageBox.Show("Lưu thông tin thành công!");
                }
                else
                {
                    MessageBox.Show("Lưu thông tin không thành công! Hãy kiểm tra lại");

                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hệ thống sẽ xóa hết thông tin mượn sách của độc giả \nBạn có chắc chắn muốn xóa?", "Xóa thông tin độc giả?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgBus.Xoa(dg.MaDocGia);
                MessageBox.Show("Xóa thông tin thành công!");

            }
        }
    }
}
