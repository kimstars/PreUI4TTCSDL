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
    public partial class FrmThemTheLoai : UserControl
    {
        public FrmThemTheLoai()
        {
            InitializeComponent();
        }
        TheLoai_BUS tlBus = new TheLoai_BUS();

        private void FrmThemTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheLoai.DataSource = tlBus.LoadListTL();
            txtMaTheLoai.Text = tlBus.GetLastest_MaTL();
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            UserControl temp = new Template.FrmThemDauSach();
            panelShow.Controls.Add(temp);
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoai_BUS tlBus = new TheLoai_BUS();
            TheLoai tl = new TheLoai();
            tl.MaTheLoai = txtMaTheLoai.Text;
            tl.TenTheLoai = txtTenTheLoai.Text;
            tlBus.ThemThongtinNhap(tl);
            //Load lai len dgv
            dgvTheLoai.DataSource = tlBus.LoadListTL();
        }

        private void dgvTheLoai_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTheLoai.Rows[e.RowIndex];
            txtMaTheLoai.Text = row.Cells[1].Value.ToString();
            txtTenTheLoai.Text = row.Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TheLoai_BUS tlBus = new TheLoai_BUS();
            tlBus.Update(txtMaTheLoai.Text,txtTenTheLoai.Text);
            //Load lai len dgv
            dgvTheLoai.DataSource = tlBus.LoadListTL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            txtMaTheLoai.Text = tlBus.GetLastest_MaTL();
        }
    }
}
