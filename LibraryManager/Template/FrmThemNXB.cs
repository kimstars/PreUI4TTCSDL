using LibraryManager.BUS;
using LibraryManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Template
{
    public partial class FrmThemNXB : UserControl
    {
        public FrmThemNXB()
        {
            InitializeComponent();
        }

        NhaXuatBan_BUS nxbBus = new NhaXuatBan_BUS();

      

        private void txtMaCuonSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmThemNXB_Load(object sender, EventArgs e)
        {
            dgvNhaXuatBan.DataSource = nxbBus.LoadListNXB();
            txtMaNhaXuatBan.Text = nxbBus.GetLastest_MaNXB();
        }

        private void dgvNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            UserControl temp = new Template.FrmThemDauSach();
            panelShow.Controls.Add(temp);
        }

        private void dgvNhaXuatBan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhaXuatBan.Rows[e.RowIndex];
            txtMaNhaXuatBan.Text = row.Cells[1].Value.ToString();
            txtTenNhaXuatBan.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnThemNXB_Click_1(object sender, EventArgs e)
        {
            NhaXuatBan_BUS nxbBus = new NhaXuatBan_BUS();
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.MaNhaXuatBan = txtMaNhaXuatBan.Text;
            nxb.TenNhaXuatBan = txtTenNhaXuatBan.Text;
            nxb.DiaChi = txtDiaChi.Text;
            nxbBus.ThemThongtinNhap(nxb);
            //Load lai len dgv
            dgvNhaXuatBan.DataSource = nxbBus.LoadListNXB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaXuatBan_BUS nxbBus = new NhaXuatBan_BUS();
            nxbBus.Update(txtMaNhaXuatBan.Text, txtTenNhaXuatBan.Text, txtDiaChi.Text);
            //Load lai len dgv
            dgvNhaXuatBan.DataSource = nxbBus.LoadListNXB();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            txtMaNhaXuatBan.Clear();
            txtTenNhaXuatBan.Clear();
            txtDiaChi.Clear();
            txtMaNhaXuatBan.Text = nxbBus.GetLastest_MaNXB();
        }
    }
}
