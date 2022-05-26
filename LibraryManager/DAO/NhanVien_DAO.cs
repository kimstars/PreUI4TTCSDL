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

            string sql = $"INSERT INTO dbo.NHANVIEN VALUES ('{nv.MaNhanVien}',N'{nv.TenNhanVien}',N'{nv.ChucVu}','{DateToString(nv.NgaySinh)}',N'{nv.GioiTinh}',N'{nv.DiaChi}','{nv.Email}','{nv.SDT}','{nv.CMND}','{nv.TenDangNhap}',NULL)";
            Excute(sql);


            return true;
        }

        public void Delete(string mnv)
        {
            Excute("delete from NHANVIEN where MaNhanVien = '" + mnv + "'");
        }

        public void Update(NhanVien nv)
        {
            string sql = string.Format("update NHANVIEN set TenNhanVien = N'{0}', GioiTinh = N'{1}', NgaySinh = '{2}', DiaChi = N'{3}', TenDangNhap = '{4}' where MaNhanVien = '{5}'",
                nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.TenDangNhap, nv.MaNhanVien);
            Excute(sql);

           
        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select *  from nhanvien where MaNhanVien like '{0}' or TenNhanVien like N'%{0}%' or ChucVu like N'%{0}%' or NgaySinh like '%{0}%' or GioiTinh like N'%{0}%' or Email like '%{0}%' or SDT like '%{0}%' or CMND like '%{0}%' or TenDangNhap like '%{0}%' ", _timkiem);
            

            return GetData(sqlString);
        }


        #region get

        public DataTable GetMaNV()
        {
            string sql = "SELECT MaNhanVien FROM dbo.NHANVIEN";
            return GetData(sql);
        }

        public string GetTenNV(string MaNV)
        {
            string sql = $"SELECT TenNhanVien FROM dbo.NHANVIEN WHERE MaNhanVien = '{MaNV}'";
            return GetString(sql);
        }

        public string GetMaNV_PM(string MaMT)
        {
            string sql = $"SELECT MaNhanVien FROM dbo.PHIEUMUONTRA WHERE MaMuonTra = '{MaMT}'";
            return GetString(sql);
        }

        public DataTable GetThongTinNV(string MaNV)
        {
            string sql = $"select TenNhanVien,ChucVu,NgaySinh,GioiTinh,DiaChi,Email,SDT,CMND,TenDangNhap from Nhanvien WHERE MaNhanVien = '{MaNV}'";
            return GetData(sql);
        }

        public string GetLastest_MaNhanVien()
        {
            string sql = "SELECT TOP 1 MaNhanVien FROM dbo.NHANVIEN ORDER BY MaNhanVien DESC";
            return GetString(sql);
        }

        #endregion




    }
}
