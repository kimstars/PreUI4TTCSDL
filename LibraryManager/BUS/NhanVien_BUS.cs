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
    class NhanVien_BUS : Image_BUS
    {
        NhanVien_DAO nvDao = new NhanVien_DAO();

        public DataTable GetList()
        {
            return nvDao.loadNhanVien();
        }

        public void Xoa(string mNV)
        {
            nvDao.Delete(mNV);
        }
        public bool Sua(NhanVien nv)
        {
            if (string.IsNullOrEmpty(nv.MaNhanVien))
                return false;
            nvDao.Update(nv);
            return true;
        }
        public bool Them(NhanVien nv)
        {
            return nvDao.Insert(nv);
        
        }
        public DataTable TimKiem(string _timkiem)
        {

            return nvDao.Search(_timkiem);
        }

        // Xử lý load ảnh lên pictureBox;
        public Image LoadAnh(string maID)
        {
            byte[] img = LoadImageFromTableDB("NhanVien", maID, "MaNhanVien");

            return Image.FromStream(new MemoryStream(img));
             
        }

        #region LoadMaNhanVien
        public DataTable LoadMaNhanVien() {
            return nvDao.GetMaNV();
        }

        public string LoadMaNhanVien_PhieuMuon(string MaMT)
        {
            return nvDao.GetMaNV_PM(MaMT);
        }

        #endregion



        #region load ThongtinNV


      
        public DataTable LoadThongTinNV(string MaNV)
        {
            return nvDao.GetThongTinNV(MaNV);
        }
        public string GetName(string maNV)
        {
            return nvDao.GetTenNV(maNV);
        }

        #endregion
        public void LuuAnh(string maID, string imgPath)
        {
            SaveImage("NhanVien", maID, "MaNhanVien", imgPath);
        }


        #region AutoCreate
        public string GetLastest_MaNhanVien()
        {
            return nvDao.GetLastest_MaNhanVien();
        }

        public string CreateNext_MaMT() // tạo mã phiếu mượn tự động 
        {
            string current = GetLastest_MaNhanVien();

            string inc = System.Text.RegularExpressions.Regex.Match(current, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string maMuon = "NV000000";
            maMuon = maMuon.Substring(0, maMuon.Length - index.Length) + index;

            return maMuon;
        }
        #endregion
    }

}
