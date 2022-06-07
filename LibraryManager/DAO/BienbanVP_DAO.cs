using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManager.DAO
{
    class BienbanVP_DAO : DataProvider
    {
        //BienBanViPham bbvp = new BienBanViPham();
        public string get_ten_dg(string madocgia)
        {
            string sqlString = "select tendocgia from docgia where madocgia = '" + madocgia + "'";
            return GetString(sqlString);
        }
        public string get_ten_nv(string a)
        {
            string sqlString = "select tennhanvien from nhanvien where manhanvien = '" + a + "'";
            return GetString(sqlString);
        }
        public string Get_MaVP()
        {
            string sqlString = "select top(1) mavipham from ViPham order by mavipham)";
            return GetString(sqlString);
        }
        public string Get_sl_MaVP()
        {
            string sqlString = "select count(mavipham) from bienbanvipham ";
            return GetCount(sqlString).ToString();
        }
        public DataTable loadMaSach(string madg)
        {
            string sqlString = $"select masach from thongtinmuontra ttmt, phieumuontra pmt where pmt.mamuontra= ttmt.mamuontra and madocgia = '{madg}' and ngaytra is null";
            return GetData(sqlString);
        }
        public DataTable loadManv()
        {
            string sqlString = "select manhanvien from nhanvien";
            return GetData(sqlString);
        }
        public DataTable loadMaDg()
        {
            string sqlString = "select distinct(madocgia) from PHIEUMUONTRA pmt, THONGTINMUONTRA tt where pmt.MaMuonTra = tt.MaMuonTra and Ngaytra  is null";
            return GetData(sqlString);
        }
        public void insert(BienBanViPham bbvp)
        {
            string sqlString = $"insert into bienbanvipham values ('{bbvp.MaViPham}','{bbvp.MaDocGia}',N'{bbvp.MaNhanVien}',N'{bbvp.LyDo}',{bbvp.TienPhat},N'{bbvp.TinhTrangSach}')";
            Excute(sqlString);
        }
        public void sua(BienBanViPham bbvp)
        {
            string Lydo = $"%{bbvp.LyDo}%";
            string TinhTrangSach= $"%{bbvp.TinhTrangSach}%";
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("proc_thaydoi_bbvp", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lido", bbvp.LyDo);
                cmd.Parameters.AddWithValue("@tien", bbvp.TienPhat);
                cmd.Parameters.AddWithValue("@mavp", bbvp.MaViPham);
                cmd.Parameters.AddWithValue("@tinhtrang", bbvp.TinhTrangSach);

                rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public void Tao_vp(ViPham vp)
        {
            string sqlString = "insert into vipham (mavipham, masach ) values ('" + vp.MaViPham + "','" + vp.MaSach + "')";
            Excute(sqlString);
        }
        // lấy ra tên cuốn sách từ mã cuốn sách
        public string GetTensach(string masach)
        {
            string sqlString = "select tendausach from cuonsach cs, dausach ds where ds.madausach = cs.madausach and cs.masach='" + masach + "'";
            return GetString(sqlString);
        }
        public Int64 Get_Money(string masach)
        {
            string sqlString = $"select giatien from dausach ds, CUONSACH cs where cs.MaDauSach=ds.MaDauSach and MaSach = '{masach}'";
            return GetCount1(sqlString);

        }
        // lấy số lượng ngày mà cuốn sách đã bị mượn quá hạn trả
        public Int64 soluongngay(string masach)
        {
            string sqlString = $"select datediff(day,hantra,getdate()) songay  from PHIEUMUONTra pmt, THONGTINMUONTRA tt where tt.MaMuonTra=pmt.MaMuonTra and masach='{masach}'";
            return GetCount(sqlString);
        }
        //-- Thủ tục update ngày trả và set trạng thái sách bằng 0
        public void update__ngaytra_0_BBVP(string masach )
        {
            
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("update_BBVP_ngaytra_0", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@macs", masach);
                
                rd = cmd.ExecuteReader();
                dt.Load(rd);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        //-- Thủ tục update ngày trả và set trạng thái sách bằng 1
        public void update__ngaytra_1_BBVP(string masach)
        {
                                   
            string NameProc = "update_BBVP_ngaytra_1";

            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@macs", masach);

            Excute_Proc_NParam(NameProc, sParams);

        }
        //lay ra ds cuon sachs cung ly do vi pham
        public DataTable GetTT_BBVP(string MaVP)
        {
            string sql = $"SELECT vp.MaSach, ds.TenDauSach, vp.LyDo, vp.TienPhat FROM dbo.BIENBANVIPHAM  bb INNER JOIN dbo.VIPHAM vp ON vp.MaViPham = bb.MaViPham INNER JOIN dbo.DOCGIA dg ON dg.MaDocGia = bb.MaDocGia INNER JOIN dbo.CUONSACH cs ON cs.MaSach = vp.MaSach INNER JOIN dbo.DAUSACH ds ON ds.MaDauSach = cs.MaDauSach WHERE bb.MaViPham = '{MaVP}'";
            return GetData(sql);
        }
        //lay ra thong tin bien ban vi pham (ngay tra, ten doc gia vi pham, ten nhan vien lap bien ban)

        public DataTable RP_ThongtinVP(string MaVP)
        {
            string procName = "proc_RP_ThongtinVP";

            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@mavp", MaVP);
            return GetData_Proc_NParam(procName, sParams);
        }


    }


    // sử dụng trigger biên bản vi phạm thì tự động thêm vi phạm


    
}
