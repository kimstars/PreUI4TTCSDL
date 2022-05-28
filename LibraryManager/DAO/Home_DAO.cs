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

        public DataTable GetTop2_DSNhieuNhat()
        {
            string sql = "SELECT TOP 2 cs.MaDauSach, COUNT(cs.MaSach) sl FROM dbo.DAUSACH ds INNER JOIN dbo.CUONSACH cs ON cs.MaDauSach = ds.MaDauSach INNER JOIN dbo.THONGTINMUONTRA tt ON tt.MaSach = cs.MaSach GROUP BY cs.MaDauSach ORDER BY sl DESC ";

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

        public int GetALLSachMuon()
        {
            string sql = "SELECT COUNT(MaSach) FROM dbo.THONGTINMUONTRA";
            return (int)GetCount(sql);
        }
        public int GetSachChuaTra()
        {
            string sql = "SELECT COUNT(MaSach) FROM dbo.THONGTINMUONTRA WHERE NgayTra IS NULL ";
            return (int)GetCount(sql);
        }
        public DataTable LoadSLDG()
        {
            string sql = "SELECT DISTINCT TOP 5 YEAR(NGAYMUON) NAM, COUNT(MADOCGIA) SL FROM PHIEUMUONTRA GROUP BY YEAR(NgayMuon) ORDER BY YEAR(NgayMuon) DESC";
            return GetData(sql);
        }

        public DataTable SearchTL(string _timkiem)
        {
            string sqlString = string.Format("SELECT TENTHELOAI N'Tên thể loại', COUNT(MASACH) N'Số lượng cuốn sách' FROM dbo.CUONSACH CS, dbo.THELOAI TL, dbo.DAUSACH DS WHERE CS.MaDauSach = DS.MaDauSach AND DS.MaTheLoai = TL.MaTheLoai AND TL.TenTheLoai LIKE N'%{0}%' GROUP BY TL.TenTheLoai", _timkiem);
            return GetData(sqlString);
        }
        public DataTable SearchTG(string _timkiem)
        {
            string sqlString = string.Format("SELECT TENTACGIA N'Tên tác giả', COUNT(DS.MADAUSACH) N'Số lượng đầu sách' FROM dbo.SANGTAC ST, dbo.TACGIA TG, dbo.DAUSACH DS WHERE ST.MaDauSach = DS.MaDauSach AND TG.MaTacGia = ST.MaTacGia AND TG.TenTacGia LIKE N'%{0}%' GROUP BY TG.TenTacGia", _timkiem);
            return GetData(sqlString);
        }
        public DataTable SearchDS(string _timkiem)
        {
            string sqlString = string.Format("SELECT DS.MaDauSach N'Mã đầu sách', DS.TenDauSach N'Tên đầu sách', DS.SoLuong N'Số lượng sách', DS.NamXuatBan, DS.GiaTien, DS.MoTa, TL.TenTheLoai, TG.TenTacGia FROM dbo.DAUSACH DS, dbo.THELOAI TL, dbo.TACGIA TG, dbo.SANGTAC ST WHERE DS.MaTheLoai = TL.MaTheLoai AND TL.TenTheLoai like N'%{0}%' AND DS.MaDauSach = ST.MaDauSach AND ST.MaTacGia = TG.MaTacGia", _timkiem);
            return GetData(sqlString);
        }
        public DataTable LoadTienCoc()
        {
            string sql = "SELECT TOP 5 MONTH(NGAYMUON) Thang, YEAR(NgayMuon) Nam, SUM(CAST(TienCoc AS INT)) Tien FROM dbo.PHIEUMUONTRA GROUP BY MONTH(NGAYMUON), YEAR(NgayMuon) ORDER BY YEAR(NGAYMUON) DESC, MONTH(NgayMuon) DESC";
            return GetData(sql);
        }
        public DataTable LoadSLTL()
        {
            string sql = "SELECT TOP 5 WITH TIES TL.TenTheLoai, COUNT(MaSach) SL FROM dbo.THELOAI TL, dbo.DAUSACH DS, dbo.CUONSACH CS WHERE DS.MaTheLoai = TL.MaTheLoai AND CS.MaDauSach = DS.MaDauSach GROUP BY TL.TenTheLoai ORDER BY SL DESC";
            return GetData(sql);
        }
    }
}
