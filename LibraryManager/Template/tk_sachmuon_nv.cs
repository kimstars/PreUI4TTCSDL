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
    public partial class tk_sachmuon_nv : UserControl
    {
        public tk_sachmuon_nv()
        {
            InitializeComponent();
        }
        ThongKe_BUS tkBus = new ThongKe_BUS();
        private void tk_sachmuon_Load(object sender, EventArgs e)
        {

            charttk.DataSource = tkBus.LoadChartSachMuon();
            charttk.Series["Chart1"].XValueMember = "trangthai";
            charttk.Series["Chart1"].YValueMembers = "giatri";
            charttk.Series["Chart1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;


            charttk.Titles.Add("Sách mượn");
            dgv_tksachmuon.DataSource = tkBus.load_tt_sachmuon_nv();



            dateStart.Value = dateEnd.Value.Subtract(new TimeSpan(180, 0, 0, 0));
        }

        private void rbtnMadocgia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filter2.DataSource = tkBus.get_madg_cmb();
                //cmbMadg.DisplayMember = "Madocgia";
                filter2.ValueMember = "Madocgia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            //nếu filter1 và filter2 trống thì lọc theo mã độc giả
            // các trường hợp còn lại xử lý tiếp
        }

        private void filter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Độc giả
            //Đầu sách
            //Thể loại
            //Nhà xuất bản

            string change = filter1.Text;
            switch (change)
            {
                case "Độc giả":
                    {
                        txtSearch.PlaceholderText = "Nhập mã hoặc tên độc giả";
                        break;
                    }
                case "Đầu sách":
                    {
                        txtSearch.PlaceholderText = "Nhập mã hoặc tên Đầu sách";

                        break;
                    }
                case "Thể loại":
                    {
                        txtSearch.PlaceholderText = "Nhập mã hoặc tên Thể loại";
                        break;
                    }
                case "Nhà xuất bản":
                    {
                        txtSearch.PlaceholderText = "Nhập mã hoặc tên Nhà xuất bản";
                        break;
                    }
            }
        }
    }
}
