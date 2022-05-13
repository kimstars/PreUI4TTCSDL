using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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
            string sql = $@"INSERT INTO dbo.THONGTINMUONTRA VALUES ('{ttmt.MaMuonTra}', '{ttmt.MaSach}', NULL)";

            Excute(sql);

            sql = $"UPDATE dbo.CUONSACH SET TrangThai = 0 WHERE MaSach = '{ttmt.MaSach}'";

            Excute(sql);

            return true;

        }



        public DataTable LoadPhieuMuon()
        {
            string sql = "SELECT MaMuonTra, MaDocGia, MaNhanVien,NgayMuon,HanTra FROM dbo.PHIEUMUONTRA";
            return GetData(sql);
        }

        // độc giả chọn sách -> bảng ghi thông tin các sách độc giả chọn
        public DataTable LoadThongTinSachMuon(List<string> ListMaSach)
        { 
            string sql = "";

            DataTable rs = new DataTable();

            foreach (string i in ListMaSach)
            {
                sql = $"SELECT top 1 cs.MaSach, ds.MaDauSach, ds.TenDauSach, cs.ViTriSach, ds.GiaTien FROM dbo.CUONSACH AS cs INNER JOIN dbo.DAUSACH AS ds ON ds.MaDauSach = cs.MaDauSach WHERE cs.MaDauSach = '{i}' AND cs.TrangThai = 1 GROUP BY cs.MaSach, ds.MaDauSach, ds.TenDauSach, cs.ViTriSach, ds.GiaTien";
                SqlDataAdapter temp = GetDataSet(sql);
                temp.Fill(rs);
            }
            return rs;
        }





    }
}
