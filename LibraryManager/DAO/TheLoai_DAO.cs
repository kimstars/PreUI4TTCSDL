using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class TheLoai_DAO : DataProvider
    {

        public DataTable GetTenTheLoai()
        {
            string sql = "SELECT * FROM dbo.THELOAI";
            return GetData(sql);
        }

        public DataTable LoadTheLoai()
        {
            string sqlString = @"select * from TheLoai";
            return GetData(sqlString);
        }

        public string GetMaTheLoai(string ten)
        {
            string sql = "SELECT MaTheLoai FROM dbo.THELOAI WHERE TenTheLoai = N'"+ ten +"'";
            return ExcuteRetStr(sql);
        }

        
        public void InsertTheLoai(TheLoai tl)
        {
            string sql = $"EXEC PROC_THEMTHELOAI '{tl.MaTheLoai}','{tl.TenTheLoai}'";

            Excute(sql);
        }
        public void UpdateTheLoai(string MaTheLoai, string TenTheLoai)
        {
            string sql = $"EXEC PROC_SUATHELOAI '{MaTheLoai}','{TenTheLoai}'";

            Excute(sql);
        }
        public void DeleteTheLoai(TheLoai tl)
        {
            string sql = $"EXEC PROC_XOATHELOAI '{tl.MaTheLoai}'";

            Excute(sql);
        }
    }
}
