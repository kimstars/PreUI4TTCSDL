using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
           
            if (PaneLoginSub.Visible == true)
            {
                PaneLoginSub.Visible = false;
            }
            hideChildForm();

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        private void hideChildForm()
        {
            FrmLogin1.Visible = false;
        }


        
        private void btnquanlysachkho_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnQLsachtra_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnQLsachnhap_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnQLsachmuon_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            showSubMenu(PaneLoginSub);

      
        }

        private void btnLoginDG_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            FrmLogin1.Visible = true;

        }

        private void btnloginNV_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLoginQL_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelMenuBar.Visible == false)
            {
                PanelMenuBar.Visible = true;

            }
            else
            {
                PanelMenuBar.Visible = false;
            }
        }

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
