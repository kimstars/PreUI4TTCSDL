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
    public partial class PhieuMuon : UserControl
    {
        private static PhieuMuon _instance;
        public static PhieuMuon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PhieuMuon();
                return _instance;
            }
        }

        public PhieuMuon()
        {
            InitializeComponent();
        }

        public PhieuMuon(string maDG, List<string> dsds)
        {
            InitializeComponent();
            listsach = dsds;
            MaDocGia = maDG;
            lbNVxuly.Text = "Phiếu mượn độc giả";
        }
        public PhieuMuon( List<string> dsds,string maNV)
        {
            InitializeComponent();
            listsach = dsds;
            MaNhanVien = maNV;
            lbNVxuly.Text = $"Nhân viên xử lý: {MaNhanVien}";
            isNV = true;
        }

        bool isNV = false;
        string MaNhanVien;
        string MaDocGia;
        List<string> listsach;


        string MaDauSachCurrent = "DS000000";

        DataTable InfoBorrow = null;

        MuonSach_BUS msBus = new MuonSach_BUS();
        PhieuMuon_BUS pmBus = new PhieuMuon_BUS();
        private void PhieuMuon_Load(object sender, EventArgs e)
        {


            LoadTTDocGia();

            InfoBorrow = msBus.LoadTTSachMuon(listsach);

            dgvInfoBorrow.DataSource = InfoBorrow;

            TinhTienCoc(InfoBorrow);
            DateTime date = DateMuon.Value.Add(new TimeSpan(180, 0, 0, 0));
            dateHanTra.Value = date;

            LoadDetailBook("DS000013");

            lbMaMuonTra.Text = pmBus.CreateNext_MaMT();

        }
        DocGia_BUS dgBus = new DocGia_BUS();
        private void LoadTTDocGia()
        {
            txtMaDG.Text = MaDocGia;
            DocGia onedg = dgBus.GetOne(MaDocGia);
            txtTenDG.Text = onedg.TenDocGia;
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

        DauSach_BUS dsBus = new DauSach_BUS();

        private void LoadDetailBook(string MaDauSach)
        {
            DataTable infobook = dsBus.LoadThongTinSach(MaDauSach);
            if (infobook != null)
            {
                lbInfoTenSach.Text = infobook.Rows[0]["TenDauSach"].ToString();
                lbInfoTenTG.Text = infobook.Rows[0]["TenTacGia"].ToString();
                lbInfoNamXB.Text = infobook.Rows[0]["NamXuatBan"].ToString();
                lbInfoMota.Text = infobook.Rows[0]["MoTa"].ToString();
                imageBook.BackgroundImage = dsBus.LoadAnh(MaDauSach);
                
            }

        }

        private void dgvInfoBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string MaDauSach = dgvInfoBorrow.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();

            if(MaDauSach.Contains("DS")) LoadDetailBook(MaDauSach);
            MaDauSachCurrent = MaDauSach;


            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dgvInfoBorrow.Rows.RemoveAt(e.RowIndex);
                }

            }
            indexCurrent = e.RowIndex;
        }

        int indexCurrent = 1;
        private void btnLoaiBo_Click(object sender, EventArgs e)
        {

            dgvInfoBorrow.Controls.RemoveAt(indexCurrent);
            TinhTienCoc(InfoBorrow);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            GUI.ThongTinSach newform = new GUI.ThongTinSach(MaDauSachCurrent);
            newform.Show();
        }

        // click xác nhận để lưu tạm vào bảng phieumuontra cho nv xử lý
        private void btnMuon_Click(object sender, EventArgs e)
        {
            PhieuMuonTra pmtnew = new PhieuMuonTra();
            pmtnew.MaDocGia = txtMaDG.Text;
            pmtnew.NgayMuon = DateMuon.Value;
            pmtnew.HanTra = dateHanTra.Value;
            pmtnew.MaMuonTra = lbMaMuonTra.Text;
            pmtnew.MaNhanVien = MaNhanVien;


            List<string> DSMaSach = new List<string>();
            for(int i=0;i < dgvInfoBorrow.Rows.Count; i++)
            {
                var tempmds = dgvInfoBorrow.Rows[i].Cells[1].Value.ToString().Trim();
                if(tempmds!="") DSMaSach.Add(tempmds);
            }

            pmBus.InsertMuon(pmtnew, DSMaSach,isNV);

        }

        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {
            if (dgBus.checkTonTaiDG(txtMaDG.Text))
            {
                errorProvider1.SetError(lbMsg, "Tài khoản không tồn tại !");
                lbMsg.Text = "Tài khoản không tồn tại !";
            }
            else
            {
                lbMsg.Text = "";
                errorProvider1.SetError(lbMsg, null);
                txtTenDG.Text = dgBus.LoadTenDG(txtMaDG.Text);
            }
        }
    }
}
