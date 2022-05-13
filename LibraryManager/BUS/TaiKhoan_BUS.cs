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
        public bool DangKy(TaiKhoan _tv)
        {
            return tvDao.signup(_tv, false);
        }

        public bool checkTonTaiTK(string username)
        {
            return tvDao.checkExistTK(username);
        }

        public string LoadLoaiTK(string username)
        {
            return tvDao.LoaiTaiKhoan(username);
        }
      
    }
}
