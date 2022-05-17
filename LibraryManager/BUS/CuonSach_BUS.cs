using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Data;

namespace LibraryManager.BUS
{
    class CuonSach_BUS
    {
        CuonSach_DAO sachDao = new CuonSach_DAO();
        public DataTable LoadMaSach()
        {
            return sachDao.GetMaSach();
        }


        public void ThemThongtinNhap(CuonSach cs, PhieuNhap pn)
        {
            sachDao.InsertCuonSach(cs,pn);
        }

        public bool CheckMaSach(string ma)
        {
            if (sachDao.GetCheckMaSach(ma) != 0) return true;
            else return false;
        }

        public DataTable LoadSach()
        {
            return sachDao.GetAllSach();
        }

        public string Get_Lastest_MaSach()
        {
            return sachDao.Lastest_MaSach();
        }

        public string CreateNext_MaSach()
        {
            string currentCode = Get_Lastest_MaSach();

            string inc = System.Text.RegularExpressions.Regex.Match(currentCode, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string maMuon = "S000000";
            maMuon = maMuon.Substring(0, maMuon.Length - index.Length) + index;

            return maMuon;
        }


        public void InsertOneCuonSach(string MaSach, string MaDauSach, String ViTri, string TinhTrang)
        {
            sachDao.InsertCuonSach(MaSach, MaDauSach, ViTri, TinhTrang);
        }






    }
}
