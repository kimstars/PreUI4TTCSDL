using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;
using System.Data.SqlClient;
namespace LibraryManager.DAO
{
    class Trasach_DAO:DataProvider
    {
        public DataTable load_trasach()
        {
            string sqlString = @"select dg.madocgia,dg.TenDocGia,pmt.MaMuonTra,Masach,NgayMuon,HanTra, Ngaytra from PHIEUMUONTRA pmt,THONGTINMUONTRA tt, docgia dg where tt.MaMuonTra =pmt.MaMuonTra and dg.madocgia = pmt.madocgia and ngaytra is null ";
            return GetData(sqlString);
        }
       
        public void Update(string masach )
        {
            string sqlString = "update THONGTINMUONTRA set Ngaytra = getdate() where masach = '"+masach +"'";
            Excute(sqlString);
            
        }
        public DataTable loadtk_madg(string madocgia)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("proc_sach_chuatra", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@madg", madocgia);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            //string sqlString = "select pmt.*, masach, ngaytra from PHIEUMUONTRA pmt, THONGTINMUONTRA tt where tt.MaMuonTra = pmt.MaMuonTra and ngaytra is null and madocgia = " + "'" + madocgia+ "'";
            // string sqlString = "proc_sach_chuatra '"+madocgia+"'";

           
        }
        public DataTable loadtk_masach(string masach)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("proc_sach_chuatra_ms", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma", masach);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        
    }
}
