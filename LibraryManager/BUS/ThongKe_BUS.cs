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
        public DataTable load_tt_sachmuon_nv()
        {
            return tkDao.tk_sachmuon_nv();
        }
        public DataTable Load_tt_sachmuon_dg(string a)
        {
            return tkDao.tk_sachmuon_dg(a);
        }
        public DataTable Load_tt_sachchuatra_dg(string a)
        {
            return tkDao.tk_sachchuatra_dg(a);
        }
        public DataTable Load_tt_sach_trehen_dg(string a)
        {
            return tkDao.tk_sach_tre_hen_dg(a);
        }
        public DataTable Load_sach_nhap(string a, string b)
        {
            return tkDao.tkSachnhap(a,b);
        }
        public Int64 GetTongso(string ngaybd, string ngaykt)
        {
            return tkDao.Load_tongso(ngaybd,ngaykt);
        }
        public DataTable get_madg_cmb()
        {
            return tkDao.load_combobox_docgia();
        }
        public DataTable get_trehan(string a)
        {
            return tkDao.tk_trehan_nv(a);
        }
        public DataTable Tk_docgia(string a, string b, string c)
        {
            return tkDao.tk_sachmuonNV_dg(a,b,c);
        }
        public DataTable TK_theongay(string a, string b)
        {
            return tkDao.TK_Sachmuon_theongay(a, b);
        }
    }
}
