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
            string sqlString = "SELECT COUNT( FROM dbo.DAUSACH WHERE Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
    }
}
