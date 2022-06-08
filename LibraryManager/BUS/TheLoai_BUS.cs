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
    class TheLoai_BUS
    {
        TheLoai_DAO tlDao = new TheLoai_DAO();

        public DataTable LoadTenTheLoai()
        {
            return tlDao.GetTenTheLoai();
        }

        public string GetLastest_MaTL()
        {
            return tlDao.GetLastest_MaTL();
        }

        public string CreateNextMaTL()
        {
            string current = GetLastest_MaTL();

            string inc = System.Text.RegularExpressions.Regex.Match(current, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string Ma = "TL000000";
            Ma = Ma.Substring(0, Ma.Length - index.Length) + index;

            return Ma;
        }
        public DataTable LoadListTL()
        {
            return tlDao.LoadTheLoai();
        }

        public string LayMaTheLoai(string ten)
        {
            return tlDao.GetMaTheLoai(ten);
        }

        public void ThemThongtinNhap(TheLoai tl)
        {
            tlDao.InsertTheLoai(tl);
        }
        public void Update(string MaTheLoai, string TenTheLoai)
        {
            tlDao.UpdateTheLoai(MaTheLoai, TenTheLoai);
        }

        public void Delete(TheLoai tl)
        {
            tlDao.DeleteTheLoai(tl);
        }
    }
}
