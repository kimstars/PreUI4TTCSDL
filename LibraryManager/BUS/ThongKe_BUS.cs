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
        public DataTable Load_sach_nhap(DateTime a, DateTime b)
        {
            return tkDao.tkSachnhap(a,b);
        }
        public Int64 GetTongso(DateTime ngaybd, DateTime ngaykt)
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
        public DataTable Tk_docgia(string a, DateTime b, DateTime c)
        {
            return tkDao.tk_sachmuonNV_dg(a,b,c);
        }
        public DataTable TK_theongay(DateTime a, DateTime b)
        {
            return tkDao.TK_Sachmuon_theongay(a, b);
        }
        ////// của nhân viên
        //thông kê tất cả sách mượn
        // thống kê sách mượn trễ hạn trong một khoảng thời gian
        public DataTable TK_trehan(string ngaybd, string ngaykt)
        {
            return tkDao.loadtk_trehan(ngaybd, ngaykt);
        }
        public DataTable TK_vipham_nv(string ngaybd, string ngaykt)
        {
            return tkDao.loadtk_vipham(ngaybd, ngaykt);
        }
        public DataTable TK_all_nv(string ngaybd, string ngaykt)
        {
            return tkDao.loadtk_all(ngaybd, ngaykt);
        }
        //thống kê tất cả sách mượn theo một độc giả
        public DataTable TK_dg_nv(string ngaybd, string ngaykt, string madg, string tendg)
        {
            return tkDao.loadtk_dg(ngaybd, ngaykt,madg,tendg);
        }
        //thống kê tất cả sách mượn trễ hạn theo một độc giả
        public DataTable TK_trehan_dg_nv(string ngaybd, string ngaykt, string madg, string tendg)
        {
            return tkDao.loadtk_trehan_dg(ngaybd, ngaykt,madg,tendg);
        } 
        //thống kê tất cả sách mượn vi phạm theo một độc giả
        public DataTable TK_vipham_dg_nv(string ngaybd, string ngaykt, string madg, string tendg)
        {
            return tkDao.loadtk_vipham_dg(ngaybd, ngaykt,madg,tendg);
        }
        // Thống kê tất cả sách được mượn theo đầu sách
        public DataTable TK_ds_nv(string ngaybd, string ngaykt, string mads, string tends)
        {
            return tkDao.loadtk_dausach(ngaybd, ngaykt,mads,tends);
        }
        // Thống kê tất cả sách được mượn theo đầu sách trễ hạn
        public DataTable TK_trehan_ds_nv(string ngaybd, string ngaykt, string mads, string tends)
        {
            return tkDao.loadtk_trehan_ds(ngaybd, ngaykt,mads,tends);
        }
        // Thống kê tất cả sách được mượn theo đầu sách vi phạm
        public DataTable TK_vipham_ds_nv(string ngaybd, string ngaykt, string mads, string tends)
        {
            return tkDao.loadtk_vipham_ds(ngaybd, ngaykt,mads,tends);
        }
        // Thống kê tất cả sách mượn theo thể loại 
        public DataTable TK_theloai_nv(string ngaybd, string ngaykt, string matl, string tentl)
        {
            return tkDao.loadtk_tl(ngaybd, ngaykt,matl,tentl);
        }
        // Thống kê tất cả sách được mượn theo thể loại trễ hạn
        public DataTable TK_theloai_trehan_nv(string ngaybd, string ngaykt, string matl, string tentl)
        {
            return tkDao.loadtk_trehan_tl(ngaybd, ngaykt,matl,tentl);
        }
        // thống kê tất cả sách được mượn theo thể loại vi phạm
        public DataTable TK_vipham_tl_nv(string ngaybd, string ngaykt, string matl, string tentl)
        {
            return tkDao.loadtk_vipham_tl(ngaybd, ngaykt,matl,tentl);
        }
        // Thống kê tất cả sách mượn theo nhà xuất bản
        public DataTable TK_nxb_nv(string ngaybd, string ngaykt, string maxb, string tennxb)
        {
            return tkDao.loadtk_nxb(ngaybd, ngaykt,maxb,tennxb);
        }
        // Thống kê tất cả sách mượn theo nxb trễ hạn
        public DataTable TK_trehan_nxb_nv(string ngaybd, string ngaykt, string maxb, string tennxb)
        {
            return tkDao.loadtk_trehan_nxb(ngaybd, ngaykt,maxb,tennxb);
        }
        // Thống kê tất cả sách mượn theo nxb vi phạm
        public DataTable TK_vipham_nxb_nv(string ngaybd, string ngaykt, string maxb, string tennxb)
        {
            return tkDao.loadtk_vipham_nxb(ngaybd, ngaykt,maxb,tennxb);
        }
        // thống ke 3 người mượn nhiều nhất
        public DataTable TK_muonnhieu(string ngaybd, string ngaykt)
        {
            return tkDao.tk_muonnhieu_dg(ngaybd, ngaykt);
        }
    }
}
