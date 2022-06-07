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

       

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void dgvInfoDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = dgvInfoDocGia.Rows[e.RowIndex];
            lbTenDocGia.Text = row.Cells[5].Value.ToString();
            lbMaDocGia.Text = row.Cells[4].Value.ToString();
            string NgaySinh = row.Cells[7].Value.ToString();
            lbNgaySinh.Text = NgaySinh.Remove(NgaySinh.Length - 11, 11);
            lbDiaChi.Text = row.Cells[6].Value.ToString();
            lbGioiTinh.Text = row.Cells[8].Value.ToString();
            lbSoDienThoai.Text = row.Cells[9].Value.ToString();
            lbCMND.Text = row.Cells[10].Value.ToString();
            string NgayDangKi = row.Cells[11].Value.ToString();
            lbNgayDangKi.Text = NgayDangKi.Remove(NgayDangKi.Length - 11, 11);
            ImageConverter objImageConverter = new ImageConverter();
            imageDG.Image = (Image)objImageConverter.ConvertFrom(row.Cells[12].Value);
            imageDG.SizeMode = PictureBoxSizeMode.StretchImage;
            
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
            dgvInfoDocGia.DataSource = dgBus.GetListDGLoc("TatCa");
        }

        private void rbViPham_CheckedChanged(object sender, EventArgs e)
        {
            dgvInfoDocGia.DataSource = dgBus.GetListDGLoc("ViPham");
        }
    }
}
