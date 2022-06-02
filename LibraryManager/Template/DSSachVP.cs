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
    public partial class DSSachVP : UserControl
    {
        private static DSSachVP _instance;
        public static DSSachVP Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DSSachVP();
                return _instance;
            }
        }
        public DSSachVP()
        {
            InitializeComponent();
        }
        Home_BUS svp = new Home_BUS();
        private void DSSachVP_Load(object sender, EventArgs e)
        {
            DataTable sachvp = svp.LoadSachVP();
            dgvChonDauSach.DataSource = sachvp;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string _timkiem = txtSearch.Text;
            DataTable sachvp = svp.SearchSachVP(_timkiem);
            dgvChonDauSach.DataSource = sachvp;
        }

        DauSach_BUS dsBus = new DauSach_BUS();

        private void dgvChonDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = e.RowIndex;
            //string MaDS = dgvChonDauSach.Rows[i].Cells["MaDauSach"].Value.ToString().Trim();
            //imageBook.BackgroundImage = dsBus.LoadAnh(MaDS);
            lbInfoTenSach.Text = dgvChonDauSach.Rows[i].Cells["TenDauSach"].Value.ToString();
            lbInfoMaDS.Text = dgvChonDauSach.Rows[i].Cells["MaSach"].Value.ToString();
            lbInfoMaVP.Text = dgvChonDauSach.Rows[i].Cells["MaViPham"].Value.ToString();
            lbInfoDG.Text = dgvChonDauSach.Rows[i].Cells["TenDocGia"].Value.ToString();
            lbtenNV.Text = dgvChonDauSach.Rows[i].Cells["TenNhanVien"].Value.ToString();
            lbInfoNgayTra.Text = dgvChonDauSach.Rows[i].Cells["NgayTra"].Value.ToString();
            lbInfoLyDo.Text = dgvChonDauSach.Rows[i].Cells["LyDo"].Value.ToString();
            lbTienPhat.Text = dgvChonDauSach.Rows[i].Cells["TienPhat"].Value.ToString();

        }
    }
}
