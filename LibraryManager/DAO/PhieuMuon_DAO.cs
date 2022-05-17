﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;


namespace LibraryManager.DAO
{
    class PhieuMuon_DAO : DataProvider
    {
        public DataTable Get_DSphieumuon()
        {
            string sqlString = "SELECT pm.MaMuonTra, pm.MaDocGia, dg.TenDocGia, COUNT(tt.MaSach) AS SoLuong ,pm.NgayMuon, pm.DaXuLy FROM dbo.PHIEUMUONTRA pm INNER JOIN dbo.DOCGIA dg ON dg.MaDocGia = pm.MaDocGia INNER JOIN dbo.THONGTINMUONTRA tt ON tt.MaMuonTra = pm.MaMuonTra GROUP BY pm.MaMuonTra, pm.MaDocGia, dg.TenDocGia, pm.NgayMuon, pm.DaXuLy";
            return GetData(sqlString);
        }
        public DataTable Get_DSphieumuon(string keyword)
        {
            string sqlString = $"SELECT pm.MaMuonTra, pm.MaDocGia, dg.TenDocGia, COUNT(tt.MaSach) AS SoLuong ,pm.NgayMuon, pm.DaXuLy FROM dbo.PHIEUMUONTRA pm INNER JOIN dbo.DOCGIA dg ON dg.MaDocGia = pm.MaDocGia INNER JOIN dbo.THONGTINMUONTRA tt ON tt.MaMuonTra = pm.MaMuonTra WHERE pm.MaMuonTra = '{keyword}' OR pm.MaDocGia LIKE '{keyword}' OR dg.TenDocGia LIKE N'{keyword}'  GROUP BY pm.MaMuonTra, pm.MaDocGia, dg.TenDocGia, pm.NgayMuon, pm.DaXuLy";
            return GetData(sqlString);
        }
        public DataTable Get_DSphieumuon(DateTime start, DateTime end)
        {
            string sqlString = $"SELECT pm.MaMuonTra, pm.MaDocGia, dg.TenDocGia, COUNT(tt.MaSach) AS SoLuong ,pm.NgayMuon, pm.DaXuLy FROM dbo.PHIEUMUONTRA pm INNER JOIN dbo.DOCGIA dg ON dg.MaDocGia = pm.MaDocGia INNER JOIN dbo.THONGTINMUONTRA tt ON tt.MaMuonTra = pm.MaMuonTra WHERE pm.NgayMuon BETWEEN '{DateToString(start)}' AND '{DateToString(end)}' GROUP BY pm.MaMuonTra, pm.MaDocGia, dg.TenDocGia, pm.NgayMuon, pm.DaXuLy";
            return GetData(sqlString);
        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from PhieuMuon where MaDocGia like N'%{0}%' or TenDocGia like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }


        public DataTable GetThongtinSachMuon(string MaMuonTra)
        {
            string sql = $"SELECT cs.MaSach, cs.MaDauSach, ds.TenDauSach, ds.GiaTien,cs.ViTriSach FROM dbo.CUONSACH cs INNER JOIN dbo.DAUSACH ds ON ds.MaDauSach = cs.MaDauSach INNER JOIN dbo.THONGTINMUONTRA tt1 ON tt1.MaSach = cs.MaSach WHERE cs.MaDauSach IN(SELECT MaDauSach  FROM dbo.CUONSACH WHERE MaSach IN ( SELECT tt.MaSach   FROM dbo.THONGTINMUONTRA tt    WHERE tt.MaMuonTra = '{MaMuonTra}' ))  AND tt1.MaMuonTra = '{MaMuonTra}'";
            return GetData(sql);
        }

        public string GetLastest_MaPhieuMuon()
        {
            string sql = "SELECT TOP 1 MaMuonTra FROM dbo.PHIEUMUONTRA ORDER BY MaMuonTra DESC";
            return GetString(sql);
        }



        #region insertPM

        public void InsertPhieuMuonTra(PhieuMuonTra pm, List<string> dsMaSach, bool isNV)
        {
            string sql;
            if (isNV)
            {
                sql = $"INSERT INTO dbo.PHIEUMUONTRA VALUES ('{pm.MaMuonTra}','{pm.MaDocGia}', {pm.MaNhanVien}, '{DateToString(pm.NgayMuon) }', '{DateToString(pm.HanTra)}',  1, '{pm.TienCoc}')";
            }
            else
            {
                sql = $"INSERT INTO dbo.PHIEUMUONTRA VALUES ('{pm.MaMuonTra}','{pm.MaDocGia}', NULL, '{DateToString(pm.NgayMuon) }', '{DateToString(pm.HanTra)}' ,  0, '{pm.TienCoc}' )";

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

        public void Update_DaXL_PM(string MaMuonTra)
        {
            string sql = $"UPDATE dbo.PHIEUMUONTRA SET DaXuLy = 1 WHERE MaMuonTra = '{MaMuonTra}'";
            Excute(sql);
        }

        #endregion

    }
}
