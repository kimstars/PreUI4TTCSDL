using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;
using System.Data.SqlClient;

namespace LibraryManager.DAO
{
    class Home_DAO : DataProvider
    {
        public Int64 GetTongSach()
        {
            string sqlString = "SELECT COUNT(MASACH) FROM dbo.CUONSACH";
            return GetCount(sqlString);
        }
        public Int64 GetTongDG()
        {
            string sqlString = "SELECT COUNT(MADOCGIA) FROM dbo.DOCGIA";
            return GetCount(sqlString);
        }
        public Int64 GetTongDS()
        {
            string sqlString = "SELECT COUNT(MADAUSACH) FROM dbo.DAUSACH";
            return GetCount(sqlString);
        }
        public Int64 GetTongTL()
        {
            string sqlString = "SELECT COUNT(MATHELOAI) FROM dbo.THELOAI";
            return GetCount(sqlString);
        }

        //proc top 2 đầu sách nhiều nhất
        public DataTable GetTop2_DSNhieuNhat()
        {
            
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_TOP2DS", sParams);    
        }

        //proc load phieu muon
        public DataTable LoadPhieuMuon()
        {
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_LOADPM", sParams);
        }

        //proc load phieu tra
        public DataTable LoadPhieuTra()
        {
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_LOADPT", sParams);
        }

        //proc load sach moi
        public DataTable LoadSachMoi()
        {
            
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_LOAD_SachMoi", sParams);
        }

        public Int64 GetSachCo()
        {
            string sqlString = "select count(masach) from cuonsach where trangthai = 1";
            return GetCount(sqlString);
        }
        public Int64 GetSachMuon()
        {
            string sqlString = "select count(masach) from cuonsach where trangthai = 0";
            return GetCount(sqlString);
        }

        //proc load so luong doc gia
        public DataTable LoadSLDG()
        {
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_LOAD_SoDocGia", sParams);
        }

        public DataTable SearchTL(string _timkiem)
        {
            string sqlString = string.Format("SELECT TENTHELOAI N'Tên thể loại', COUNT(MASACH) N'Số lượng cuốn sách' FROM dbo.CUONSACH CS, dbo.THELOAI TL, dbo.DAUSACH DS WHERE CS.MaDauSach = DS.MaDauSach AND DS.MaTheLoai = TL.MaTheLoai AND TL.TenTheLoai LIKE N'%{0}%' GROUP BY TL.TenTheLoai", _timkiem);
            return GetData(sqlString);
        }
        public DataTable SearchTG(string _timkiem)
        {
            string sqlString = string.Format("SELECT TENTACGIA N'Tên tác giả', COUNT(DS.MADAUSACH) N'Số lượng đầu sách' FROM dbo.SANGTAC ST, dbo.TACGIA TG, dbo.DAUSACH DS WHERE ST.MaDauSach = DS.MaDauSach AND TG.MaTacGia = ST.MaTacGia AND TG.TenTacGia LIKE N'%{0}%' GROUP BY TG.TenTacGia", _timkiem);
            return GetData(sqlString);
        }
        public DataTable SearchDS(string _timkiem)
        {
            string sqlString = string.Format("SELECT DS.MaDauSach N'Mã đầu sách', DS.TenDauSach N'Tên đầu sách', DS.SoLuong N'Số lượng sách', DS.NamXuatBan, DS.GiaTien, DS.MoTa, TL.TenTheLoai, TG.TenTacGia FROM dbo.DAUSACH DS, dbo.THELOAI TL, dbo.TACGIA TG, dbo.SANGTAC ST WHERE DS.MaTheLoai = TL.MaTheLoai AND TL.TenTheLoai like N'%{0}%' AND DS.MaDauSach = ST.MaDauSach AND ST.MaTacGia = TG.MaTacGia", _timkiem);
            return GetData(sqlString);
        }
    }
}
