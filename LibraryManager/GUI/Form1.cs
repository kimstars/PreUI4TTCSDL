using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sidebartick.Start();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.HomeHello());


        }

        public static bool isLogin = false;

        bool sidebarExpand = true;
        private void sidebartick_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                PanelMenuBar.Width -= 100;
                if (PanelMenuBar.Width == PanelMenuBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartick.Stop();
                }

                foreach (var btn in panelButton.Controls.OfType<Guna2Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    btn.Padding = new Padding(0);
                }
            }
            else
            {
                PanelMenuBar.Width += 100;
                if (PanelMenuBar.Width == PanelMenuBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartick.Stop();
                }

                foreach (Guna2Button btn in panelButton.Controls.OfType<Guna2Button>())
                {
                    btn.Text = btn.Tag.ToString();
                    btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    btn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
    
            sidebartick.Start();
        }

        

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.Thongtin());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GUI.CreateDataDB newform = new GUI.CreateDataDB();
            newform.Show();

        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            GUI.TimKiem4Hello newform = new GUI.TimKiem4Hello();
            newform.Show();

        }

        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GUI.frmLogin newform = new GUI.frmLogin();
            newform.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            GUI.FrmDangKy newform = new GUI.FrmDangKy();
            newform.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.HomeHello());
        }
	
    }
}
           

