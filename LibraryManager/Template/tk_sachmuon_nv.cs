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
            mtxtTu_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            mtxtDen_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            charttk.DataSource = tkBus.LoadChartSachMuon();
            charttk.Series["Chart1"].XValueMember = "trangthai";
            charttk.Series["Chart1"].YValueMembers = "giatri";
            charttk.Series["Chart1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;


            charttk.Titles.Add("Sách mượn");
            dgv_tksachmuon.DataSource = tkBus.load_tt_sachmuon_nv();
        }

        private void rbtnMadocgia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cmbMadg.DataSource = tkBus.get_madg_cmb();
                //cmbMadg.DisplayMember = "Madocgia";
                cmbMadg.ValueMember = "Madocgia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (rbtnMadocgia.Checked == true)
            {
                string a = cmbMadg.Text;
                dgv_tksachmuon.DataSource = tkBus.Tk_docgia(a, mtxtTu_ngay.Text, mtxtDen_ngay.Text);
            }
            else if(rbtnTrehan.Checked == true)
            {
                dgv_tksachmuon.DataSource = tkBus.get_trehan(cmbMadg.Text);
            }else if( rbtnMadocgia.Checked == false && rbtnTrehan.Checked == false)
            {
                dgv_tksachmuon.DataSource = tkBus.TK_theongay(mtxtTu_ngay.Text, mtxtDen_ngay.Text);
            }
        }
    }
}
