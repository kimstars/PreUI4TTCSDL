using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Data;
using System.Windows.Forms;


namespace LibraryManager.BUS
{
    class PhieuNhap_BUS
    {
        PhieuNhap_DAO pnDao = new PhieuNhap_DAO();
        public DataTable LoadDSPhieunhap()
        {
            return pnDao.Get_DSphieunhap();
        }
        public DataTable LoadDSPhieunhap(DateTime start, DateTime end)
        {
            return pnDao.Get_DSphieunhap(start, end);
        }
        public DataTable LoadDSPhieunhap(string keyword)
        {
            return pnDao.Get_DSphieunhap(keyword);
        }


        public DataTable Load_Thongtinsachmuon(string MaMuonTra)
        {
            return pnDao.GetThongtinSachMuon(MaMuonTra);
        }


        public string GetLastest_MaPhieuNhap()
        {
            return pnDao.GetLastest_MaPhieuNhap();
        }

        public string CreateNext_MaMT() // tạo mã phiếu mượn tự động 
        {
            string current = GetLastest_MaPhieuNhap();

            string inc = System.Text.RegularExpressions.Regex.Match(current, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string maMuon = "MT000000";
            maMuon = maMuon.Substring(0, maMuon.Length - index.Length) + index;

            return maMuon;
        }


        #region Insert Muon

        public void InsertMuon(PhieuNhap pn, List<string> dsMaSach, bool isNV)
        {
            pnDao.InsertPhieuNhap(pn, dsMaSach, isNV);
        }

        #endregion

        #region update ds phieu muon tra

        public void Update_DaXuLy(string MaMuonTra)
        {
            pnDao.Update_DaXL_PM(MaMuonTra);
        }


        #endregion

        #region inphieunhap

        public DataTable LoadTTPhieuNhap(string MaNV)
        {
            return pnDao.GetTTPM(MaNV);
        }

        public DataTable LoadTenNV(string MaNV)
        {
            return pnDao.LoadTenNV_PN(MaNV);
        }

        #endregion

    }
}

