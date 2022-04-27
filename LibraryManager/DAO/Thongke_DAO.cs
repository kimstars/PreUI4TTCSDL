using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
namespace LibraryManager.DAO
{
    class Thongke_DAO:DataProvider
    {
        public DataTable tk_sachmuon()
        {
            string sqlString ="select * from cuonsach where trangthai ='1'";
            return GetData(sqlString);
        }
    }
}
