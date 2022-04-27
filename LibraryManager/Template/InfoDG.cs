using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Template
{
    public partial class InfoDG : UserControl
    {
        public InfoDG()
        {
            InitializeComponent();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
                 dgbus.LuuAnh("DG000001", imgPath);
            DateTime t = pickerBirthday.Value.Date;
            MessageBox.Show(t.ToString());
=======
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
>>>>>>> Stashed changes

        }
    }
}
