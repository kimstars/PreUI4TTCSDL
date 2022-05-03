using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LibraryManager.BUS
{
    class DauSach_BUS : Image_BUS
    {
        DauSach_DAO dsDao = new DauSach_DAO();

        public DataTable LoadMaDauSach()
        {
            return dsDao.GetMaDauSach();
        }

        public DataTable LoadListDS()
        {
            return dsDao.LoadDauSach();
        }
        // Xử lý load ảnh lên UserControl; ->get
        public Image LoadAnh(string maID)
        {
            byte[] img = LoadImageFromTableDB("DauSach", maID, "MaDauSach");
            
            UserControl avt = new UserControl();
            if (img != null)
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
            SaveImage("DauSach", maID, "MaDauSach", imgPath);
        }

        public DataTable TimKiem(string _timkiem)
        {
            return dsDao.Search(_timkiem);
        }


    }
}
