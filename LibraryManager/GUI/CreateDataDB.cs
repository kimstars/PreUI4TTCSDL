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

        }

        private void btnLoginDG_Click(object sender, EventArgs e)
        {
            FrmDocGia newform = new FrmDocGia();
            newform.Show();
        }

        private void btnloginQL_Click(object sender, EventArgs e)
        {
            Template.FormAdmin newform = new Template.FormAdmin();
            newform.Show();
        }
    }
}
