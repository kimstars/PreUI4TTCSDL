using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LibraryManager.DAO
{
    class Thongke_DAO : DataProvider
    {
        public DataTable tk_sachmuon_nv()
        {
            
            string sqlString = @" select  tt.MaSach ,ds.TenDauSach,tendocgia,ngaymuon, ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds , docgia dg
                                  where pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and pmt.madocgia= dg.madocgia ";
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
            string sqlString = $@"select pmt.mamuontra , tt.MaSach,ds.TenDauSach,ngaymuon, ngaytra  
                from  PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where 
                pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach 
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
            string sqlString = $"select tt.MaSach ,ds.TenDauSach,Ngaymuon, Ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds,dbo.DOCGIA dg where dg.MaDocGia = pmt.MaDocGia and pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach and dg.Madocgia ='{a}' and ngaymuon between '{DateToString(b)}' and '{DateToString(c)}'";

            return GetData(sqlString);
        }
        public DataTable tk_trehan_nv(string madg)
        {
            string sqlString = $"select tt.MaSach ,ds.TenDauSach,ngaymuon, ngaytra  from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds , dbo.DOCGIA dg WHERE  pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach  and (ngaytra > hantra or (ngaytra is null and getdate()> hantra)) and dg.Madocgia ='{madg}'";
            return GetData(sqlString);
        }
        public DataTable TK_Sachmuon_theongay(DateTime b, DateTime c)
        {
           string sqlString = $"select tt.MaSach ,ds.TenDauSach,Ngaymuon, Ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt,CUONSACH cs,DAUSACH ds where pmt.MaMuonTra = tt.MaMuonTra and tt.MaSach = cs.MaSach and cs.MaDauSach = ds.MaDauSach  and ngaymuon between '{DateToString(b)}' and '{DateToString(c)}'";
            return GetData(sqlString);
        }

        ///////////////////////////////////////////////////////////- Nhân viên
        public DataTable loadtk_all(string ngaybd, string ngaykt)
        {
            string sqlString = $"EXEC sach_duoc_muon '{ngaybd}', '{ngaykt}'";
            return GetData(sqlString);
        }
        //thống kê theo tên độc giả hoặc mã độc giả theo hai ngày bắt đầu và kết thúc
        public DataTable loadtk_dg(string ngaybd, string ngaykt, string madg, string tendg)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_dg", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", madg);
                cmd.Parameters.AddWithValue("@tendg", tendg);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả
        public DataTable loadtk_trehan(string ngaybd, string ngaykt)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_trehan", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
               // return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các sách vi phạm trong khoảng thời gian 
        public DataTable loadtk_vipham(string ngaybd, string ngaykt)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_vipham", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        //thống kê các sách đã mượn theo tên độc giả hoặc mã độc giả -- giống với loadtk_dg

        // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả theo tên độc giả hoặc mã độc giả
        public DataTable loadtk_trehan_dg(string ngaybd, string ngaykt, string madg, string tendg)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_trehan_dg", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", madg);
                cmd.Parameters.AddWithValue("@tendg", tendg);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các sách vi phạm trong khoảng thời gian của độc giả a
        public DataTable loadtk_vipham_dg(string ngaybd, string ngaykt, string madg, string tendg)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_vipham_dg", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", madg);
                cmd.Parameters.AddWithValue("@tendg", tendg);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;

        }
        //thống kê các sách đã mượn theo tên đầu sách hoặc mã đầu sách
        public DataTable loadtk_dausach(string ngaybd, string ngaykt, string mads, string tends)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_dausach", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", mads);
                cmd.Parameters.AddWithValue("@tends", tends);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các cuốn sách đã trễ hạn có hạn trả ở trong khoảng đó nhưng chưa trả theo tên đầu sách hoặc mã đầu sách
        public DataTable loadtk_trehan_ds(string ngaybd, string ngaykt, string mads, string tends)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_trehan_ds", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                //cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.Add(new SqlParameter("@ngaybd", SqlDbType.DateTime) { Value = ngaybd });
                cmd.Parameters.Add(new SqlParameter("@ngaykt", SqlDbType.DateTime) { Value = ngaykt });
                cmd.Parameters.AddWithValue("@ma", mads);
                cmd.Parameters.AddWithValue("@tends", tends);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các sách vi phạm trong khoảng thời gian theo tên đầu sách hoặc mã đầu sách
        public DataTable loadtk_vipham_ds(string ngaybd, string ngaykt, string mads, string tends)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_vipham_ds", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", mads);
                cmd.Parameters.AddWithValue("@tends", tends);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        //thống kê các sách đã mượn theo tên thể loại hoặc mã thể loại
        public DataTable loadtk_tl(string ngaybd, string ngaykt, string matl, string tentl)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_theloai", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", matl);
                cmd.Parameters.AddWithValue("@tentl", tentl);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả theo tên thể loại hoặc mã thể loại
        public DataTable loadtk_trehan_tl(string ngaybd, string ngaykt, string matl, string tentl)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_trehan_tl", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", matl);
                cmd.Parameters.AddWithValue("@tentl", tentl);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các sách vi phạm trong khoảng thời giantheo tên thể loại hoặc mã thể loại
        public DataTable loadtk_vipham_tl(string ngaybd, string ngaykt, string matl, string tentl)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_vipham_tl", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", matl);
                cmd.Parameters.AddWithValue("@tentl", tentl);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        //thống kê các sách đã mượn theo tên nhà xuất bản hoặc mã xuất bản
        public DataTable loadtk_nxb(string ngaybd, string ngaykt, string manxb, string tennxb)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_nxb", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", manxb);
                cmd.Parameters.AddWithValue("@tennxb", tennxb);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các cuốn sách đã trễ hạn có ngày trả ở trong khoảng đó nhưng chưa trả theo nhà xuất bản hoặc mã xuất bản
        public DataTable loadtk_trehan_nxb(string ngaybd, string ngaykt, string manxb, string tennxb)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_trehan_nxb", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", manxb);
                cmd.Parameters.AddWithValue("@tennxb", tennxb);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // thống kê tất cả các sách vi phạm trong khoảng thời giantheo nhà xuất bản hoặc mã xuất bản
        public DataTable loadtk_vipham_nxb(string ngaybd, string ngaykt, string manxb, string tennxb)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("sach_duoc_muon_vipham_nxb", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                cmd.Parameters.AddWithValue("@ma", manxb);
                cmd.Parameters.AddWithValue("@tennxb", tennxb);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        // lấy ra 3 độc giả mượn nhiều sách nhất trong khoảng thời gian

        public DataTable tk_muonnhieu_dg(string ngaybd, string ngaykt)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("dg_muon_max", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);
                
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }

    }
}
