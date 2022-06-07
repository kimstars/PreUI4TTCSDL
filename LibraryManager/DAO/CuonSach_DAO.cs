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
    class CuonSach_DAO : DataProvider
    {

        public DataTable GetMaSach()
        {
            string sql = "SELECT MaSach FROM dbo.CUONSACH  WHERE TrangThai=1";
            return GetData(sql);
        }
        //proc lấy ra mã sách lớn nhất

        public string get_ten_nv(string a)
        {
            string sqlString = "select tennhanvien from nhanvien where manhanvien = '" + a + "'";
            return GetString(sqlString);
        }
        public string Lastest_MaSach()
        {

            string NameProc = "proc_cs_Lastest_MaSach";
            SqlParameter[] sParams = new SqlParameter[0];

            return GetString_Proc_NParam(NameProc, sParams);


        }

        public void InsertCuonSach(string MaSach, string MaDauSach, String ViTri, string TinhTrang)
        {
            string sql = $"INSERT INTO dbo.CUONSACH VALUES('{MaSach}','{MaDauSach}','{ViTri}','{TinhTrang}',1)";
            Excute(sql);
        }

        public DataTable GetAllSach()
        {
            string sql = "SELECT * FROM dbo.CUONSACH";
            return GetData(sql);
        }

        public void InsertCuonSach(CuonSach cs, PhieuNhap pn)
        {
            string sql = $"EXEC PROC_NHAPCUONSACH'{cs.MaSach}','{cs.MaDauSach}','{cs.ViTriSach}','{cs.TinhTrangMoiCu}','{cs.TrangThai}','{pn.MaPhieuNhap}','{pn.MaNhanVien}'";

            Excute(sql);
        }

        public int GetCheckMaSach(string Ma)
        {
            string sql = "SELECT COUNT(MaSach) FROM dbo.CUONSACH WHERE MaSach = '"+ Ma +"'";
            return (int)GetCount(sql);
        }



    }
}
