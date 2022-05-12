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
            string sqlString = $"proc_thaydoi_bbvp N'" + bbvp.LyDo + "'," + bbvp.TienPhat.ToString() + ",'" + bbvp.MaViPham + "',N'" + bbvp.TinhTrangSach + "'";
            Excute(sqlString);

        }
        public void Tao_vp(ViPham vp)
        {
            string sqlString = "insert into vipham (mavipham, masach ) values ('" + vp.MaViPham + "','" + vp.MaSach + "')";
            Excute(sqlString);
        }
        /*public void vohieuhoa(string madg)
        {
            string sqlString = "  update TAIKHOAN set LoaiTK= 'vohieuhoa' where TenDangNhap = (select dg.tendangnhap from DOCGIA dg where MaDocGia = '"+madg+"')";
            Excute(sqlString);
        }*/
    }
}
/* create trigger them_bbvp on bienbanvipham after insert
  as declare @lydo nvarchar(100) , @ma char(10)
  begin 
  select @lydo = LyDo, @ma = MaDocGia from inserted
  if( select count(mavipham) from BIENBANVIPHAM where LyDo like N'%Trả sách trễ hạn%' and MaDocGia = @ma group by (MaDocGia) )>3
	update TAIKHOAN set LoaiTK= 'vohieuhoa' where TenDangNhap = (select dg.tendangnhap from DOCGIA dg where MaDocGia = @ma)
  end
*/