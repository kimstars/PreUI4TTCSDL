﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;
namespace LibraryManager.DAO
{
    class Trasach_DAO:DataProvider
    {
        public DataTable load_trasach()
        {
            string sqlString = "select pmt.*, masach, ngaytra from PHIEUMUONTRA pmt,THONGTINMUONTRA tt where tt.MaMuonTra =pmt.MaMuonTra and ngaytra is null";
            return GetData(sqlString);
        }
        public void update(ThongTinMuonTra ttmt)
        {
            string sqlString = string.Format("update THONGTINMUONTRA, phieumuontra set Ngaytra = getdate() where masach = '{0}' and madocgia ='{1}'",ttmt.MaSach, ttmt.Ma;
            
        }
        public DataTable loadtk_madg(string a)
        {
            string sqlString = $@"select pmt.*, masach, ngaytra from PHIEUMUONTRA pmt,THONGTINMUONTRA tt where tt.MaMuonTra =pmt.MaMuonTra and ngaytqra is null and pmt.madocgia = {a} ";
            return GetData(sqlString);
        }
        public DataTable loadtk_masach(string a)
        {
            string sqlString = $@"select pmt.*, masach, ngaytra from PHIEUMUONTRA pmt,THONGTINMUONTRA tt where tt.MaMuonTra =pmt.MaMuonTra and ngaytqra is null and pmt.masach = {a} ";
            return GetData(sqlString);
        }
    }
}
