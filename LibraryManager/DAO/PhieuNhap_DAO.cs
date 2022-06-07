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
    class PhieuNhap_DAO : DataProvider
    {
        public DataTable Get_DSphieunhap()
        {
            SqlParameter[] sParams = new SqlParameter[0];

            return GetData_Proc_NParam("proc_PM_DSPhieuNhap", sParams);

            //loại ko tham số


        }




        public DataTable Get_DSphieunhap(string keyword)
        {
            //ví dụ cái này có tham số 
            string NameProc = "proc_PM_DSPhieuNhap_keyword";

            //có hai parameter 

            keyword = $"%{keyword}%";

            SqlParameter[] sParams = new SqlParameter[2];

            sParams[0] = new SqlParameter("@keyMa", keyword);
            sParams[1] = new SqlParameter("@keyTen", keyword);

            return GetData_Proc_NParam(NameProc, sParams);

            //loại có tham số 

        }
        public DataTable Get_DSphieunhap(DateTime start, DateTime end)
        {

            string NameProc = "proc_PM_DSPhieuNhap_Time";

            SqlParameter[] sParams = new SqlParameter[2];

            sParams[0] = new SqlParameter("@start", DateToString(start));
            sParams[1] = new SqlParameter("@end", DateToString(end));

            return GetData_Proc_NParam(NameProc, sParams);


        }


        public string GetLastest_MaPhieuNhap()
        {
            string sql = "SELECT TOP 1 MaMuonTra FROM dbo.PHIEUMUONTRA ORDER BY MaMuonTra DESC";
            return GetString(sql);
        }



        #region insertPM

        public void InsertPhieuNhap(PhieuNhap pn, List<string> dsMaSach, bool isNV)
        {
            string sql;
            sql = $"INSERT INTO dbo.PHIEUMUONTRA VALUES ('{pn.MaPhieuNhap}','{pn.MaNhanVien}', '{DateToString(pn.NgayNhap) }')";
            Excute(sql);
        }


        #endregion

        #region update ds phieu muon

        //proc update trạng thái đã xử lý cho phiếu mượn trả
        public void Update_DaXL_PM(string MaMuonTra)
        {
            string NameProc = "proc_PM_UpdateDaXuly";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@MaMT", MaMuonTra);
            Excute_Proc_NParam(NameProc, sParams);
        }

        #endregion


        #region in phieu nhap

        public DataTable GetTTPM(string MaNV, DateTime NgayLap)
        {
            string NameProc = "TTPhieuNhap";
            SqlParameter[] sParams = new SqlParameter[2];
            sParams[0] = new SqlParameter("@MaNV", MaNV);
            sParams[1] = new SqlParameter("@NgayNhap", DateToString(NgayLap));
            return GetData_Proc_NParam(NameProc, sParams);
        }

        //proc lấy ra mã nv xử lý và mã độc giả của phiếu mượn có mã
        public DataTable LoadTenNV_PN(string MaNV)
        {
            string NameProc = "PN_LOADNV";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@MANV", MaNV);
            return GetData_Proc_NParam(NameProc, sParams);
        }


        #endregion
        public DataTable DSPN_getDS()
        {
            string sql = "SELECT MaPhieuNhap, MaNhanVien, NgayNhap FROM dbo.PHIEUNHAP";
            return GetData(sql);
        }


        public DataTable DSPN_TTphieunhap_Ma(string MaPhieuNhap)
        {
            string sql = $"SELECT cs.MaSach,ds.TenDauSach,cs.ViTriSach FROM dbo.THONGTINNHAPSACH tt INNER JOIN dbo.CUONSACH cs ON cs.MaSach = tt.MaSach INNER JOIN   dbo.DAUSACH ds ON ds.MaDauSach = cs.MaDauSach WHERE tt.MaPhieuNhap = '{MaPhieuNhap}'";
            return GetData(sql);
        }

        public DataTable DSPN_TimKiem(string key)
        {
            string sql = $"SELECT MaPhieuNhap, MaNhanVien, NgayNhap FROM dbo.PHIEUNHAP WHERE MaPhieuNhap LIKE '%{key}' OR MaNhanVien LIKE '%{key}%' ";
            return GetData(sql);
        }
    }
}

