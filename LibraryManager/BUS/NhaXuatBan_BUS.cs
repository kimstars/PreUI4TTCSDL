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
    class NhaXuatBan_BUS
    {
        NhaXuatBan_DAO nxbDao = new NhaXuatBan_DAO();
        public DataTable LoadTenNXB()
        {
            return nxbDao.GetTenNXB();
        }

        public DataTable LoadListNXB()
        {
            return nxbDao.LoadNhaXuatBan();
        }

        public void ThemThongtinNhap(NhaXuatBan nxb)
        {
            nxbDao.InsertNhaXuatBan(nxb);
        }

        public void Update(string MaNhaXuatBan, string TenNhaXuatBan, string DiaChi)
        {
            nxbDao.UpdateNhaXuatBan(MaNhaXuatBan, TenNhaXuatBan, DiaChi);
        }

        public void Delete(NhaXuatBan nxb)
        {
            nxbDao.DeleteNhaXuatBan(nxb);
        }

    }
}
