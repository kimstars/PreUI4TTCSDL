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
    }
}
