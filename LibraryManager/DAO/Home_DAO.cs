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


        //proc load so luong doc gia
        public DataTable LoadSLDG()
        {
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_LOAD_SoDocGia", sParams);
        }

        //proc tim kiem the loai
        public DataTable SearchTL(string _timkiem)
        {
            string NameProc = "proc_HOME_Tim_TL";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@keyword", _timkiem);

            return GetData_Proc_NParam(NameProc, sParams);
        }

        //proc tim kiem tac gia
        public DataTable SearchTG(string _timkiem)
        {

            string NameProc = "proc_HOME_Tim_TG";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@keyword", _timkiem);

            return GetData_Proc_NParam(NameProc, sParams);
        }

        //proc tim kiem dau sach
        public DataTable SearchDS(string _timkiem)
        {
            string NameProc = "proc_HOME_Tim_DS";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@keyword", _timkiem);

            return GetData_Proc_NParam(NameProc, sParams);
        }

        //proc load tien coc
        public DataTable LoadTienCoc()
        {
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_LOAD_TienCoc", sParams);
        }

        //proc load so luong sach cac the loai
        public DataTable LoadSLTL()
        {
            SqlParameter[] sParams = new SqlParameter[0];
            return GetData_Proc_NParam("proc_HOME_LOAD_SSTheLoai", sParams);
        }
    }
}
