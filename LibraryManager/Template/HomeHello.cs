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
    public partial class HomeHello : UserControl
    {
        HomeHello_BUS homeHello = new HomeHello_BUS();
        public HomeHello()
        {
            InitializeComponent();
        }

        private void HomeHello_Load(object sender, EventArgs e)
        {
            lbTongSach.Text = homeHello.GetTongSach();
            lbTongDG.Text = homeHello.GetTongDG();
            lbTongDS.Text = homeHello.GetTongDS();
            lbTongTL.Text = homeHello.GetTongTL();
        }
    }
}
