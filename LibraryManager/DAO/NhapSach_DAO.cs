using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManager.DAO
{
    class NhapSach_DAO : DataProvider
    {

        public DataTable GetTTNhap()
        {
            string sql = "SELECT pn.MaPhieuNhap, nv.TenNhanVien, pn.NgayNhap, COUNT(tt.MaSach) soluong FROM dbo.PHIEUNHAP AS pn INNER JOIN dbo.THONGTINNHAPSACH tt ON tt.MaPhieuNhap = pn.MaPhieuNhap INNER JOIN dbo.NHANVIEN nv ON nv.MaNhanVien = pn.MaNhanVien GROUP BY pn.MaPhieuNhap, nv.TenNhanVien, pn.NgayNhap";
            return GetData(sql);
        }



        public string GetSoLuongSach(string MaDauSach)
        {
            string sql = $"SELECT soluong FROM dbo.DAUSACH WHERE MaDauSach ='{MaDauSach}'";

            return GetCount(sql).ToString();
        }


        public void InsertPhieuNhap_TTNS(PhieuNhap pn,ThongTinNhapSach ttns)
        {
            string sql = $"INSERT INTO dbo.PHIEUNHAP VALUES ('{pn.MaPhieuNhap}','{pn.MaNhanVien}','{DateToString(pn.NgayNhap)}')";

            Excute(sql);

            sql = $"INSERT INTO dbo.THONGTINNHAPSACH VALUES ('{ttns.MaPhieuNhap}','{ttns.MaSach}')";

            Excute(sql);
        }


        public void CallProc_Gen_Phieunhap(string MaNhanVien, DateTime NgayNhap)
        {
            string NameProc = "Proc_createDB_NhapSach";

            SqlParameter[] sParams = new SqlParameter[2];
            sParams[0] = new SqlParameter("@manv", MaNhanVien);
            sParams[1] = new SqlParameter("@ngaynhap", DateToString(NgayNhap));


            Excute_Proc_NParam(NameProc, sParams);
        }

        public int GetSoLuongPhieuNhap()
        {
            string sql = $"SELECT COUNT(MaPhieuNhap) FROM dbo.PHIEUNHAP ";

            return (int)GetCount(sql) ;
       
        }


        public int GetRemainNhap(string MaDauSach)
        {
            string sql = $"SELECT ISNULL(SoLuong,0) - ISNULL((SELECT SUM(SoLuongSach) soluongnhap FROM dbo.THONGTINNHAPSACH WHERE MaDauSach = '{MaDauSach}'),0) AS SL FROM dbo.DAUSACH WHERE MaDauSach = '{MaDauSach}'";

            return (int)GetCount(sql);
        }


        public int SLSachchuanhap()
        {
            string sql = "SELECT COUNT(MaSach) FROM dbo.CUONSACH WHERE MaSach NOT IN(SELECT MaSach FROM dbo.THONGTINNHAPSACH)";
            return (int)GetCount(sql);
        }
    }
}
