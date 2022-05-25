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
    }
}

