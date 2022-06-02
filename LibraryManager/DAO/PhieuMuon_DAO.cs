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
    class PhieuMuon_DAO : DataProvider
    {
        public DataTable Get_DSphieumuon()
        {
            SqlParameter[] sParams = new SqlParameter[0];

            return GetData_Proc_NParam("proc_PM_DSPhieuMuon",sParams);

            //loại ko tham số

            
        }




        public DataTable Get_DSphieumuon(string keyword)
        {
            //ví dụ cái này có tham số 
            string NameProc = "proc_PM_DSPhieuMuon_keyword";

            //có hai parameter 

            keyword = $"%{keyword}%";

            SqlParameter[] sParams = new SqlParameter[2];

            sParams[0] = new SqlParameter("@keyMa", keyword);
            sParams[1] = new SqlParameter("@keyTen", keyword);

            return GetData_Proc_NParam(NameProc,sParams);

            //loại có tham số 

        }
        public DataTable Get_DSphieumuon(DateTime start, DateTime end)
        {

            string NameProc = "proc_PM_DSPhieuMuon_Time";

            SqlParameter[] sParams = new SqlParameter[2];

            sParams[0] = new SqlParameter("@start", DateToString(start));
            sParams[1] = new SqlParameter("@end", DateToString(end));

            return GetData_Proc_NParam(NameProc, sParams);


        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from PhieuMuon where MaDocGia like N'%{0}%' or TenDocGia like N'%{0}%'", _timkiem);

            return GetData(sqlString);
        }

        //proc lấy thông tin sách mượn theo mã mượn trả
        public DataTable GetThongtinSachMuon(string MaMuonTra)
        {
            string NameProc = "proc_PM_TTSachMuon";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@MaMT", MaMuonTra);
            return GetData_Proc_NParam(NameProc, sParams);
        }

        //proc lấy ra mã phiếu mượn lớn nhất
        public string GetLastest_MaPhieuMuon()
        {

            string NameProc = "proc_cs_GetLastest_MaPhieuMuon";
            SqlParameter[] sParams = new SqlParameter[0];
            return GetString_Proc_NParam(NameProc, sParams);
        }



        #region insertPM

        public void InsertPhieuMuonTra(PhieuMuonTra pm, List<string> dsMaSach, bool isNV)
        {
            string sql;
            if (isNV)
            {
                sql = $"INSERT INTO dbo.PHIEUMUONTRA VALUES ('{pm.MaMuonTra}','{pm.MaDocGia}', '{pm.MaNhanVien}', '{DateToString(pm.NgayMuon) }', '{DateToString(pm.HanTra)}',  1, '{pm.TienCoc}')";
            }
            else
            {
                sql = $"INSERT INTO dbo.PHIEUMUONTRA VALUES ('{pm.MaMuonTra}','{pm.MaDocGia}', NULL, '{DateToString(pm.NgayMuon) }', '{DateToString(pm.HanTra)}' ,  0, '{pm.TienCoc}')";

            }

            Excute(sql);

            foreach (var masach in dsMaSach)
            {
                sql = $"INSERT INTO dbo.THONGTINMUONTRA VALUES('{pm.MaMuonTra}',  '{masach}', NULL)";
                Excute(sql);
            }

        }


        #endregion

        #region update ds phieu muon

        //proc update trạng thái đã xử lý cho phiếu mượn trả
        public void Update_DaXL_PM(string MaMuonTra,string MaNhanVien)
        {
            string NameProc = "proc_PM_UpdateDaXuly";
            SqlParameter[] sParams = new SqlParameter[2];
            sParams[0] = new SqlParameter("@MaMT", MaMuonTra);
            sParams[1] = new SqlParameter("@MaNV", MaNhanVien);
            Excute_Proc_NParam(NameProc, sParams);
        }

        #endregion


        #region in phieu muon

        public DataTable GetTTPM(string MaMT)
        {
            string NameProc = "TTPhieuMuon";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@MaMT", MaMT);
            return GetData_Proc_NParam(NameProc, sParams);
        }


        //proc lấy ra mã nv xử lý và mã độc giả của phiếu mượn có mã
        public DataTable LoadNVDG_MT(string MaMT)
        {
            string NameProc = "proc_PM_LoadNVDG_MT";
            SqlParameter[] sParams = new SqlParameter[1];
            sParams[0] = new SqlParameter("@MaMT", MaMT);
            return GetData_Proc_NParam(NameProc, sParams);
        }


        #endregion

    }
}
