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
    public partial class DSInfoDauSach : UserControl
    {
        Home_BUS in4ds = new Home_BUS();
        public DSInfoDauSach()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string timkiem = txtSearch.Text;
            DataTable ds = in4ds.TimKiemDS(timkiem);
            dgvDs.DataSource = ds;
        }
    }
}
