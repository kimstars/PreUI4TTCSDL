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
    public partial class Hello_TheLoai : Form
    {
        Home_BUS helloTL = new Home_BUS();
        public Hello_TheLoai()
        {
            InitializeComponent();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hello_TheLoai_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string timkiem = txtSearch.Text;
            DataTable tl = helloTL.TimKiemTL(timkiem);
            dgvDs.DataSource = tl;
        }
    }
}
