using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Windows.Forms;
using System.Data;

namespace LibraryManager.DAO
{
    class MuonSach_DAO : DataProvider
    {

        public bool InsertPhieuMuon(PhieuMuonTra pm)
        {
            string sql = $"INSERT INTO dbo.PHIEUMUONTRA (MaMuonTra,MaDocGia, MaNhanVien,NgayMuon,HanTra) VALUES ('{pm.MaMuonTra}', '{pm.MaDocGia}', '{pm.MaNhanVien}', '{DateToString(pm.NgayMuon)}', '{DateToString(pm.HanTra)}')";


            Excute(sql);

            return true;

        }

        public bool InsertThongTinMT(ThongTinMuonTra ttmt)
        {
            string sql = $@"INSERT INTO dbo.THONGTINMUONTRA VALUES ('{ttmt.MaMuonTra}', '{ttmt.MaSach}','{DateToString(ttmt.NgayTra)}')";

            Excute(sql);

            return true;

        }



        public DataTable LoadPhieuMuon()
        {
            string sql = "SELECT MaMuonTra, MaDocGia, MaNhanVien,NgayMuon,HanTra FROM dbo.PHIEUMUONTRA";
            return GetData(sql);
        }

        

    }
}
