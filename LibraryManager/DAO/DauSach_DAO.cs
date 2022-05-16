using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;


namespace LibraryManager.DAO
{
    class DauSach_DAO : DataProvider
    {
        public DataTable GetMaDauSach()
        {
            string sql = "SELECT MaDauSach FROM dbo.DAUSACH";
            return GetData(sql);
        }

   
        public DataTable LoadDauSach()
        {
            string sqlString = @"select * from DauSach";
            return GetData(sqlString);
        }

        public DataTable GetInfo(string MaDauSach)
        {
            string sql = $"SELECT cs.MaSach, ds.TenDauSach, tg.TenTacGia, ds.NamXuatBan, ds.MoTa FROM dbo.CUONSACH AS cs  INNER JOIN dbo.DAUSACH AS ds ON ds.MaDauSach = cs.MaDauSach INNER JOIN dbo.SANGTAC AS st ON st.MaDauSach = ds.MaDauSach INNER JOIN dbo.TACGIA AS tg ON tg.MaTacGia = st.MaTacGia WHERE cs.MaDauSach = '{MaDauSach}' GROUP BY cs.MaSach, ds.TenDauSach, tg.TenTacGia, ds.NamXuatBan, ds.MoTa";
            return GetData(sql);
        }

        public DataTable Search(string TuKhoa, string MucTimKiem)
        {
            string sql = $"EXEC TIMKIEMDAUSACH '"+TuKhoa+"','"+MucTimKiem+"'";
            return GetData(sql);
        }

        public int GetCheckMaDauSach(string Ma)
        {
            string sql = "SELECT COUNT(MaDauSach) FROM dbo.DAUSACH WHERE MaDauSach = '" + Ma + "'";
            return Int32.Parse(ExcuteRetStr(sql));
        }

        public void InsertDauSach(DauSach ds, SangTac st, XuatBan xb)
        {
            string sql = @"EXEC dbo.PROC_NHAPDAUSACH @MADAUSACH = '"+ds.MaDauSach+ "',@TENDAUSACH = N'"+ds.TenDauSach+"',@SOLUONG = "+ds.SoLuong+",@LANTAIBAN = "+ds.LanTaiBan+",@NAMXUATBAN = '"+ds.NamXuatBan+"',@GIATIEN = "+ds.GiaTien+",@MOTA = N'"+ds.MoTa+"',@MATHELOAI = '"+ds.MaTheLoai+"',@MATACGIA = '"+st.MaTacGia+"',@MANHAXUATBAN = '"+xb.MaNhaXuatBan+"'";
            Excute(sql);
        }

        public void UpdateDauSach(DauSach ds, SangTac st, XuatBan xb)
        {
            string sql = @"EXEC dbo.PROC_SUADAUSACH @MADAUSACH = '" + ds.MaDauSach + "',@TENDAUSACH = N'" + ds.TenDauSach + "',@SOLUONG = " + ds.SoLuong + ",@LANTAIBAN = " + ds.LanTaiBan + ",@NAMXUATBAN = '" + ds.NamXuatBan + "',@GIATIEN = " + ds.GiaTien + ",@MOTA = N'" + ds.MoTa + "',@MATHELOAI = '" + ds.MaTheLoai + "',@MATACGIA = '" + st.MaTacGia + "',@MANHAXUATBAN = '" + xb.MaNhaXuatBan + "'";
            Excute(sql);
        }

        public void DeleteDauSach(DauSach ds, SangTac st, XuatBan xb)
        {
            string sql = @"EXEC dbo.PROC_XOADAUSACH @MADAUSACH = '" + ds.MaDauSach + "',@MATACGIA = '" + st.MaTacGia + "',@MANHAXUATBAN = '" + xb.MaNhaXuatBan + "'";
            Excute(sql);
        }

        public DataTable LoadDauSachMini()
        {
            string sqlString = @"
select DAUSACH.MaDauSach, 
       TenDauSach, 
	   SoLuong, 
	   LanTaiBan, 
	   NamXuatBan, 
	   GiaTien, 
	   MoTa, 
	   Anh, 
	   TACGIA.MaTacGia, 
	   TenTacGia, 
	   NHAXUATBAN.MaNhaXuatBan, 
	   TenNhaXuatBan, 
	   DiaChi,
	   THELOAI.MaTheLoai,
	   TenTheLoai
from DAUSACH, TACGIA, NHAXUATBAN,SANGTAC, XUATBAN, THELOAI
where 
       DAUSACH.MaDauSach = SANGTAC.MaDauSach
       and SANGTAC.MaTacGia = TACGIA.MaTacGia
       and DAUSACH.MaDauSach = XUATBAN.MaDauSach
       and XUATBAN.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan
       and DAUSACH.MaTheLoai = THELOAI.MaTheLoai";
            return GetData(sqlString);
        }
    }
}
