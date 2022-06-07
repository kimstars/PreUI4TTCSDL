    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class TaiKhoan_DAO : DataProvider
    {
        public bool login(string us, string pw)
        {
            if (GetData($"select * from TaiKhoan where TenDangNhap = '{us}' and MatKhau = '{pw}'").Rows.Count > 0)
                return true;
            return false;
        }
        public bool signup(TaiKhoan tk, bool isNV)
        {


            if (GetData($"select * from TaiKhoan where TenDangNhap = '{tk.TenDangNhap}'").Rows.Count > 0)
                return false; // đã tồn tại tên đăng nhập

            string sql;

            if (isNV)
            {
                sql = string.Format("Insert Into TaiKhoan(MatKhau, TenDangNhap, LoaiTK) values('{0}', '{1}', 'nhanvien')", tk.MatKhau, tk.TenDangNhap);
            }
            else
            {
                sql = string.Format("Insert Into TaiKhoan(MatKhau, TenDangNhap,LoaiTK) values('{0}', '{1}', 'docgia')", tk.MatKhau, tk.TenDangNhap);
            }
            
            Excute(sql);
            return true;
        }

        public bool checkExistTK(string username)
        {
            if (GetData($"select * from TaiKhoan where TenDangNhap = '{username}'").Rows.Count > 0)
                return true;

            return false;
        }
        public string LoaiTaiKhoan(string username)
        {
            string sql = $"SELECT LoaiTK FROM dbo.TAIKHOAN WHERE TenDangNhap = '{username}'";
            return GetString(sql);
        }


        public void ktramatkhau(string user, string pass)
        {
            string sql = $"INSERT INTO dbo.TAIKHOAN VALUES ('{user}','{pass}','docgia')";
            validateTest(sql);
        }
    }
}
