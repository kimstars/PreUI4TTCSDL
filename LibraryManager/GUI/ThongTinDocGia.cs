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

namespace LibraryManager.GUI
{
    public partial class ThongTinDocGia : Form
    {
        public ThongTinDocGia()
        {
            InitializeComponent();
        }

       

        string MaDocGia = "DG000002";
        public ThongTinDocGia(string madg)
        {
            InitializeComponent();
            MaDocGia = madg;
        }
        DocGia_BUS dgBus = new DocGia_BUS();
        private void LoadDetailUser()
        {
            DocGia infoDG = dgBus.GetOne(MaDocGia);

            if (infoDG != null)
            {
                lbTenDG.Text = infoDG.TenDocGia;
                lbMaDG.Text = infoDG.MaDocGia;
                lbNgayDK.Text = DateToString(infoDG.NgayDangKi);
                lbNgaySinh.Text = DateToString(infoDG.NgaySinh);
                lbSDT.Text = infoDG.SDT;
                lbDiaChi.Text = infoDG.DiaChi;
            }

            imageAvt.Image = dgBus.LoadAnh(MaDocGia);

            DataTable muonSL = dgBus.LoadMuon_SL(MaDocGia);
            if (muonSL.Rows.Count > 1)
            {
                DateTime ngayMuon = (DateTime)muonSL.Rows[0]["NgayMuon"];
                lbinfoMuon.Text = $"- Mượn {muonSL.Rows[0]["sl"].ToString()} cuốn sách vào ngày {DateToString(ngayMuon)}";
            }
            else
            {
                lbinfoMuon.Text = "";
            }

            int sachchuatra = dgBus.TongSachChuaTra(MaDocGia);
            if (sachchuatra > 0)
            {
                lbinfoChuaTra.Text = $"- Còn {sachchuatra} cuốn sách chưa trả.";
            }
            else
            {
                lbinfoChuaTra.Text = "Không có sách phải trả.";

            }


            DataTable trasach = dgBus.TraGanDay(MaDocGia);

            if (trasach.Rows.Count > 1)
            {
                DateTime timetra = (DateTime)trasach.Rows[0]["NgayTra"];

                lbinfoTra.Text = $"- Đến trả {trasach.Rows[0]["sl"]} cuốn sách ngày {DateToString(timetra)}";
            }
            else
            {
                lbinfoTra.Text = "";
            }




            dgvViPham.DataSource = dgBus.LoadLoiViPham(MaDocGia);
            dgvDenHan.DataSource = dgBus.LoadSachDenHan(MaDocGia);

        }


        private void LoadRecentActivity()
        {

        }

        public string DateToString(Nullable<DateTime> d)
        {

            if (d != null) return d.Value.ToString("dd/MM/yyyy");
            return "";

        }

        private void ThongTinDocGia_Load(object sender, EventArgs e)
        {
            LoadDetailUser();
        }
    }
}
