using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DAO;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManager.BUS
{
    class Home_BUS : Image_BUS
    {
        Home_DAO home = new Home_DAO();
        public Int64 GetTongSach()
        {
            return home.GetTongSach();
        }
        public Int64 GetTongDG()
        {

            return home.GetTongDG();
        }
        public Int64 GetTongDS()
        {

            return home.GetTongDS();
        }
        public Int64 GetTongTL()
        {

            return home.GetTongTL();
        }
        public DataTable GetTop2Dausach()
        {

            return home.GetTop2_DSNhieuNhat();
        }
        public DataTable LoadPhieuMuon()
        {
            
            return home.LoadPhieuMuon();
        }
        public DataTable LoadPhieuTra()
        {
            return home.LoadPhieuTra();
        }
        public DataTable LoadSachMoi()
        {
            
            return home.LoadSachMoi();
        }
        public Int64 GetSachCo()
        {

            return home.GetSachCo();
        }
        public Int64 GetSachMuon()
        {
            return home.GetSachMuon();
        }
        public int GetALLSachMuon()
        {
            return home.GetALLSachMuon();
        }
        public int GetSachChuaTra()
        {
            return home.GetSachChuaTra();
        }
        public DataTable LoadSLDG()
        {

            return home.LoadSLDG();
        }
        public DataTable TimKiemTL(string _timkiem)
        {
            return home.SearchTL(_timkiem);
        }
        public DataTable TimKiemTG(string _timkiem)
        {
            return home.SearchTG(_timkiem);
        }
        public DataTable TimKiemDS(string _timkiem)
        {
            return home.SearchDS(_timkiem);
        }
        public DataTable LoadSLTL()
        {

            return home.LoadSLTL();
        }
        public DataTable LoadTienCoc()
        {

            return home.LoadTienCoc();
        }
    }
}
