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
        public bool DangKy(TaiKhoan _tv,bool isNV)
        {
            return tvDao.signup(_tv, isNV);
        }

        public bool checkTonTaiTK(string username)
        {
            return tvDao.checkExistTK(username);
        }

        public string LoadLoaiTK(string username)
        {
            return tvDao.LoaiTaiKhoan(username);
        }

        public void ktramatkhau(string user,string pass)
        {
            tvDao.ktramatkhau(user, pass);
        }


    }
}
