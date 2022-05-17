using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class TacGia_DAO : DataProvider
    {

        

        public DataTable GetTenTacGia()
        {
            string sql = "SELECT * FROM dbo.TACGIA";
            return GetData(sql);
        }

        public DataTable LoadTacGia()
        {
            string sqlString = @"select * from TacGia";
            return GetData(sqlString);
        }

        public void InsertTacGia(TacGia tg)
        {
            string sql = $"EXEC PROC_THEMTACGIA '{tg.MaTacGia}','{tg.TenTacGia}'";

            Excute(sql);
        }
        public void UpdateTacGia(string MaTacGia, string TenTacGia)
        {
            string sql = $"EXEC PROC_SUATACGIA '{MaTacGia}','{TenTacGia}'";

            Excute(sql);
        }
        public void DeleteTacGia(TacGia tg)
        {
            string sql = $"EXEC PROC_XOATACGIA '{tg.MaTacGia}'";

            Excute(sql);
        }
    }
}
