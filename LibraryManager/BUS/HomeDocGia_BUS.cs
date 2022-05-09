using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LibraryManager.BUS
{
    class HomeDocGia_BUS : Image_BUS
    {
        HomeDocGia_DAO dg = new HomeDocGia_DAO();

        public DataTable LoadMaDocGia()
        {
            return dg.GetMaDocGia();
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
            return dg.Search(_timkiem);
        }
        public string GetSachDangMuon(string madg)
        {
            return dg.GetSachDangMuon(madg);
        }
        public string GetSachDaMuon(string madg)
        {
            return dg.GetSachDaMuon(madg);
        }
    }
}
