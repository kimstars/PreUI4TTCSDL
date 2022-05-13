using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class Home_DAO : DataProvider
    {
        public Int64 GetTongSach()
        {
            string sqlString = "SELECT COUNT(MASACH) FROM dbo.CUONSACH";
            return GetCount(sqlString);
        }
        public Int64 GetTongDG()
        {
            string sqlString = "SELECT COUNT(MADOCGIA) FROM dbo.DOCGIA";
            return GetCount(sqlString);
        }
        public Int64 GetTongDS()
        {
            string sqlString = "SELECT COUNT(MADAUSACH) FROM dbo.DAUSACH";
            return GetCount(sqlString);
        }
        public Int64 GetTongTL()
        {
            string sqlString = "SELECT COUNT(MATHELOAI) FROM dbo.THELOAI";
            return GetCount(sqlString);
        }

        public DataTable Get2Anh()
        {
            string sql = "select top 2 madausach, count(tt.masach) sl from thongtinmuontra tt, cuonsach cs where cs.masach = tt.masach group by madausach order by sl desc";
            return GetData(sql);
        }

        public DataTable LoadPhieuMuon()
        {
            string sql = "SELECT TOP 5 NGAYMUON N'Ngày mượn/trả', MAMUONTRA N'Mã mượn trả', MADOCGIA N'Mã độc giả', MANHANVIEN N'Mã nhân viên' FROM dbo.PHIEUMUONTRA WHERE DaXuLy = 1 ORDER BY NGAYMUON DESC";
            return GetData(sql);
        }

        public DataTable LoadPhieuTra()
        {
            string sql = "SELECT TOP 5 NGAYTRA N'Ngày mượn/trả', TT.MAMUONTRA N'Mã mượn trả', MADOCGIA N'Mã độc giả', MANHANVIEN N'Mã nhân viên' FROM dbo.THONGTINMUONTRA TT, dbo.PHIEUMUONTRA PMT WHERE TT.MaMuonTra = PMT.MaMuonTra ORDER BY TT.NgayTra DESC";
            return GetData(sql);
        }
        public DataTable LoadSachMoi()
        {
            string sql = "SELECT DISTINCT TOP 5 TENDAUSACH N'Tên Đầu Sách', NGAYNHAP N'Ngày Nhập' FROM dbo.DAUSACH, dbo.PHIEUNHAP WHERE MaDauSach IN(SELECT MaDauSach FROM dbo.THONGTINNHAPSACH WHERE MaPhieuNhap IN (SELECT MaPhieuNhap FROM dbo.PHIEUNHAP)) ORDER BY NGAYNHAP DESC";
            return GetData(sql);
        }

        public Int64 GetSachCo()
        {
            string sqlString = "select count(masach) from cuonsach where trangthai = 1";
            return GetCount(sqlString);
        }
        public Int64 GetSachMuon()
        {
            string sqlString = "select count(masach) from cuonsach where trangthai = 0";
            return GetCount(sqlString);
        }
        public DataTable LoadSLDG()
        {
            string sql = "SELECT DISTINCT TOP 5 YEAR(NGAYMUON) NAM, COUNT(MADOCGIA) SL FROM PHIEUMUONTRA GROUP BY YEAR(NgayMuon) ORDER BY YEAR(NgayMuon) DESC";
            return GetData(sql);
        }

        public DataTable SearchTL(string _timkiem)
        {
            string sqlString = string.Format("SELECT TENTHELOAI, COUNT(MASACH) FROM dbo.CUONSACH CS, dbo.THELOAI TL, dbo.DAUSACH DS WHERE CS.MaDauSach = DS.MaDauSach AND DS.MaTheLoai = TL.MaTheLoai AND TL.TenTheLoai LIKE N'%{0}%' GROUP BY TL.TenTheLoai", _timkiem);
            return GetData(sqlString);
        }
        public DataTable SearchTG(string _timkiem)
        {
            string sqlString = string.Format("SELECT TENTHELOAI, COUNT(MASACH) FROM dbo.CUONSACH CS, dbo.THELOAI TL, dbo.DAUSACH DS WHERE CS.MaDauSach = DS.MaDauSach AND DS.MaTheLoai = TL.MaTheLoai AND TL.TenTheLoai LIKE N'%{0}%' GROUP BY TL.TenTheLoai", _timkiem);
            return GetData(sqlString);
        }
    }
}
