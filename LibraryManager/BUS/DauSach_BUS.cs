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

        public bool CheckMaDauSach(string ma)
        {
            if (dsDao.GetCheckMaDauSach(ma) != 0) return true;
            else return false;
        }

        public void ThemThongtinNhap(DauSach ds,SangTac st, XuatBan xb)
        {
            dsDao.InsertDauSach(ds,st,xb);
        }

        public void Update(DauSach ds, SangTac st, XuatBan xb)
        {
            dsDao.UpdateDauSach(ds, st, xb);
        }

        public void Delete(DauSach ds, SangTac st, XuatBan xb)
        {
            dsDao.DeleteDauSach(ds, st, xb);
        }



        public DataTable SearchDS(string TuKhoa, string MucTimKiem)
        {
            return dsDao.Search(TuKhoa,MucTimKiem);
        }
        public DataTable LoadListDS()
        {
            return dsDao.LoadDauSach();
        }
        public DataTable LoadListDSMini()
        {
            return dsDao.LoadDauSachMini();
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

        public byte[] ImageToByte(string imgPath)
        {
            byte[] img ;
            FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
            string filename = Path.GetFileName(imgPath);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            return img;
        }



    }
}
