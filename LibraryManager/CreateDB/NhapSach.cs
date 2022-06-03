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
    public partial class NhapSach : Form
    {
        public NhapSach()
        {
            InitializeComponent();
        }

        RandomDateTime randDate = new RandomDateTime();

        NhapSach_BUS nsBus = new NhapSach_BUS();

        DauSach_BUS dsBus = new DauSach_BUS();

        NhanVien_BUS nvBus = new NhanVien_BUS();


        private void NhapSach_Load(object sender, EventArgs e)
        {
            dgvTTNhap.DataSource = nsBus.LoadTTNhap();

            dgvDauSach.DataSource = dsBus.LoadListDS();


            DataTable temp = new DataTable();
            


            temp = nvBus.LoadMaNhanVien();
            cbNV.DataSource = temp;
            cbNV.DisplayMember = temp.Columns[0].ToString();

            AutoTaoMa();


        }
        string MaNhap;
        private void AutoTaoMa()
        {
            string index = (dgvTTNhap.Rows.Count - 1).ToString();
            MaNhap = "PN000000";
            MaNhap = MaNhap.Substring(0, 8 - index.Length) + index;
            txtMaNhap.Text = MaNhap;


            dateNhap.Value = randDate.Next();

            DateTime date = dateNhap.Value.Add(new TimeSpan(180, 0, 0, 0));
            //dateHanTra.Value = date;

        }


        private void cbMaSach_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMaSach_SelectedValueChanged(object sender, EventArgs e)
        {
           

        }

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDauSach.Rows[e.RowIndex];

            txtMaDauSach.Text = row.Cells[1].Value.ToString();
            //txtSoluong.Text = nsBus.LoadSLSachChuaNhap(txtMaDauSach.Text);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            ThongTinNhapSach ttns = new ThongTinNhapSach();

            pn.MaNhanVien = cbNV.Text;
            pn.MaPhieuNhap = txtMaNhap.Text;
            pn.NgayNhap = dateNhap.Value;

            ttns.MaSach = txtMaDauSach.Text.Trim();
            ttns.MaPhieuNhap = txtMaNhap.Text;

            nsBus.ThemThongtinNhap(pn, ttns);

            dgvTTNhap.DataSource = nsBus.LoadTTNhap();

            AutoTaoMa();


           

        }
    }
}
