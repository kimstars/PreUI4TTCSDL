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
            
            string sqlString = @" select pmt.MaMuonTra, tt.MaSach ,ds.TenDauSach,ngaymuon, ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds 
                                  where pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach ";
            return GetData(sqlString);
        }
        public DataSet Get_chart_tk_sachmuon()
        {
            string sqlString = "select case trangthai when 0 then N'Đã mượn' when 1 then N'Chưa được mượn' end as trangthai, count(trangthai)  as giatri from cuonsach group by trangthai ";
            return chart(sqlString);
            
        }
        public DataTable tk_sachmuon_dg(string madg)
        {
            string sqlString = $@"select pmt.mamuontra, tt.MaSach ,ds.TenDauSach,ngaymuon, ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds 
                                  where pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and pmt.Madocgia ='{madg}'";
            return GetData(sqlString);
        }
        public DataTable tk_sachchuatra_dg(string madg)
        {
            string sqlString = $@"select pmt.mamuontra, tt.MaSach ,ds.TenDauSach, ngaymuon, ngaytra 
                from  PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds
                where pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and ngaytra is null and pmt.Madocgia ='{madg}'";
            return GetData(sqlString);
        }
        public DataTable tk_sach_tre_hen_dg(string madg)
        {
            string sqlString = $@"select pmt.mamuontra, tt.MaSach ,ds.TenDauSach,ngaymuon, ngaytra  
                from docgia dg, PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where 
                and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach 
                and (ngaytra > hantra or (ngaytra is null and getdate()> hantra)) and pmt.Madocgia ='{madg}'";
            return GetData(sqlString);
        }
        public DataTable tkSachnhap(DateTime ngaybd, DateTime ngaykt)
        {
            string sqlString = $"select ds.TenDauSach,ds.SoLuong from DAUSACH ds,THONGTINNHAPSACH ttns, PHIEUNHAP pn WHERE NgayNhap BETWEEN '{DateToString(ngaybd)}' AND '{DateToString(ngaykt)}' AND pn.maphieunhap = ttns.maphieunhap and ttns.MaDauSach = ds.MaDauSach";
            return GetData(sqlString);
        }
        public Int64 Load_tongso(DateTime ngaybd, DateTime ngaykt)
        {
            string sqlString = $"select isnull(sum(ttns.SoLuongSach),0) from DAUSACH ds,THONGTINNHAPSACH ttns, PHIEUNHAP pn where NgayNhap between '{DateToString(ngaybd)}' and '{DateToString(ngaykt)}' and pn.maphieunhap = ttns.maphieunhap and ttns.MaDauSach= ds.MaDauSach";
            return GetCount(sqlString);
        }
        public DataTable load_combobox_docgia()
        {
            string sqlString = " select distinct(madocgia) from PHIEUMUONTRA pmt, THONGTINMUONTRA tt where pmt.MaMuonTra = tt.MaMuonTra and tt.NgayTra is null";
            return GetData(sqlString);
        }

        public DataTable tk_sachmuonNV_dg(string a, DateTime b, DateTime c)
        {
            string sqlString = $"select tt.MaSach ,ds.TenDauSach,Ngaymuon, Ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where dg.MaDocGia = pmt.MaDocGia and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and dg.Madocgia ='{a}' and ngaymuon between '{DateToString(b)}' and '{DateToString(c)}'";

            return GetData(sqlString);
        }
        public DataTable tk_trehan_nv(string madg)
        {
            string sqlString = $@"select tt.MaSach ,ds.TenDauSach,ngaymuon, ngaytra  
               from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where  
               pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach 
               and (ngaytra > hantra or (ngaytra is null and getdate()> hantra)) and dg.Madocgia ='{madg}'";
            return GetData(sqlString);
        }
        public DataTable TK_Sachmuon_theongay(DateTime b, DateTime c)
        {
           string sqlString = $"select tt.MaSach ,ds.TenDauSach,Ngaymuon, Ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach  and ngaymuon between '{DateToString(b)}' and '{DateToString(c)}'";
            return GetData(sqlString);
        }
    }
}
