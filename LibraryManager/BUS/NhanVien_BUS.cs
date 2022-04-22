using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;

namespace LibraryManager.BUS
{
    class NhanVien_BUS
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
        public int Them(NhanVien nv)
        {
            if (string.IsNullOrEmpty(nv.MaNhanVien))
                return 0;
            if (!nvDao.Insert(nv))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return nvDao.Search(_timkiem);
        }
    }
}
