using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;


namespace LibraryManager.DAO
{
    class DauSach_DAO : DataProvider
    {
        public DataTable GetMaDauSach()
        {
            string sql = "SELECT MaDauSach FROM dbo.DAUSACH";
            return GetData(sql);
        }

        public DataTable GetMaDauSach_SanCo()
        {
            string sql = "SELECT MaDauSach FROM dbo.DAUSACH WHERE MaDauSach IN (SELECT MaDauSach FROM dbo.CUONSACH WHERE TrangThai = 1)";
            return GetData(sql);
        }

        public DataTable GetMaDauSach(string keyword, string TheLoai)
        {
            string sql = $"SELECT ds.MaDauSach, ds.TenDauSach , tl.TenTheLoai FROM dbo.DAUSACH ds INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE MaDauSach = '{keyword}' OR TenDauSach LIKE N'%{keyword}%' and tl.TenTheLoai LIKE '%{TheLoai}%'";
            return GetData(sql);
        }




        public DataTable LoadDauSach()
        {
            string sqlString = @"select * from DauSach";
            return GetData(sqlString);
        }

        public DataTable GetInfo(string MaDauSach)
        {
            string sql = $"SELECT cs.MaSach, ds.TenDauSach, tg.TenTacGia, ds.NamXuatBan, ds.MoTa FROM dbo.CUONSACH AS cs  INNER JOIN dbo.DAUSACH AS ds ON ds.MaDauSach = cs.MaDauSach INNER JOIN dbo.SANGTAC AS st ON st.MaDauSach = ds.MaDauSach INNER JOIN dbo.TACGIA AS tg ON tg.MaTacGia = st.MaTacGia WHERE cs.MaDauSach = '{MaDauSach}' GROUP BY cs.MaSach, ds.TenDauSach, tg.TenTacGia, ds.NamXuatBan, ds.MoTa";
            return GetData(sql);
        }

        #region ThongTinSach
            
        public DataTable GetInfo2(string MaDauSach)
        {
            string sql = $"SELECT ds.TenDauSach, tg.TenTacGia, ds.NamXuatBan,ds.GiaTien, tl.TenTheLoai, ds.MoTa  FROM dbo.DAUSACH ds INNER JOIN dbo.SANGTAC st ON st.MaDauSach = ds.MaDauSach INNER JOIN  dbo.TACGIA tg ON tg.MaTacGia = st.MaTacGia INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE ds.MaDauSach = '{MaDauSach}' GROUP BY ds.TenDauSach, tg.TenTacGia, ds.NamXuatBan, ds.GiaTien, tl.TenTheLoai, ds.MoTa";
            return GetData(sql);


        }


        public int GetSLCuonSach_Sanco(string MaDauSach)
        {
            string sql = $"SELECT COUNT(MaSach) soluong FROM dbo.CUONSACH WHERE MaDauSach = '{MaDauSach}' AND TrangThai = 1";

            return (int)GetCount(sql);
        }

        public string GetTenDauSach(string MaDauSach)
        {
            string sql = $"SELECT TenDauSach FROM dbo.DAUSACH WHERE MaDauSach = '{MaDauSach}'";

            return GetString(sql);
        }

        public string GetTenTacGia(string MaDauSach)
        {
            string sql = $"SELECT TenTacGia FROM dbo.TACGIA tg INNER JOIN dbo.SANGTAC st ON st.MaTacGia = tg.MaTacGia INNER JOIN dbo.DAUSACH ds ON ds.MaDauSach = st.MaDauSach WHERE ds.MaDauSach = '{MaDauSach}' GROUP BY tg.TenTacGia ";

            return GetString(sql);
        }

        // lấy ra vị trí một cuốn sách có sẵn của đầu sách
        public string ViTriAvailable(string MaDauSach)
        {
            string sql = $"SELECT TOP 1 ViTriSach FROM dbo.CUONSACH WHERE MaDauSach = 'DS000001' AND TrangThai = 1";
            return GetString(sql);
        }

        public string GetTheLoai(string MaDauSach)
        {
            string sql = $"SELECT tl.TenTheLoai FROM dbo.DAUSACH ds INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE ds.MaDauSach = '{MaDauSach}'";
            return GetString(sql);
        }

        #endregion


        #region TimKiem
        public DataTable LoadTheLoai()
        {
            string sql = $"SELECT MaTheLoai,TenTheLoai FROM dbo.THELOAI";
            return GetData(sql);
        }


        public DataTable SearchMaDS_TG_TL(string TenTheLoai, string TenTacGia)
        {
            string sql = $"SELECT ds.MaDauSach FROM dbo.DAUSACH ds INNER JOIN dbo.SANGTAC st ON st.MaDauSach = ds.MaDauSach INNER JOIN dbo.TACGIA tg ON tg.MaTacGia = st.MaTacGia  INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE tl.TenTheLoai LIKE N'{TenTheLoai}' and tg.TenTacGia like N'%{TenTacGia}%' GROUP BY ds.MaDauSach ";

            return GetData(sql);
        }

        public DataTable SearchMaDS_onlyTG(string TenTacGia)
        {
            string sql = $"SELECT ds.MaDauSach FROM dbo.DAUSACH ds INNER JOIN dbo.SANGTAC st ON st.MaDauSach = ds.MaDauSach INNER JOIN dbo.TACGIA tg ON tg.MaTacGia = st.MaTacGia INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE tg.TenTacGia like N'%{TenTacGia}%' GROUP BY ds.MaDauSach";
            return GetData(sql);
        }


        public DataTable SearchMaDS_onlyTenSach(string TenSach)
        {
            string sql = $"SELECT ds.MaDauSach FROM dbo.DAUSACH ds  INNER JOIN dbo.SANGTAC st ON st.MaDauSach = ds.MaDauSach INNER JOIN dbo.TACGIA tg ON tg.MaTacGia = st.MaTacGia INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE ds.TenDauSach like N'%{TenSach}%' GROUP BY ds.MaDauSach";
            return GetData(sql);
        }

        public DataTable SearchMaDS_TS_TL(string TenTheLoai,string TenSach)
        {
            string sql = $"SELECT ds.MaDauSach FROM dbo.DAUSACH ds INNER JOIN dbo.SANGTAC st ON st.MaDauSach = ds.MaDauSach INNER JOIN dbo.TACGIA tg ON tg.MaTacGia = st.MaTacGia INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE tl.TenTheLoai LIKE N'{TenTheLoai}' AND ds.TenDauSach LIKE N'%{TenSach}%'GROUP BY ds.MaDauSach";
            return GetData(sql);
        }

        public DataTable SearchMaDS_onlyTheLoai(string TenTheLoai)
        {
            string sql = $"SELECT ds.MaDauSach FROM dbo.DAUSACH ds INNER JOIN dbo.SANGTAC st ON st.MaDauSach = ds.MaDauSach INNER JOIN dbo.TACGIA tg ON tg.MaTacGia = st.MaTacGia INNER JOIN dbo.THELOAI tl ON tl.MaTheLoai = ds.MaTheLoai WHERE tl.TenTheLoai LIKE N'%{TenTheLoai}%' GROUP BY ds.MaDauSach";
            return GetData(sql);
        }


        #endregion
    }
}
