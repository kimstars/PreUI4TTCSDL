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

        public List<string> LoadMaDauSach()
        {
            DataTable temp =  dsDao.GetMaDauSach();
            List<string> res = new List<string>();
            for(int i = 0; i < temp.Rows.Count; i++)
            {
                string item = temp.Rows[i]["MaDauSach"].ToString();
                res.Add(item);
            }
            return res;
        }
        public List<string> LoadMaDauSach(string keyword, string TL)
        {
            DataTable temp = dsDao.GetMaDauSach(keyword,TL);

            List<string> res = new List<string>();
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                string item = temp.Rows[0]["MaDauSach"].ToString();
                res.Add(item);
            }
            return res;
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


        #region thongtinsach

        public DataTable LoadThongtinSach_DS(string MaDS)
        {
            return dsDao.GetInfo2(MaDS);
        }


        public string LoadSL_SanCo(string MaDS)
        {
            return dsDao.GetSLCuonSach_Sanco(MaDS).ToString();
        }

        public string LoadTenDS(string MaDS)
        {
            return dsDao.GetTenDauSach(MaDS);
        }

        public string LoadTenTG(string MaDS)
        {
            return dsDao.GetTenTacGia(MaDS);
        }



        #endregion

    }
}
