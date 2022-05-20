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
        string Current_Mamuon = "";

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
            phieuMT.MaDocGia = cbMaDG.Text.Trim();
            phieuMT.MaMuonTra = txtMaMT.Text.Trim();
            phieuMT.MaNhanVien = cbNV.Text.Trim();
            phieuMT.NgayMuon = dateMuon.Value;
            phieuMT.HanTra = dateHanTra.Value;


            TTMuonTra.MaMuonTra = txtMaMT.Text.Trim();
            TTMuonTra.MaSach = cbMaSach.Text.Trim();
            TTMuonTra.NgayTra = null;

            if (cbNhieuSach.Checked)
            {
                msBus.ThemTTMT(TTMuonTra);

            }
            else
            {
                msBus.ThemBothTTMT(phieuMT, TTMuonTra);
                cbNhieuSach.Checked = true;
                dateMuon.Value = randDate.Next();
                AutoTaoMa();

                DataTable temp = new DataTable();
                temp = sachBus.LoadMaSach();
                cbMaSach.DataSource = temp;
                cbMaSach.DisplayMember = temp.Columns[0].ToString();


                

            }


            //MessageBox.Show("Thành công!!!");

            dgvThongtinMT.DataSource = msBus.LoadData();
            

            
            RandomCombobox(ref cbMaSach);

        }

        private void AutoTaoMa()
        {
            string index = (dgvThongtinMT.Rows.Count - 1).ToString();
            maMuon = "MT000000";
            Current_Mamuon = txtMaMT.Text;
            maMuon = maMuon.Substring(0, maMuon.Length - index.Length) + index;
            if(maMuon != Current_Mamuon)
            {
                cbNhieuSach.Checked = false;
                txtMaMT.Text = maMuon;
            }



            DateTime date = dateMuon.Value.Add(new TimeSpan(180, 0, 0, 0));
            dateHanTra.Value = date;

        }

        private void RandomCombobox(ref ComboBox comboBox)
        {
            Random random = new Random();
            int newSelectedIndex = comboBox.SelectedIndex;
            while (newSelectedIndex == comboBox.SelectedIndex)
            {
                newSelectedIndex = random.Next(0, comboBox.Items.Count);
            }
            comboBox.SelectedIndex = newSelectedIndex;
        }
        private void cbNhieuSach_CheckedChanged(object sender, EventArgs e)
        {
            AutoTaoMa();
            if (cbNhieuSach.Checked)
            {
                txtMaMT.Text = Current_Mamuon;
            }
            else
            {
                RandomCombobox(ref cbMaDG);
                RandomCombobox(ref cbNV);
            }
        }

        private void txtMaMT_TextChanged(object sender, EventArgs e)
        {
            cbMaDG.Text = dgBus.LoadMaDocGia_PhieuMuon(txtMaMT.Text);
            cbNV.Text = nvBus.LoadMaNhanVien_PhieuMuon(txtMaMT.Text);
        }
    }
}
