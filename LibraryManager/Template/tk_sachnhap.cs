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
    public partial class tk_sachnhap : UserControl
    {
        ThongKe_BUS tk_bus = new ThongKe_BUS();   
        public tk_sachnhap()
        {
            InitializeComponent();
        }

        private void tk_sachnhap_Load(object sender, EventArgs e)
        {
           
        }

        private void btnTK_Click(object sender, EventArgs e)
        {

            dgv_tkSachnhap.DataSource = tk_bus.Load_sach_nhap(dateStart.Value, dateEnd.Value);
            txtTongso.Text = tk_bus.GetTongso(dateStart.Value, dateEnd.Value).ToString();
        }
    }
}
