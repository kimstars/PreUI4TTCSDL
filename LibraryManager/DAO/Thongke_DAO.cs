using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;
namespace LibraryManager.DAO
{
    class Thongke_DAO : DataProvider
    {
        public DataTable tk_sachmuon()
        {
            
            string sqlString ="select * from cuonsach where trangthai ='1'";
            return GetData(sqlString);
        }
        public DataSet Get_chart_tk_sachmuon()
        {
            string sqlString = "select count(trangthai) as giatri from cuonsach group by trangthai ";
            return chart(sqlString);
            
            
        }
    }
}
