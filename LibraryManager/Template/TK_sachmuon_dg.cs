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
namespace LibraryManager.Template
{
    public partial class TK_sachmuon_dg : UserControl
    {
        public TK_sachmuon_dg()
        {
            InitializeComponent();
        }
        ThongKe_BUS tk_buss = new ThongKe_BUS();
        public string chuanhoa(string a)
        {
            return a.ToUpper();
        }
        private void TK_sachmuon_dg_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtMadg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
            }
            if (rbtnDamuon.Checked == true)
            {
                dgvTK.DataSource = tk_buss.Load_tt_sachmuon_dg(chuanhoa(txtMadg.Text));
            }
            else if (rbtnChuaTra.Checked == true)
            {
                dgvTK.DataSource = tk_buss.Load_tt_sachchuatra_dg(chuanhoa(txtMadg.Text));
            }
            else if (rbtnTrehen.Checked == true)
            {
                dgvTK.DataSource = tk_buss.Load_tt_sach_trehen_dg(chuanhoa(txtMadg.Text));
            }
        }
        
    }
}
