using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class MatKhau_DAO : DataProvider
    {
        public void ChangePassWord(TaiKhoan _tv)
        {
            string sql = string.Format("update TaiKhoan set MatKhau = '{0}' where TenDangNhap = '{1}'", _tv.MatKhau, _tv.TenDangNhap);
            Excute(sql);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            string sql = string.Format("select* from TaiKhoan where MatKhau = '{0}' and TenDangNhap = '{1}'", _mkc, _tdn);
            if (GetData(sql).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
