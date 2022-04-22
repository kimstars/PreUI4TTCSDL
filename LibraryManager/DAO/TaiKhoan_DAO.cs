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
            if (GetData("select* from TaiKhoan where TenDangNhap = '" + us + "' and MatKhau = '" + pw + "'").Rows.Count > 0)
                return true;
            return false;
        }
        public bool signup(TaiKhoan tk, bool isNV)
        {


            if (GetData("select* from TaiKhoan where TenDangNhap = '" + tk.TenDangNhap + "'").Rows.Count > 0)
                return false;
            string sql;
            if (isNV)
            {
                sql = string.Format("Insert Into DOCGIA(MatKhau, TenDangNhap, LoaiTK) values('{0}', '{1}', 'nhanvien')", tk.MatKhau, tk.TenDangNhap);
            }
            else
            {
                sql = string.Format("Insert Into DOCGIA(MatKhau, TenDangNhap,LoaiTK) values('{0}', '{1}', 'docgia')", tk.MatKhau, tk.TenDangNhap);
            }
            
        
           
            Excute(sql);
            return true;
        }
        public void Update(DocGia dg)
        {
            return;
        }
    }
}
