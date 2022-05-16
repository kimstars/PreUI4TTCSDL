using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;

namespace LibraryManager.DAO
{
    class NhapSach_DAO : DataProvider
    {

        public DataTable GetTTNhap()
        {
            string sql = "SELECT pn.MaPhieuNhap, tt.MaDauSach, nv.MaNhanVien, tt.SoLuongSach, pn.NgayNhap FROM dbo.PHIEUNHAP AS pn INNER JOIN dbo.THONGTINNHAPSACH tt ON tt.MaPhieuNhap = pn.MaPhieuNhap INNER JOIN dbo.NHANVIEN nv ON nv.MaNhanVien = pn.MaNhanVien ";
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

            sql = $"INSERT INTO dbo.THONGTINNHAPSACH VALUES ('{ttns.MaPhieuNhap}','{ttns.MaDauSach}', {ttns.SoLuongSach})";

            Excute(sql);
        }

        public int GetSoLuongPhieuNhap()
        {
            string sql = $"SELECT COUNT(MaPhieuNhap) FROM dbo.PHIEUNHAP ";

            return Int32.Parse(ExcuteRetStr(sql)) ;
       
        }

    }
}
