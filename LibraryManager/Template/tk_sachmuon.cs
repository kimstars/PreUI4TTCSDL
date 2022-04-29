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
    public partial class tk_sachmuon : UserControl
    {
        public tk_sachmuon()
        {
            InitializeComponent();
        }
        ThongKe_BUS tkBus = new ThongKe_BUS();
        private void tk_sachmuon_Load(object sender, EventArgs e)
        {

            charttk.DataSource = tkBus.LoadChartSachMuon();
            charttk.Series["Sách mượn"].XValueMember = "trangthai";
            charttk.Series["Sách mượn"].YValueMembers = "giatri";
            charttk.Titles.Add("Sách mượn");
            charttk.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            dgv_tksachmuon.DataSource = tkBus.load_tt_sachmuon();
        }
    }
}
