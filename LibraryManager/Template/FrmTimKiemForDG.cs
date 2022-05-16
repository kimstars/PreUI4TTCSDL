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
    public partial class FrmTimKiemForDG : UserControl
    {
        public FrmTimKiemForDG()
        {
            InitializeComponent();
        }

        DauSach_BUS dsBus = new DauSach_BUS();
        TacGia_BUS tgBus = new TacGia_BUS();
        NhaXuatBan_BUS nxbBus = new NhaXuatBan_BUS();
        TheLoai_BUS tlBus = new TheLoai_BUS();
        DataTable temp = new DataTable();
        private void dgvChonDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmTimKiemForDG_Load(object sender, EventArgs e)
        {
            dgvChonDauSach.DataSource = dsBus.LoadListDSMini();
            cbLoaiLoc.Text = "Tên đầu sách";
            

            temp = tgBus.LoadTenTacGia();
            cbTacGia.DataSource = temp;
            cbTacGia.DisplayMember = temp.Columns[2].ToString();

            temp = nxbBus.LoadTenNXB();
            cbNhaXuatBan.DataSource = temp;
            cbNhaXuatBan.DisplayMember = temp.Columns[2].ToString();

            temp = tlBus.LoadTenTheLoai();
            cbTheLoai.DataSource = temp;
            cbTheLoai.DisplayMember = temp.Columns[2].ToString();
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

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string TuKhoa = txtTuKhoa.Text;
            if (cbLoaiLoc.Text == "Mã đầu sách")
            dgvChonDauSach.DataSource = dsBus.SearchDS(TuKhoa,"MaDauSach");
            else if (cbLoaiLoc.Text == "Tên đầu sách")
            dgvChonDauSach.DataSource = dsBus.SearchDS(TuKhoa, "TenDauSach");
        }
        
        private void cbTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        public void LocCacLoai(string LoaiLoc, string TuKhoa)
        {
            
        }

        private void cbTacGia_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }
}
