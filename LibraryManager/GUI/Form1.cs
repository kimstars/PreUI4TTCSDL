﻿using System;
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
            FrmLogin1.Visible = false;
            frmThongtin.Visible = false;
            frminfoDG.Visible = false;
            formQLInfo.Visible = false;
            phieuMuon1.Visible = false;

        }



        private void btnquanlysachkho_Click(object sender, EventArgs e)
        {

        }

        private void btnQLsachtra_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQLsachnhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQLsachmuon_Click(object sender, EventArgs e)
        {
            
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

            FrmLogin1.Visible = true;

        }

        private void btnloginNV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoginQL_Click(object sender, EventArgs e)
        {
            
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

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelMenuBar.Width = PanelMenuBar.MinimumSize.Width;
            PaneLogin.Height = PaneLogin.MinimumSize.Height;

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
            }
            else
            {
                PanelMenuBar.Width += 100;
                if (PanelMenuBar.Width == PanelMenuBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartick.Stop();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        bool LoginCollapse;

        private void LoginTick_Tick(object sender, EventArgs e)
        {

            if (LoginCollapse)
            {
                PaneLogin.Height -= 100;
                if (PaneLogin.Height == PaneLogin.MinimumSize.Height)
                {
                    LoginCollapse = false;
                    LoginTick.Stop();
                }
            }
            else
            {
                PaneLogin.Height += 100;
                if (PaneLogin.Height == PaneLogin.MaximumSize.Height)
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
            //frminfoDG.Visible = true;
            formQLInfo.Visible = true;

            //Template.FormAdmin newform = new Template.FormAdmin();
            //newform.Show();

            CreateDB.ThemMuonTra newThemMT = new CreateDB.ThemMuonTra();
            newThemMT.Show();



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
            hideChildForm();
            phieuMuon1.Visible = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            hideChildForm();
            //tk_sachmuon1.Visible = true;
            // tk_sachnhap1.Visible = true;
        }
    }
}
