using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using LibraryManager.DAO;

namespace LibraryManager.BUS
{
    class ThongKe_BUS
    {
        Thongke_DAO tkDao = new Thongke_DAO();
        public DataSet LoadChartSachMuon()
        {
            return tkDao.Get_chart_tk_sachmuon();

        }
    }
}
