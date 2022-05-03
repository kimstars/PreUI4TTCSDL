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

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from DAUSACH where MaDauSach like N'%{0}%' or TenDauSach like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }

        
    }
}
