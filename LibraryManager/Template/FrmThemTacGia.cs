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
    public partial class FrmThemTacGia : UserControl
    {
        public FrmThemTacGia()
        {
            InitializeComponent();
        }

        TacGia_BUS tgBus = new TacGia_BUS();

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmThemTacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = tgBus.LoadListTG();
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTacGia.Rows[e.RowIndex];
            txtMaTacGia.Text = row.Cells[2].Value.ToString();
            txtTenTacGia.Text = row.Cells[3].Value.ToString();

        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            TacGia_BUS tgBus = new TacGia_BUS();
            TacGia tg = new TacGia();
            tg.MaTacGia = txtMaTacGia.Text;
            tg.TenTacGia = txtTenTacGia.Text;
            tgBus.ThemThongtinNhap(tg);
            //Load lai len dgv
            dgvTacGia.DataSource = tgBus.LoadListTG();
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

        private void btnThemNXB_Click_1(object sender, EventArgs e)
        {
            TacGia_BUS tgBus = new TacGia_BUS();
            TacGia tg = new TacGia();
            tg.MaTacGia = txtMaTacGia.Text;
            tg.TenTacGia = txtTenTacGia.Text;
            tgBus.ThemThongtinNhap(tg);
            //Load lai len dgv
            dgvTacGia.DataSource = tgBus.LoadListTG();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TacGia_BUS tgBus = new TacGia_BUS();
            tgBus.Update(txtMaTacGia.Text, txtTenTacGia.Text);
            //Load lai len dgv
            dgvTacGia.DataSource = tgBus.LoadListTG();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Clear();
            txtTenTacGia.Clear();
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTacGia_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTacGia.Rows[e.RowIndex];
            txtMaTacGia.Text = row.Cells[2].Value.ToString();
            txtTenTacGia.Text = row.Cells[3].Value.ToString();
        }
    }
}
