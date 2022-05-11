using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.DTO;
using System.Data;
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
            string sqlString = "select count(mavipham) from vipham group by mavipham";
            return GetCount(sqlString).ToString();
        }
        public DataTable loadManv()
        {
            string sqlString = "select manhanvien from nhanvien";
            return GetData(sqlString);
        }
        public void insert(BienBanViPham bbvp)
        {
            string sqlString = "insert into bienbanvipham values ('"+bbvp.MaViPham+"','"+bbvp.MaDocGia+"','"+bbvp.MaNhanVien+"','"+bbvp.LyDo+"',"+bbvp.TienPhat+",'"+bbvp.TinhTrangSach+"')";
            Excute(sqlString);
        }
        public void sua(BienBanViPham bbvp)
        {
            string sqlString = $"proc_thaydoi_bbvp N'" + bbvp.LyDo + "'," + bbvp.TienPhat.ToString() + ",'" + bbvp.MaViPham + "',N'" + bbvp.TinhTrangSach + "'";
            Excute(sqlString);

        }
        public void Tao_vp(ViPham vp)
        {
            string sqlString = "insert into vipham (mavipham, masach ) values ('" + vp.MaViPham + "','" + vp.MaSach + "')";
            Excute(sqlString);
        }
        public void vohieuhoa(string madg)
        {
            string sqlString = "update taikhoan set loaiTK = N'Vô hiệu hóa' where tendangnhap = (select tendangnhap from docgia where madocgia = '" + madg + "'";
            Excute(sqlString);
        }
    }
}
