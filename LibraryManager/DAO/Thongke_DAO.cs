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
        public DataTable tk_sachmuon_nv()
        {
            
            string sqlString ="select * from cuonsach where trangthai ='0'";
            return GetData(sqlString);
        }
        public DataSet Get_chart_tk_sachmuon()
        {
            string sqlString = "select case trangthai when 0 then N'Đã mượn' when 1 then N'Chưa được mượn' end as trangthai, count(trangthai)  as giatri from cuonsach group by trangthai ";
            return chart(sqlString);
            
        }
        public DataTable tk_sachmuon_dg(string a)
        {
            string sqlString = "select dg.madocgia, tendocgia, pmt.mamuontra, tt.MaSach ,ds.TenDauSach, ngaytra " +
                "from docgia dg, PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds " +
                "where dg.MaDocGia = pmt.MaDocGia and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and dg.Madocgia ='" +a + "'";
            return GetData(sqlString);
        }
        public DataTable tk_sachchuatra_dg(string a)
        {
            string sqlString = "select dg.madocgia, tendocgia, pmt.mamuontra, tt.MaSach ,ds.TenDauSach, ngaytra " +
                "from docgia dg, PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds " +
                "where dg.MaDocGia = pmt.MaDocGia and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and ngaytra is null and dg.Madocgia ='" + a + "'";
            return GetData(sqlString);
        }
        public DataTable tk_sach_tre_hen_dg(string a)
        {
            string sqlString = "select dg.madocgia, tendocgia, pmt.mamuontra, tt.MaSach ,ds.TenDauSach, ngaytra ,NgayMuon " +
                "from docgia dg, PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where dg.MaDocGia = pmt.MaDocGia " +
                "and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach " +
                "and (ngaytra > hantra or (ngaytra is null and getdate()> hantra)) and dg.Madocgia ='" + a + "'";
            return GetData(sqlString);
        }
        public DataTable tkSachnhap(string ngaybd, string ngaykt)
        {
            string sqlString = "select ds.* from DAUSACH ds,THONGTINNHAPSACH ttns, PHIEUNHAP pn where NgayNhap between '"+ngaybd+"' and '"+ngaykt+"' and pn.maphieunhap = ttns.maphieunhap and ttns.MaDauSach= ds.MaDauSach";
            return GetData(sqlString);
        }
        public Int64 Load_tongso(string ngaybd, string ngaykt)
        {
            string sqlString = "select sum(ttns.SoLuongSach) from DAUSACH ds,THONGTINNHAPSACH ttns, PHIEUNHAP pn where NgayNhap between '" + ngaybd + "' and '" + ngaykt + "' and pn.maphieunhap = ttns.maphieunhap and ttns.MaDauSach= ds.MaDauSach";
            return GetCount(sqlString);
        }
        public DataTable load_combobox_docgia()
        {
            string sqlString = " select distinct(madocgia) from PHIEUMUONTRA pmt, THONGTINMUONTRA tt where pmt.MaMuonTra = tt.MaMuonTra and tt.NgayTra is null";
            return GetData(sqlString);
        }

        public DataTable tk_sachmuonNV_dg(string a, string b, string c)
        {
            string sqlString = "select Tendocgia, pmt.Mamuontra, tt.MaSach ,ds.TenDauSach,Ngaymuon, Ngaytra " +
                "from docgia dg, PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds " +
                "where dg.MaDocGia = pmt.MaDocGia and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and dg.Madocgia ='" 
                + a + "' and ngaymuon between '"+b+"' and '"+c+"'";
            return GetData(sqlString);
        }
        public DataTable tk_trehan_nv(string a)
        {
            string sqlString = "select dg.madocgia, tendocgia, pmt.mamuontra, tt.MaSach ,ds.TenDauSach, ngaytra ,NgayMuon " +
       "from docgia dg, PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where dg.MaDocGia = pmt.MaDocGia " +
       "and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach " +
       "and (ngaytra > hantra or (ngaytra is null and getdate()> hantra)) and dg.Madocgia ='" + a + "'";
            return GetData(sqlString);
        }
        public DataTable TK_Sachmuon_theongay(string b, string c)
        {
           string sqlString = "select dg.madocgia, tendocgia" +
                ", pmt.Mamuontra, tt.MaSach ,ds.TenDauSach,Ngaymuon, Ngaytra " +
                "from docgia dg, PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds " +
                "where dg.MaDocGia = pmt.MaDocGia and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach  and ngaymuon between '" + b + "' and '" + c + "'";
            return GetData(sqlString);
        }
    }
}
