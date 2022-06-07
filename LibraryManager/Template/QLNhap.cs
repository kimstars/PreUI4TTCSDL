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


namespace LibraryManager.Template
{
    public partial class QLNhap : UserControl
    {
        public QLNhap()
        {
            InitializeComponent();
        }
        NhanVien_BUS nvBus = new NhanVien_BUS();
        PhieuNhap_BUS pnBus = new PhieuNhap_BUS();

        private void QLNhap_Load(object sender, EventArgs e)
        {
            dgvDSPhieunhap.DataSource = pnBus.DSPN_LoadList();

            LoadNVIndex(0);
        }
        string MaNVCurrent;
        DateTime NgayNhapCurrent;
        private void LoadNVIndex(int i)
        {
            string MaNV = dgvDSPhieunhap.Rows[i].Cells["MaNhanVien"].Value.ToString();

            lbTenNV.Text = nvBus.GetName(MaNV);

            lbNgaynhap.Text = dgvDSPhieunhap.Rows[i].Cells["NgayNhap"].Value.ToString();

            string MaPN = dgvDSPhieunhap.Rows[i].Cells["MaPhieuNhap"].Value.ToString();

            lbMaPN.Text = MaPN;

            dgvDSDausach.DataSource = pnBus.DSPN_TTPN_Ma(MaPN);

            MaNVCurrent = MaNV;
            NgayNhapCurrent = DateTime.Parse(lbNgaynhap.Text);

        }

        private void dgvDSPhieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                LoadNVIndex(index);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDSPhieunhap.DataSource = pnBus.DSPN_TimKiem(txtSearch.Text);

        }

        private void btnCreateRP_Click(object sender, EventArgs e)
        {
            Report.PhieuNhapCreator tkcreator = new Report.PhieuNhapCreator(MaNVCurrent, NgayNhapCurrent);
            tkcreator.ShowReportHoaDon();
        }
    }
}
