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
using LibraryManager.GUI;
namespace LibraryManager.Template
{
    public partial class Xu_ly_tra : UserControl
    {
        Trasach_Bus ts_bus = new Trasach_Bus();
        public Xu_ly_tra()
        {
            InitializeComponent();
        }
        public string chuanhoa(string a)
        {
            return a.ToUpper();
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            if(cmbTKiem.SelectedItem == "Mã độc giả")
            {
                dgv_trasach.DataSource = ts_bus.loadtk_dgia(chuanhoa(txtTK.Text));
            }
            else if (cmbTKiem.SelectedItem == "Mã sách")
                    {
                dgv_trasach.DataSource = ts_bus.loadtk_masach(chuanhoa(txtTK.Text));
            }
        }

        private void Xu_ly_tra_Load(object sender, EventArgs e)
        {
            dgv_trasach.DataSource = ts_bus.Loadls();
            cmbTKiem.SelectedIndex = 0;
        }

        private void dgv_trasach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_trasach.CurrentRow.Index;
            txtMasach.Text = dgv_trasach.Rows[i].Cells[7].Value.ToString();
            txtMadg.Text = dgv_trasach.Rows[i].Cells[2].Value.ToString();
       
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            /*if(cboxTra.Checked == true && cboxVi_pham.Checked == false)
            {
                ts_bus.update(txtMasach.Text);
                ts_bus.Loadls();
            }
            if(cboxTra.Checked == true && cboxVi_pham.Checked == true)
            {
                frmVipham vipham = new frmVipham();
                vipham.Show();
            }*/

            if (cboxVi_pham.Checked == true)
            {
                dgvDs.Rows.Add(txtMasach.Text, txtMadg.Text, DateTime.Now, "Có");
            }
            else
            {
                dgvDs.Rows.Add(txtMasach.Text, txtMadg.Text, DateTime.Now, "Không");
            }
       
        }

        private void btnBbvp_Click(object sender, EventArgs e)
        {
            frmPhieuphat pp = new frmPhieuphat();
            pp.Show();
        }
    }
}
