using LibraryManager.BUS;
using LibraryManager.DTO;
using LibraryManager.extentItem;
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
    public partial class FrmThemCuonSach : UserControl
    {
        public FrmThemCuonSach()
        {
            InitializeComponent();
        }
        DauSach_BUS dsBus = new DauSach_BUS();

        private void hideChildForm()
        {
            
        }



        private void FrmNhapCuonSach_Load(object sender, EventArgs e)
        {
            hideChildForm();
            dgvChonDauSach.DataSource = dsBus.LoadListDSMini();
            cbLoaiLoc.Text = "Tên đầu sách";
        }


        private void dgvChonDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvChonDauSach.Rows[e.RowIndex];
            lbInfoTenSach.Text = row.Cells[1].Value.ToString();
            lbInfoMaDS.Text = row.Cells[0].Value.ToString();
            lbInfoTenTG.Text = row.Cells[9].Value.ToString();
            lbInfoNamXB.Text = row.Cells[4].Value.ToString();
            lbInfoTenNXB.Text = row.Cells[11].Value.ToString();
            lbInfoMota.Text = row.Cells[6].Value.ToString();
            ImageConverter objImageConverter = new ImageConverter();
            imageBook.Image = (Image)objImageConverter.ConvertFrom(row.Cells[7].Value);
            imageBook.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnThemDauSach_Click(object sender, EventArgs e)
        {
            hideChildForm();
            panelShow.Controls.Clear();
            UserControl temp = new Template.FrmThemDauSach();
            panelShow.Controls.Add(temp);

        }

        private void frmThemDauSach1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnSummit_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemDauSach_Click_1(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            UserControl temp = new Template.FrmThemDauSach();
            panelShow.Controls.Add(temp);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NhapSach_BUS nsBus = new NhapSach_BUS();
            CuonSach_BUS csBus = new CuonSach_BUS();
            PhieuNhap pn = new PhieuNhap();
            ThongTinNhapSach ttns = new ThongTinNhapSach();
            CuonSach cs = new CuonSach();
            if (csBus.CheckMaSach(txtMaCuonSach.Text) == true) MessageBox.Show("Mã sách đã tồn tại!");
            else
            {
                pn.MaNhanVien = "NV000007";
                pn.MaPhieuNhap = nsBus.AutoTaoMaNhap();
                pn.NgayNhap = DateTime.Now;

                ttns.MaDauSach = lbInfoMaDS.Text;
                ttns.MaPhieuNhap = nsBus.AutoTaoMaNhap();
                ttns.SoLuongSach = 1;

                cs.MaDauSach = lbInfoMaDS.Text;
                cs.MaSach = txtMaCuonSach.Text;
                cs.TinhTrangMoiCu = cbMoiCu.Text;
                cs.TrangThai = false;
                cs.ViTriSach = txtViTriSach.Text;

                csBus.ThemThongtinNhap(cs,pn);


                //Load lai len dgv
            }
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string TuKhoa = txtTuKhoa.Text;
            if (cbLoaiLoc.Text == "Mã đầu sách")
                dgvChonDauSach.DataSource = dsBus.SearchDS(TuKhoa, "MaDauSach");
            else if (cbLoaiLoc.Text == "Tên đầu sách")
                dgvChonDauSach.DataSource = dsBus.SearchDS(TuKhoa, "TenDauSach");
        }
    }
}
