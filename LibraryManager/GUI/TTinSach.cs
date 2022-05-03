using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace LibraryManager.GUI
{
    public partial class TTinSach : Form
    {
        public TTinSach()
        {
            InitializeComponent();
        }

        private void usercontrol_click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(AnhSach);
            AnhSach.Image = ((UserControl)sender).BackgroundImage;
            guna2Transition1.ShowSync(AnhSach);
        }

        private void btMuon_Click(object sender, EventArgs e)
        {

        }
    }
}
