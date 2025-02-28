﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.GUI
{
    public partial class CreateDataDB : Form
    {
        public CreateDataDB()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CreateDB.ThemMuonTra newThemMT = new CreateDB.ThemMuonTra();
            newThemMT.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CreateDB.NhapSach newNhap = new CreateDB.NhapSach();
            newNhap.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CreateDB.addImageDauSach newNhap = new CreateDB.addImageDauSach();
            newNhap.Show();
        }

        private void btnListByte_Click(object sender, EventArgs e)
        {
            GUI.testListByte newform = new GUI.testListByte();
            newform.Show();
        }

        private void btnloginNV_Click(object sender, EventArgs e)
        {
            frmNhanvien newform = new frmNhanvien("vuhatrang");
            newform.Show();
        }

        private void btnLoginDG_Click(object sender, EventArgs e)
        {
            FrmDocGia newform = new FrmDocGia("huuhiep2");
            newform.Show();
        }

        private void btnloginQL_Click(object sender, EventArgs e)
        {
            Template.FormAdmin newform = new Template.FormAdmin();
            newform.Show();
        }

        private void btnCuonSach_Click(object sender, EventArgs e)
        {
            CreateDB.create1000Book newform = new CreateDB.create1000Book();
            newform.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report.TKLuotMuonCreator tkcreator = new Report.TKLuotMuonCreator("NV000003");
            tkcreator.ShowReportHoaDon();
        }

        private void btnRPPhieumuon_Click(object sender, EventArgs e)
        {

            Report.PhieuMuonCreator tkcreator = new Report.PhieuMuonCreator("MT000009","NV000005");

            tkcreator.ShowReportHoaDon();
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            Template.testLogin newform = new Template.testLogin();
            newform.Show();
        }

        private void btnRP_BBVP_Click(object sender, EventArgs e)
        {
            Report.BBViphamCreator tkcreator = new Report.BBViphamCreator("VP000004");

            tkcreator.ShowReportHoaDon();
        }
    }
}
