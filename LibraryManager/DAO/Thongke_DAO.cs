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
            
            string sqlString ="select * from cuonsach where trangthai ='1'";
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
        public DataTable tkSachnhap()
        {
            string sqlString = "select ds.* from DAUSACH ds,THONGTINNHAPSACH ttns, PHIEUNHAP pn where NgayNhap between '2010-12-3' and '2022-12-5' and pn.maphieunhap = ttns.maphieunhap and ttns.MaDauSach= ds.MaDauSach";
            return GetData(sqlString);
        }
    }
}
