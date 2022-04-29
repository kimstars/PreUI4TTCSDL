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
    }
}
