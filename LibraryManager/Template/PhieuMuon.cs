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
   

        string[] listsach = { "DS000030", "DS000040", "DS000045", "DS000009", "DS000013", "DS000012", "DS00002" };

        string MaDauSachCurrent = "DS000000";



        MuonSach_BUS msBus = new MuonSach_BUS();
        PhieuMuon_BUS pmBus = new PhieuMuon_BUS();
        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            

            DataTable InfoBorrow = msBus.LoadTTSachMuon(listsach);

            dgvInfoBorrow.DataSource = InfoBorrow;

            TinhTienCoc(InfoBorrow);
            DateTime date = DateMuon.Value.Add(new TimeSpan(180, 0, 0, 0));
            dateHanTra.Value = date;

            LoadDetailBook("DS000013");

            lbMaMuonTra.Text = pmBus.CreateNext_MaMT();


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
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            listsach = listsach.Where(var => var != MaDauSachCurrent).ToArray();
            DataTable InfoBorrow = msBus.LoadTTSachMuon(listsach);
            dgvInfoBorrow.DataSource = InfoBorrow;
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

            List<string> DSMaSach = new List<string>();
            for(int i=0;i < dgvInfoBorrow.Rows.Count; i++)
            {
                DSMaSach.Add(dgvInfoBorrow.Rows[i].Cells[0].Value.ToString());
            }


            pmBus.DocGiaMuon(pmtnew, DSMaSach);


        }
    }
}
