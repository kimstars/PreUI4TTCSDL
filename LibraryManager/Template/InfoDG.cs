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
    public partial class InfoDG : UserControl
    {
        public InfoDG()
        {
            InitializeComponent();
        }
        DocGia_BUS dgbus = new DocGia_BUS();

        string imgPath = @"";


        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            dgbus.LuuAnh("DG000001", imgPath);

        }

        private void InfoDG_Load(object sender, EventArgs e)
        {
            //avtImage.Image = dgbus.LoadAnh("DG000001");
            DocGia dg = dgbus.GetOne("DG000001");

            txtName.Text = dg.TenDocGia;
            pickerBirthday.Value = dg.NgaySinh;
            cbGender.Text = dg.GioiTinh;
            txtSDT.Text = dg.SDT;
            txtDiachi.Text = dg.DiaChi;
            txtDonvi.Text = "";
            txtCMND.Text = dg.CMND;


            lbInfoName.Text = dg.TenDocGia;
            lbMaDG.Text = dg.MaDocGia;
            DateTime dateReg = dg.NgayDangKi;
            lbInfoDate.Text = dateReg.ToString("MM/dd/yyyy");

        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All file (*.*)|(*.*)";
                dlg.Title = "Chon anh";
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    imgPath = dlg.FileName.ToString();
                    avtImage.ImageLocation = imgPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
