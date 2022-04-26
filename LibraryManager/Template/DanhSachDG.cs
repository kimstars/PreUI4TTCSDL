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
    public partial class DanhSachDG : UserControl
    {
        public DanhSachDG()
        {
            InitializeComponent();
        }
        DocGia_BUS dgBus = new DocGia_BUS();

        private void DanhSachDG_Load(object sender, EventArgs e)
        {
            dgvDG.DataSource = dgBus.GetList();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            string type = cbFilterDG.Text;
            MessageBox.Show(type);
            if (keyword != "")
            {
                dgvDG.DataSource = dgBus.TimKiem(keyword);
            }
            else
            {
                dgvDG.DataSource = dgBus.GetList();
            }
        }
    }
}
