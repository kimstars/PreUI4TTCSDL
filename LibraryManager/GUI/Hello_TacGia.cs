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


namespace LibraryManager.GUI
{
    public partial class Hello_TacGia : Form
    {
        Home_BUS hellotg = new Home_BUS();
        public Hello_TacGia()
        {
            InitializeComponent();
        }

        private void Hello_TacGia_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string timkiem = txtSearch.Text;
            DataTable tg = hellotg.TimKiemTG(timkiem);
            dgvDs.DataSource = tg;
        }
    }
}
