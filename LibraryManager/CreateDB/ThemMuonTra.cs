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
using LibraryManager.extentItem;

namespace LibraryManager.CreateDB
{
    public partial class ThemMuonTra : Form
    {
        public ThemMuonTra()
        {
            InitializeComponent();
        }

        MuonSach_BUS msBus = new MuonSach_BUS();
        NhanVien_BUS nvBus = new NhanVien_BUS();
        CuonSach_BUS sachBus = new CuonSach_BUS();
        DocGia_BUS dgBus = new DocGia_BUS();

        RandomDateTime randDate = new RandomDateTime();

        PhieuMuonTra phieuMT = new PhieuMuonTra();
        ThongTinMuonTra TTMuonTra = new ThongTinMuonTra();
        string maMuon;
        private void ThemMuonTra_Load(object sender, EventArgs e)
        {
            dgvThongtinMT.DataSource = msBus.LoadData();
            DataTable temp = new DataTable();

            temp = nvBus.LoadMaNhanVien();
            cbNV.DataSource = temp;
            cbNV.DisplayMember = temp.Columns[0].ToString();

            temp = sachBus.LoadMaSach();
            cbMaSach.DataSource = temp;
            cbMaSach.DisplayMember = temp.Columns[0].ToString();

            temp = dgBus.LoadMaDocGia();
            cbMaDG.DataSource = temp;
            cbMaDG.DisplayMember = temp.Columns[0].ToString();

            #region TaoMaTuDong

            AutoTaoMa();
            #endregion

            



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            phieuMT.MaDocGia = cbMaDG.Text;
            phieuMT.MaMuonTra = txtMaMT.Text;
            phieuMT.MaNhanVien = cbNV.Text;
            phieuMT.NgayMuon = dateMuon.Value;
            phieuMT.HanTra = dateHanTra.Value;


            TTMuonTra.MaMuonTra = txtMaMT.Text;
            TTMuonTra.MaSach = cbMaSach.Text;
            TTMuonTra.NgayTra = null;


            msBus.ThemTTMuonTra(phieuMT, TTMuonTra);

            //MessageBox.Show("Thành công!!!");

            dgvThongtinMT.DataSource = msBus.LoadData();

            AutoTaoMa();



        }

        private void AutoTaoMa()
        {
            string index = (dgvThongtinMT.Rows.Count - 1).ToString();
            maMuon = "MT000000";
            maMuon = maMuon.Substring(0, 9 - index.Length) + index;
            txtMaMT.Text = maMuon;


            dateMuon.Value = randDate.Next();

            DateTime date = dateMuon.Value.Add(new TimeSpan(180, 0, 0, 0));
            dateHanTra.Value = date;

        }
    }
}
