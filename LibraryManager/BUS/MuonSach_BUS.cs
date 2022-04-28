using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Windows.Forms;
using System.Data;

namespace LibraryManager.BUS
{
    class MuonSach_BUS 
    {
        MuonSach_DAO msDao = new MuonSach_DAO();
        public DataTable LoadData()
        {
            return msDao.LoadPhieuMuon();
        }


        public bool ThemTTMuonTra(PhieuMuonTra pm, ThongTinMuonTra ttmt)
        {
            return msDao.InsertPhieuMuon(pm) && msDao.InsertThongTinMT(ttmt);
        }


    }
}
