using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Template
{
    public partial class HomeNV : UserControl
    {
        public HomeNV()
        {
            InitializeComponent();
        }

        private void HomeNV_Load(object sender, EventArgs e)
        {
            circlePercent.ValueByTransition = 60;
        }
    }
}
