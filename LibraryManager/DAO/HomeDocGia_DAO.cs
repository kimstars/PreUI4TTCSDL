using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class HomeDocGia_DAO : DataProvider
    {
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from DAUSACH where MaDauSach like N'%{0}%' or TenDauSach like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
        public DataTable GetMaDocGia()
        {
            string sql = "SELECT MaDocGia FROM dbo.DOCGIA";
            return GetData(sql);
        }
        public string GetSachDaMuon(string madg)
        {
            string sqlString = "SELECT COUNT(MaSach) FROM THONGTINMUONTRA WHERE MAMUONTRA IN(SELECT MAMUONTRA FROM PHIEUMUONTRA WHERE MADOCGIA = '"+ madg + "')";
            return ExcuteRetStr(sqlString);
        }
        public string GetSachDangMuon(string madg)
        {
            string sqlString = "SELECT COUNT(MASACH) FROM CUONSACH WHERE TRANGTHAI = 0 AND MASACH IN (SELECT MASACH FROM THONGTINMUONTRA WHERE MAMUONTRA IN (SELECT MAMUONTRA FROM PHIEUMUONTRA WHERE MADOCGIA = '" + madg + "'))";
            return ExcuteRetStr(sqlString);
        }
        public string GetSachMoi()
        {
            string sqlString = "SELECT COUNT(MaSach) FROM THONGTINMUONTRA WHERE MAMUONTRA IN(SELECT MAMUONTRA FROM PHIEUMUONTRA WHERE MADOCGIA = )";
            return ExcuteRetStr(sqlString);
        }
        public DataTable LoadDocGia()
        {
            string sqlString = @"select * from DocGia";
            return GetData(sqlString);
        }

    }
}
