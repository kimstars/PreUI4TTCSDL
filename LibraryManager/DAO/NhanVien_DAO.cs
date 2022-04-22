using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class NhanVien_DAO : DataProvider
    {
        public DataTable loadNhanVien()
        {
            string sqlString = @"select * from NHANVIEN";
            return GetData(sqlString);
        }

        public bool Insert(NhanVien nv)
        {
            if (GetData("select * from NHANVIEN where MaNhanVien = '" + nv.MaNhanVien + "'").Rows.Count > 0)
                return false;

            string sql = string.Format("Insert Into ACCOUNT values('{0}', '{1}', '{2}', '{3}')", nv.MaNhanVien, nv.TenDangNhap, "", 1);
            Excute(sql);

            sql = string.Format("Insert Into NHANVIEN values('{0}','{1}','{2}','{3}','{4}','{5}')",
                nv.MaNhanVien, nv.TenDangNhap, nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi);
            Excute(sql);


            return true;
        }

        public void Delete(string mnv)
        {
            Excute("delete from NHANVIEN where MaNhanVien = '" + mnv + "'");
        }

        public void Update(NhanVien nv)
        {
            string sql = string.Format("update NHANVIEN set HoTen = N'{0}', GioiTinh = N'{1}', NamSinh = '{2}', DiaChi = N'{3}', TenDangNhap = '{5}' where MaNhanVien = '{4}'",
                nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.MaNhanVien, nv.TenDangNhap);
            Excute(sql);

            sql = string.Format("update ACCOUNT set TenDangNhap = '{0}' where MaNhanVien = '{1}'", nv.TenDangNhap, nv.MaNhanVien);
            Excute(sql);
        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from NHANVIEN where MaNhanVien like N'%{0}%' or HoTen like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
    }
}
