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
        string MaDocGia = "";
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
        }


        private void LoadRecentActivity()
        {

        }

        public string DateToString(Nullable<DateTime> d)
        {

            if (d != null) return d.Value.ToString("dd/MM/yyyy");
            return "";

        }
    }
}
