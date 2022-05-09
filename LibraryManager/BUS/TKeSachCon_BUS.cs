using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LibraryManager.BUS
{
    
    class TKeSachCon_BUS
    {
        TKeSachCon_DAO sach = new TKeSachCon_DAO();
        public string GetSachCon()
        {
            return sach.GetSachCon();
        }
    }
}
