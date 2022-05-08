using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Data;


namespace LibraryManager.BUS
{
    class PhieuMuon_BUS
    {
        PhieuMuon_DAO pmDao = new PhieuMuon_DAO();
        public DataTable LoadDSPhieumuon()
        {
            return pmDao.Get_DSphieumuon();
        }
        public DataTable LoadDSPhieumuon(DateTime start, DateTime end)
        {
            return pmDao.Get_DSphieumuon(start,end);
        }
        public DataTable LoadDSPhieumuon(string keyword)
        {
            return pmDao.Get_DSphieumuon(keyword);
        }


        public DataTable Load_Thongtinsachmuon(string MaMuonTra)
        {
            return pmDao.GetThongtinSachMuon(MaMuonTra);
        }

    }
}

