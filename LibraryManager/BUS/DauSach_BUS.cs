using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;

namespace LibraryManager.BUS
{
    class DauSach_BUS
    {
        DauSach_DAO dsDao = new DauSach_DAO();

        public DataTable LoadMaDauSach()
        {
            return dsDao.GetMaDauSach();
        }

        public DataTable LoadListDS()
        {
            return dsDao.LoadDauSach();
        }
    }
}
