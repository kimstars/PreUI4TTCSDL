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
    class TacGia_BUS
    {
        TacGia_DAO tgDao = new TacGia_DAO();
        public DataTable LoadTenTacGia()
        {
            return tgDao.GetTenTacGia();
        }


        public DataTable LoadListTG()
        {
            return tgDao.LoadTacGia();
        }

        public void ThemThongtinNhap(TacGia tg)
        {
            tgDao.InsertTacGia(tg);
        }
        public void Update(string MaTacGia, string TenTacGia)
        {
            tgDao.UpdateTacGia(MaTacGia,TenTacGia);
        }

        public void Delete(TacGia tg)
        {
            tgDao.DeleteTacGia(tg);
        }
    }
}
