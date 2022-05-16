using LibraryManager.BUS;
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
    public partial class FrmThongTinDG : UserControl
    {
        public FrmThongTinDG()
        {
            InitializeComponent();
        }

        DocGia_BUS dgBus = new DocGia_BUS();

        private void dgvChonDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmThongTinDG_Load(object sender, EventArgs e)
        {
            rbTatCa.Checked = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void dgvInfoDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvInfoDocGia.Rows[e.RowIndex];
            lbTenDocGia.Text = row.Cells[1].Value.ToString();
            lbMaDocGia.Text = row.Cells[0].Value.ToString();
            lbNgaySinh.Text = row.Cells[3].Value.ToString();
            lbDiaChi.Text = row.Cells[2].Value.ToString();
            lbGioiTinh.Text = row.Cells[4].Value.ToString();
            lbSoDienThoai.Text = row.Cells[5].Value.ToString();
            lbCMND.Text = row.Cells[6].Value.ToString();
            lbNgayDangKi.Text = row.Cells[7].Value.ToString();
            lbNgayMuon.Text = row.Cells[10].Value.ToString();
            lbHanTra.Text = row.Cells[11].Value.ToString();
            ImageConverter objImageConverter = new ImageConverter();
            imageDG.Image = (Image)objImageConverter.ConvertFrom(row.Cells[8].Value);
            imageDG.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rbDangMuon_CheckedChanged(object sender, EventArgs e)
        {
            dgvInfoDocGia.DataSource = dgBus.GetListDGLoc("DangMuon");
        }

        private void rbGanDenHan_CheckedChanged(object sender, EventArgs e)
        {
            dgvInfoDocGia.DataSource = dgBus.GetListDGLoc("GanDenHan");
        }

        private void rbQuaHan_CheckedChanged(object sender, EventArgs e)
        {
            dgvInfoDocGia.DataSource = dgBus.GetListDGLoc("QuaHan");
        }

        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            dgvInfoDocGia.DataSource = dgBus.GetListDGInfo();
        }
    }
}
