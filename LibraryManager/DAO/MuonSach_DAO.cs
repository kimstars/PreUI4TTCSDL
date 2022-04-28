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
            string sql = $@"INSERT INTO dbo.THONGTINMUONTRA VALUES ('{ttmt.MaMuonTra}', '{ttmt.MaSach}','')";

            Excute(sql);

            return true;

        }



        public DataTable LoadPhieuMuon()
        {
            string sql = "SELECT MaMuonTra, MaDocGia, MaNhanVien,NgayMuon,HanTra FROM dbo.PHIEUMUONTRA";
            return GetData(sql);
        }

        // độc giả chọn sách -> bảng ghi thông tin các sách độc giả chọn
        public DataTable LoadThongTinSachMuon(string [] ListMaSach)
        { 
            string sql = "";

            DataTable rs = new DataTable();

            foreach (var i in ListMaSach)
            {
                sql = $"SELECT * FROM CuonSach WHERE MaSach = '{i}'";
                SqlDataAdapter temp = GetDataSet(sql);
                temp.Fill(rs);
            }
            return rs;
        }


    }
}
