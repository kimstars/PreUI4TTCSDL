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
