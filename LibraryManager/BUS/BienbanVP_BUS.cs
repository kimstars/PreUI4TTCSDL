using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DAO;
using System.Data;
using LibraryManager.DTO;
namespace LibraryManager.BUS
{
    class BienbanVP_BUS
    {
        BienbanVP_DAO bbvp_dao = new BienbanVP_DAO();
        public string Get_tendg(string a)
        {
            return bbvp_dao.get_ten_dg(a);
        }
        public string Get_tennv(string a)
        {
            return bbvp_dao.get_ten_nv(a);
        }
        public int Get_slVP()
        {
            return int.Parse(bbvp_dao.Get_sl_MaVP());
        }
        public DataTable getManv()
        {
            return bbvp_dao.loadManv();
        }
        public void insertBB(BienBanViPham bbvp)
        {
            bbvp_dao.insert(bbvp);
        }
        public void suabb(BienBanViPham bbvp)
        {
            bbvp_dao.sua(bbvp);
        }
        public void Them_vp(ViPham vp)
        {
            bbvp_dao.Tao_vp(vp);
        }
       /* public void update_loaiTK(string madg)
        {
            bbvp_dao.vohieuhoa(madg);
        }*/
       public string get_tensach(string masach)
        {
            return bbvp_dao.GetTensach(masach);
        }
        public DataTable getMadg()
        {
            return bbvp_dao.loadMaDg();
        }
        public DataTable getMasach(string madg)
        {
            return bbvp_dao.loadMaSach(madg);
        }
        public Int64 TienPhat(string masach)
        {
            return bbvp_dao.Get_Money(masach);
        }
        public Int64 Songaytre(string masach)
        {
            return bbvp_dao.soluongngay(masach);
        }
        public void update0(string masach)
        {
            bbvp_dao.update__ngaytra_0_BBVP(masach);
        }
        public void update1(string masach)
        {
            bbvp_dao.update__ngaytra_1_BBVP(masach);
        }

        public DataTable RP_GetDSVP(string MaVP)
        {
            return bbvp_dao.GetTT_BBVP(MaVP);
        }
        
        public DataTable RP_GetThongtin_BB(string MaVP)
        {
            return bbvp_dao.RP_ThongtinVP(MaVP);
        }


        public string GetLastest_MaVP()
        {
            return bbvp_dao.GetLastest_MaVP();
        }


        public string CreateNext_MaVP()
        {
            string current = GetLastest_MaVP();

            string inc = System.Text.RegularExpressions.Regex.Match(current, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string maMuon = "VP000000";
            maMuon = maMuon.Substring(0, maMuon.Length - index.Length) + index;

            return maMuon;
        }
    }
}

