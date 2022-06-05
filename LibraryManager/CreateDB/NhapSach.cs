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

            lbSoluong.Text = nsBus.SoLuongSach_ChuaNhap().ToString();

            DataTable temp = new DataTable();

            temp = nvBus.LoadMaNhanVien();
            cbNV.DataSource = temp;
            cbNV.DisplayMember = temp.Columns[0].ToString();

            AutoTaoMa();
            lbPhieunhap.Text = nsBus.AutoTaoMaNhap();


        }
        private void AutoTaoMa()
        {

            dateNhap.Value = randDate.Next();

            DateTime date = dateNhap.Value.Add(new TimeSpan(180, 0, 0, 0));
            //dateHanTra.Value = date;

        }


  

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDauSach.Rows[e.RowIndex];

            //txtSoluong.Text = nsBus.LoadSLSachChuaNhap(txtMaDauSach.Text);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                lbSoluong.Text = nsBus.SoLuongSach_ChuaNhap().ToString();
                lbPhieunhap.Text = nsBus.AutoTaoMaNhap();
                nsBus.CallProc_Gen_PN(cbNV.Text, dateNhap.Value);


                RandomCombobox(ref cbNV);
                AutoTaoMa();

            }
            dgvTTNhap.DataSource = nsBus.LoadTTNhap();

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
    }
}
