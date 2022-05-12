using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;

namespace LibraryManager.DAO
{
    class Home_DAO : DataProvider
    {
        public String GetTongSach()
        {
            string sqlString = "SELECT COUNT(MASACH) FROM dbo.CUONSACH";
            return GetString(sqlString);
        }
        public String GetTongDG()
        {
            string sqlString = "SELECT COUNT(MADOCGIA) FROM dbo.DOCGIA";
            return GetString(sqlString);
        }
        public String GetTongDS()
        {
            string sqlString = "SELECT COUNT(MADAUSACH) FROM dbo.DAUSACH";
            return GetString(sqlString);
        }
        public String GetTongTL()
        {
            string sqlString = "SELECT COUNT(MATHELOAI) FROM dbo.THELOAI";
            return GetString(sqlString);
        }

        public DataTable Get2Anh()
        {
            string sql = "select top 2 madausach, count(tt.masach) sl from thongtinmuontra tt, cuonsach cs where cs.masach = tt.masach group by madausach order by sl desc";
            return GetData(sql);
        }

        public DataTable LoadPhieuMuon()
        {
            string sql = "SELECT MaMuonTra, MaDocGia, MaNhanVien,NgayMuon,HanTra FROM dbo.PHIEUMUONTRA";
            return GetData(sql);
        }
        public DataTable LoadSachMoi()
        {
            string sql = 
        }
    }
}
