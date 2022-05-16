using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class CuonSach_DAO : DataProvider
    {

        public DataTable GetMaSach()
        {
            string sql = "SELECT MaSach FROM dbo.CUONSACH";
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
            return Int32.Parse(ExcuteRetStr(sql));
        }
    }
}
