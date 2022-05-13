using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class CuonSach_DAO : DataProvider
    {

        public DataTable GetMaSach()
        {
            string sql = "SELECT MaSach FROM dbo.CUONSACH";
            return GetData(sql);
        }
       




    }
}
