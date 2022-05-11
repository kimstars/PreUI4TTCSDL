using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;
namespace LibraryManager.DAO
{
    class Trasach_DAO:DataProvider
    {
        public DataTable load_trasach()
        {
            string sqlString = @"select pmt.*, masach, ngaytra from PHIEUMUONTRA pmt,THONGTINMUONTRA tt where tt.MaMuonTra =pmt.MaMuonTra and ngaytra is null ";
            return GetData(sqlString);
        }
       
        public void Update(string masach )
        {
            string sqlString = "update THONGTINMUONTRA set Ngaytra = getdate() where masach = '"+masach +"'";
            Excute(sqlString);
            
        }
        public DataTable loadtk_madg(string madocgia)
        {
            string sqlString = "select pmt.*, masach, ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt where tt.MaMuonTra = pmt.MaMuonTra and ngaytra is null and madocgia = " + "'" + madocgia+ "'";
            // string sqlString = "proc_sach_chuatra '"+madocgia+"'";
            return GetData(sqlString);
        }
        public DataTable loadtk_masach(string masach)
        {
            string d = "select pmt.*, masach, ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt where tt.MaMuonTra = pmt.MaMuonTra and ngaytra is null and tt.masach = " + "'" + masach + "'";
            
            return GetData(d);
        }
        
    }
}
