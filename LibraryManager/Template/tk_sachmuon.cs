using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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

            chartTK.DataSource = tkBus.LoadChartSachMuon();
            chartTK.Series["Sách mượn"].XValueMember = "trangthai";
            chartTK.Series["Sách mượn"].YValueMembers = "giatri";
            chartTK.Titles.Add("Sách mượn");
            chartTK.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
    }
}
