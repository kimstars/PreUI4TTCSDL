using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using LibraryManager.DTO;

namespace LibraryManager.BUS
{
    class TaiKhoan_BUS
    {
        TaiKhoan_DAO tvDao = new TaiKhoan_DAO();
        public bool DangNhap(string _tk, string _mk)
        {
            if (tvDao.login(_tk, _mk) == true)
                return true;
            return false;
        }
        public int DangKy(TaiKhoan _tv)
        {
            if (string.IsNullOrEmpty(_tv.TenDangNhap) || string.IsNullOrEmpty(_tv.MatKhau))
                return -1;
            if (tvDao.signup(_tv,false) == true)
                return 1;
            return 0;
        }
      
    }
}
