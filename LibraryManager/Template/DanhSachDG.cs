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

        private void dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDG.Rows[e.RowIndex];
            txtName.Text = row.Cells[2].Value.ToString();
            txtDiachi.Text = row.Cells[3].Value.ToString();
            pickerBirthday.Value = DateTime.Parse(row.Cells[4].Value.ToString()); ;
            cbGender.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            txtCMND.Text = row.Cells[7].Value.ToString();
            txtTendangnhap.Text = row.Cells[9].Value.ToString();
        }
    }
}
