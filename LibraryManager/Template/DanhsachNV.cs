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
    public partial class DanhsachNV : UserControl
    {
        NhanVien_BUS nvbus = new NhanVien_BUS();
        public DanhsachNV()
        {
            InitializeComponent();
        }

        private void DanhsachNV_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = nvbus.GetList();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;


            if (keyword != "")
            {
                dgvNhanvien.DataSource = nvbus.TimKiem(keyword);
            }
            else
            {
                dgvNhanvien.DataSource = nvbus.GetList();
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanvien.Rows[e.RowIndex];
            txtName.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString().Trim();
            pickerBirthday.Value = DateTime.Parse(row.Cells[4].Value.ToString()); ;
            cbGioitinh.SelectedIndex = row.Cells["GioiTinh"].Value.ToString() == "Nam" ? 0 : 1;
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            txtCMND.Text = row.Cells["CMND"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
        }
       

        private void btnAddNV_Click(object sender, EventArgs e)
        {
           

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
