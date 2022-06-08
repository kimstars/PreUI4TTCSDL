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
            DateTime date = dateEnd.Value.Subtract(new TimeSpan(30, 0, 0, 0));
            dateStart.Value = date;
            TKNhap();

        }


        private void TKNhap()
        {
            dgv_tkSachnhap.DataSource = tk_bus.Load_sach_nhap(dateStart.Value, dateEnd.Value);

            int sum = 0;
            for (int i = 0; i < dgv_tkSachnhap.RowCount; i++)
            {
                sum += int.Parse(dgv_tkSachnhap.Rows[i].Cells["soluong"].Value.ToString());
            }
            txtTongso.Text = sum.ToString();
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            TKNhap();

        }
    }
}
