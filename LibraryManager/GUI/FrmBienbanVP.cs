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
using LibraryManager.Template;
using LibraryManager.DTO;
namespace LibraryManager.GUI
{
    public partial class FrmBienbanVP : Form
    {
        BienbanVP_BUS bbvp_bus = new BienbanVP_BUS();
        Xu_ly_tra xlt = new Xu_ly_tra();
        string madocgia = "";
        string ngaytra = "";
        string maVP = "";
        
        public FrmBienbanVP()
        {
            InitializeComponent();
        }
        public FrmBienbanVP(string madg, string date)
        {
            madocgia = madg;
            ngaytra = date;
            InitializeComponent();
        }
        /*private void txtMadg_TextChanged(object sender, EventArgs e)
        {
            txtTendg.Text = bbvp_bus.Get_tendg(txtMadg.Text);
        }*/

       

        private void FrmBienbanVP_Load(object sender, EventArgs e)
        {
            txtMadg.Text = madocgia;
            txtNgaytra.Text = ngaytra;
            txtTendg.Text = bbvp_bus.Get_tendg(txtMadg.Text);
            
            cmbManv.DataSource = bbvp_bus.getManv();
            cmbManv.DisplayMember = "manhanvien";
            
            txtTennv.Text = bbvp_bus.Get_tennv(cmbManv.Text);
            AutoTaoMaVP();

        }
        
        private void AutoTaoMaVP()
        {
            string index = (bbvp_bus.Get_slVP() - 1).ToString();
            maVP = "VP000000";
            maVP = maVP.Substring(0, 8 - index.Length) + index;
            txtMaVP.Text = maVP;

        }

        private void cmbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTennv.Text = bbvp_bus.Get_tennv(cmbManv.Text);
        }

        private void btnHoanthien_Click(object sender, EventArgs e)
        {
            BienBanViPham bbvp = new BienBanViPham();
            bbvp.MaDocGia = txtMadg.Text;
            bbvp.MaNhanVien = cmbManv.Text;
            bbvp.MaViPham = txtMaVP.Text;
            bbvp.TienPhat = Int32.Parse(txtTienphat.Text);
            string a = "";
            if (cboxTrehan.Checked == true)
            {
                a = cboxTrehan.Text;
            }
            if(cboxHongsach.Checked == true)
            {
                a += cboxHongsach.Text;
            }
            if (cboxMatsach.Checked == true)
            {
                a += cboxMatsach.Text;
            }
            if (cboxKhac.Checked == true)
            {
                txtLydo.ReadOnly = false;
                a += txtLydo.Text;
            }
            bbvp.LyDo = a;
            bbvp.TinhTrangSach = "";
            bbvp_bus.insertBB(bbvp);

            // bbvp.LyDo = lstBoxLydo.Items.cố

        }

        
    }
}
