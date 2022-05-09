using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class TKeSachCon_DAO : DataProvider
    {
        
        public string GetSachCon()
        {
            string sqlString = "SELECT COUNT(MASACH) FROM dbo.CUONSACH WHERE TRANGTHAI = 1";
            return ExcuteRetStr(sqlString);
        }
        
    }
}
