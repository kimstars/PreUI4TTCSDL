using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using LibraryManager.DTO;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManager.BUS
{
    class HomeHello_BUS : Image_BUS
    {
        HomeHello_DAO hello = new HomeHello_DAO();
        public String GetTongSach()
        {
            return hello.GetTongSach();
        }
        public String GetTongDG()
        {
            
            return hello.GetTongDG();
        }
        public String GetTongDS()
        {
            
            return hello.GetTongDS();
        }
        public String GetTongTL()
        {
            
            return hello.GetTongTL();
        }
        public DataTable Get2Anh()
        {
            
            return hello.Get2Anh();
        }
    }
}
