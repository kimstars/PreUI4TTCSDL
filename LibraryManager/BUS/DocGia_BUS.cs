﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LibraryManager.BUS
{
    class DocGia_BUS : Image_BUS
    {
        DocGia_DAO dgDao = new DocGia_DAO();
        public DataTable GetList()
        {
            return dgDao.loadDocGia();
        }
        public void Xoa(string mDG)
        {
            dgDao.Delete(mDG);
        }
        public bool Sua(DocGia dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return false;
            dgDao.Update(dg);
            return true;
        }
        public int Them(DocGia dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return 0;
            if (!dgDao.Insert(dg))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return dgDao.Search(_timkiem);
        }

        // Xử lý load ảnh lên pictureBox; ->get
        public Image LoadAnh(string maID)
        {
            byte[] img = LoadImageFromTableDB("DocGia", maID, "MaDocGia");
            PictureBox avt = new PictureBox();
            if (img !=  null)
            {
                return Image.FromStream(new MemoryStream(img));
            }
            else
            {
                return Properties.Resources.icons8_search_client_80px;
            }
            
        }
        
        // -> set
        public void LuuAnh(string maID, string imgPath)
        {
            SaveImage("DocGia", maID, "MaDocGia", imgPath);
        }

        public DocGia GetOne(string maDG)
        {
            return dgDao.GetMotDG(maDG);
        }


        public DataTable LoadMaDocGia()
        {
            return dgDao.GetMaDG();
        }
    }
}
