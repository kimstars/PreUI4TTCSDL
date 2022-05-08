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
    public partial class DSPhieuMuonNV : UserControl
    {
        public DSPhieuMuonNV()
        {
            InitializeComponent();
        }

        private string MaPhieuMuonCurrent = "";


        PhieuMuon_BUS pmBus = new PhieuMuon_BUS();
        DauSach_BUS dsBus = new DauSach_BUS();

        private void DSPhieuMuonNV_Load(object sender, EventArgs e)
        {
            DateTime date = dateEnd.Value.Subtract(new TimeSpan(30, 0, 0, 0));
            dateStart.Value = date;


            DataTable temp = pmBus.LoadDSPhieumuon();

            dgvDSPhieumuon.DataSource = temp;

            //load thông tin độc giả đầu tiên lên
            string MaDocGia = dgvDSPhieumuon.Rows[0].Cells["MaDocGia"].Value.ToString().Trim();
            LoadDetailUser(MaDocGia);
        }

        private void TinhTienCoc(DataTable InfoBorrow)
        {
            int tong = 0;
            foreach (DataRow row in InfoBorrow.Rows)
            {
                tong += int.Parse(row["GiaTien"].ToString()) * 10 / 100;
            }

            lbTienCoc.Text = tong.ToString() + " VND";
        }


        DocGia_BUS dgBus = new DocGia_BUS();
        private void LoadDetailUser(string MaDocGia)
        {
            DocGia infoDG = dgBus.GetOne(MaDocGia);

            if (infoDG != null)
            {
                lbTenDG.Text = infoDG.TenDocGia;
                lbMaDG.Text = infoDG.MaDocGia;
                lbNgaysinh.Text = DateToString(infoDG.NgaySinh);
                lbSdt.Text = infoDG.SDT;

            }

        }

        public string DateToString(Nullable<DateTime> d)
        {

            if (d != null) return d.Value.ToString("dd/MM/yyyy");
            return "";

        }

        private void dgvDSPhieumuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaPhieuMuon = dgvDSPhieumuon.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            string MaDocGia  = dgvDSPhieumuon.Rows[e.RowIndex].Cells["MaDocGia"].Value.ToString().Trim();
            if (MaPhieuMuon.Contains("MT"))
            {
                DataTable temp = pmBus.Load_Thongtinsachmuon(MaPhieuMuon);
                dgvDSDausach.DataSource = temp;
                MaPhieuMuonCurrent = MaPhieuMuon;
                TinhTienCoc(temp);
            }
            LoadDetailUser(MaDocGia);
            
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            DateTime start = dateStart.Value;
            DateTime end = dateEnd.Value;

            dgvDSPhieumuon.DataSource = pmBus.LoadDSPhieumuon(start, end);

        }

        private void btnXemInfoDG_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if (keyword != "")
            {
            
                dgvDSPhieumuon.DataSource = pmBus.LoadDSPhieumuon(keyword);


            }
            else
            {
                dgvDSPhieumuon.DataSource = pmBus.LoadDSPhieumuon();
            }
        }
    }
}
