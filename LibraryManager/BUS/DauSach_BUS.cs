using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
        public DataTable LoadThongTinSach(string MaDauSach)
        {
            return dsDao.GetInfo(MaDauSach);
        }

        // Xử lý load ảnh lên pictureBox; ->get
        public Image LoadAnh(string maID)
        {
            byte[] img = LoadImageFromTableDB("DauSach", maID, "MaDauSach");
            PictureBox avt = new PictureBox();
            if (img != null)
            {
                return Image.FromStream(new MemoryStream(img));
            }
            else
            {
                return Properties.Resources.icons8_circled_user_male_skin_type_6_80px;
            }

        }

        // -> set
        public void LuuAnh(string maID, string imgPath)
        {
            SaveImage("DauSach", maID, "MaDauSach", imgPath);
        }

    }
}
