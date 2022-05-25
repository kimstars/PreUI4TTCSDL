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
            if (filter1.Text == "")
            {
                if (filter2.Text == "")
                {
                    if (txtSearch.Text == "")
                    {
                        // thống kê tất cả
                        dgv_tksachmuon.DataSource = tkBus.TK_all_nv(dateStart.ToString(), dateEnd.ToString());
                    }
                    else
                    {
                        //thống kê theo tên độc giả hoặc mã độc giả theo hai ngày bắt đầu và kết thúc
                        dgv_tksachmuon.DataSource = tkBus.TK_dg_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    }
                }
                else if (filter2.Text == "Trễ hạn")
                {
                    if (txtSearch.Text == "")
                    {
                        dgv_tksachmuon.DataSource = tkBus.TK_trehan(dateStart.ToString(), dateEnd.ToString());
                    }
                    else dgv_tksachmuon.DataSource = tkBus.TK_trehan_dg_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả
                }
                else if (filter2.Text == "Vi phạm")
                {
                    if (txtSearch.Text == "")
                    {
                        dgv_tksachmuon.DataSource = tkBus.TK_vipham_nv(dateStart.ToString(), dateEnd.ToString());
                    }
                    else dgv_tksachmuon.DataSource = tkBus.TK_vipham_dg_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các sách vi phạm trong khoảng thời gian 
                }
            }
            else if (filter1.Text == "Độc giả")
            {
                if (filter2.Text == "")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_dg_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    //thống kê các sách đã mượn theo tên độc giả hoặc mã độc giả
                }
                else if (filter2.Text == "Trễ hạn")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_trehan_dg_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả theo tên độc giả hoặc mã độc giả
                }
                else if (filter2.Text == "Vi phạm")
                {
                    // thống kê tất cả các sách vi phạm trong khoảng thời gian của độc giả a
                    dgv_tksachmuon.DataSource = tkBus.TK_vipham_dg_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                }
            }
            else if (filter1.Text == "Đầu sách")
            {
                if (filter2.Text == "")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_ds_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    //thống kê các sách đã mượn theo tên đầu sách hoặc mã đầu sách
                }
                else if (filter2.Text == "Trễ hạn")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_trehan_ds_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả theo tên đầu sách hoặc mã đầu sách
                }
                else if (filter2.Text == "Vi phạm")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_vipham_ds_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các sách vi phạm trong khoảng thời gian theo tên đầu sách hoặc mã đầu sách
                }
            }
            else if (filter1.Text == "Thể loại")
            {
                if (filter2.Text == "")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_theloai_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    //thống kê các sách đã mượn theo tên thể loại hoặc mã thể loại
                }
                else if (filter2.Text == "Trễ hạn")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_theloai_trehan_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả theo tên thể loại hoặc mã thể loại
                }
                else if (filter2.Text == "Vi phạm")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_vipham_tl_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các sách vi phạm trong khoảng thời giantheo tên thể loại hoặc mã thể loại
                }
            }
            else if (filter1.Text == "Nhà xuất bản")
            {
                if (filter2.Text == "")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_nxb_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    //thống kê các sách đã mượn theo tên nhà xuất bản hoặc mã xuất bản
                }
                else if (filter2.Text == "Trễ hạn")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_trehan_nxb_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả theo nhà xuất bản hoặc mã xuất bản
                }
                else if (filter2.Text == "Vi phạm")
                {
                    dgv_tksachmuon.DataSource = tkBus.TK_vipham_nxb_nv(dateStart.ToString(), dateEnd.ToString(), txtSearch.Text.Trim(), txtSearch.Text.Trim());
                    // thống kê tất cả các sách vi phạm trong khoảng thời giantheo nhà xuất bản hoặc mã xuất bản
                }
            }
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
