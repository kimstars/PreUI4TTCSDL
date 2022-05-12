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

        
        private void hideChildForm()
        {
         
            frmThongtin.Visible = false;
        }
        private void closeYCollapse()
        {
            if (LoginCollapse) LoginTick.Start();

        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                LoginTick.Start();
            }

            

        }

        private void btnLoginDG_Click(object sender, EventArgs e)
        {
            hideChildForm();

            FrmDocGia newform = new FrmDocGia();
            newform.Show();

            //panelShow.Controls.Clear();
            //UserControl temp = new Template.InfoNV("NV000000");
            //panelShow.Controls.Add(temp);





        }

        private void btnloginNV_Click(object sender, EventArgs e)
        {
            hideChildForm();


        }

        private void btnLoginQL_Click(object sender, EventArgs e)
        {
            Template.FormAdmin newform = new Template.FormAdmin();
            newform.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (PanelMenuBar.Visible == false)
            //{
            //    PanelMenuBar.Visible = true;

            //}
            //else
            //{
            //    PanelMenuBar.Visible = false;
            //}
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            PanelMenuBar.Width = PanelMenuBar.MinimumSize.Width;
            PanelFind.Height = PanelFind.MinimumSize.Height;

            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.HomeHello());

        }

        bool sidebarExpand;
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

                foreach (var btn in PanelMenuBar.Controls.OfType<Guna2Button>())
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

                foreach (Guna2Button btn in panel4.Controls.OfType<Guna2Button>())
                {
                    btn.Text = btn.Tag.ToString();
                    btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    btn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            closeYCollapse();
            sidebartick.Start();

        }

        bool LoginCollapse;

        private void LoginTick_Tick(object sender, EventArgs e)
        {

            if (LoginCollapse)
            {
                PanelFind.Height -= 100;
                if (PanelFind.Height == PanelFind.MinimumSize.Height)
                {
                    LoginCollapse = false;
                    LoginTick.Stop();
                }
            }
            else
            {
                PanelFind.Height += 100;
                if (PanelFind.Height == PanelFind.MaximumSize.Height)
                {
                    LoginCollapse = true;
                    LoginTick.Stop();
                }
            }
        }



        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            hideChildForm();
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            hideChildForm();
            frmThongtin.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            hideChildForm();

            GUI.CreateDataDB newform = new GUI.CreateDataDB();
            newform.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            hideChildForm();
            CreateDB.NhapSach newNhap = new CreateDB.NhapSach();
            newNhap.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            hideChildForm();
            CreateDB.addImageDauSach newNhap = new CreateDB.addImageDauSach();
            newNhap.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            hideChildForm();
            panelShow.Controls.Add(new Template.PhieuMuon());
            
        }

        private void btnListByte_Click(object sender, EventArgs e)
        {
            hideChildForm();
            GUI.testListByte newform = new GUI.testListByte();
            newform.Show();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            hideChildForm();
            //FrmDocGia newform = new FrmDocGia();
            //newform.Show();

            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Template.InfoDG());


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            hideChildForm();
            //panelShow.Controls.Clear();
            //panelShow.Controls.Add(new Template.TimKiemForHello());
            GUI.TimKiem4Hello newform = new GUI.TimKiem4Hello();
            newform.Show();

        }

        private void btnLoginn_Click(object sender, EventArgs e)
        {
            GUI.frmLogin newform = new GUI.frmLogin();
            newform.Show();
        }
    }
}
