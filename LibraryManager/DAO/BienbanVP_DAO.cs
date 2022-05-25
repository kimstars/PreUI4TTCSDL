using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManager.DAO
{
    class BienbanVP_DAO:DataProvider
    {
        //BienBanViPham bbvp = new BienBanViPham();
        public string get_ten_dg(string madocgia)
        {
            string sqlString = "select tendocgia from docgia where madocgia = '" + madocgia + "'";
            return GetString(sqlString);
        }
        public string get_ten_nv(string a)
        {
            string sqlString = "select tennhanvien from nhanvien where manhanvien = '" + a + "'";
            return GetString(sqlString);
        }
        public string Get_MaVP()
        {
            string sqlString = "select top(1) mavipham from VIPHAM order by mavipham)";
            return GetString(sqlString);
        }
        public string Get_sl_MaVP()
        {
            string sqlString = "select count(mavipham) from vipham ";
            return GetCount(sqlString).ToString();
        }
        public DataTable loadManv()
        {
            string sqlString = "select manhanvien from nhanvien";
            return GetData(sqlString);
        }
        public void insert(BienBanViPham bbvp)
        {
            string sqlString = "insert into bienbanvipham values ('"+bbvp.MaViPham+"','"+bbvp.MaDocGia+"',N'"+bbvp.MaNhanVien+"','"+bbvp.LyDo+"',"+bbvp.TienPhat+",N'"+bbvp.TinhTrangSach+"')";
            Excute(sqlString);
        }
        public void sua(BienBanViPham bbvp)
        {

            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("proc_thaydoi_bbvp", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lido", bbvp.LyDo);
                cmd.Parameters.AddWithValue("@tien", bbvp.TienPhat);
                cmd.Parameters.AddWithValue("@mavp", bbvp.MaViPham);
                cmd.Parameters.AddWithValue("@tinhtrang", bbvp.TinhTrangSach);

                rd = cmd.ExecuteReader();
                dt.Load(rd);
               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            //string sqlString = $"proc_thaydoi_bbvp N'" + bbvp.LyDo + "'," + bbvp.TienPhat.ToString() + ",'" + bbvp.MaViPham + "',N'" + bbvp.TinhTrangSach + "'";
           // Excute(sqlString);

        }
        public void Tao_vp(ViPham vp)
        {
            string sqlString = "insert into vipham (mavipham, masach ) values ('" + vp.MaViPham + "','" + vp.MaSach + "')";
            Excute(sqlString);
        }
        // lấy ra tên cuốn sách từ mã cuốn sách
        public string GetTensach(string masach)
        {
            string sqlString = "select tendausach from cuonsach cs, dausach ds where ds.madausach = cs.madausach and cs.masach='" + masach + "'";
            return GetString(sqlString);
        }


    }
}
