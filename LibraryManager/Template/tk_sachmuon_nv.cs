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
            dgv_tksachmuon.DataSource = tkBus.load_tt_sachmuon();
        }

       
    }
}
