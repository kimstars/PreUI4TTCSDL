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
    public partial class InfoDG : UserControl
    {
        public InfoDG()
        {
            InitializeComponent();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            DateTime t = pickerBirthday.Value.Date;
            MessageBox.Show(t.ToString());

        }
    }
}
