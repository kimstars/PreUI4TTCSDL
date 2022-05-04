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
    public partial class Xu_ly_tra : UserControl
    {
        Trasach_Bus ts_bus = new Trasach_Bus();
        public Xu_ly_tra()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if(cmbTKiem.SelectedItem == "Mã độc giả")
            {
                dgv_trasach.DataSource = ts_bus.loadtk_dgia(txtTK.Text);
            }
            else if (cmbTKiem.SelectedItem == "Mã sách")
                    {
                dgv_trasach.DataSource = ts_bus.loadtk_masach(txtTK.Text);
            }
        }

        private void Xu_ly_tra_Load(object sender, EventArgs e)
        {
            dgv_trasach.DataSource = ts_bus.Loadls();
            cmbTKiem.SelectedIndex = 0;
        }
    }
}
