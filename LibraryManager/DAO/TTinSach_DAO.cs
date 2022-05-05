using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManager.DTO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace LibraryManager.DAO
{
    class TTinSach_DAO : DataProvider
    {
        /*
        public string GetTenDauSach()
        {
            string sqlString = "SELECT TenDauSach FROM dbo.DAUSACH WHERE Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
        public string GetTacGia()
        {
            string sqlString = "SELECT TenTacGia FROM dbo.TACGIA, dbo.DAUSACH, dbo.SANGTAC WHERE dbo.DAUSACH.MaDauSach = dbo.SANGTAC.MaDauSach AND dbo.SANGTAC AND Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
        public string GetTheLoai()
        {
            string sqlString = "SELECT TenTheLoai FROM dbo.THELOAI, dbo.DAUSACH WHERE dbo.DAUSACH.MaTheLoai = dbo.THELOAI.MaTheLoai AND Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
        public string GetNamXuatBan()
        {
            string sqlString = "SELECT NamXuatBan FROM dbo.DAUSACH WHERE Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
        public string GetMoTa()
        {
            string sqlString = "SELECT MoTa FROM dbo.DAUSACH WHERE Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
        public string GetGiaSach()
        {
            string sqlString = "SELECT GiaTien FROM dbo.DAUSACH WHERE Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
        public string GetSoLuong()
        {
            string sqlString = "SELECT COUNT(MaSach) FROM dbo.CUONSACH, dbo.DAUSACH WHERE dbo.CUONSACH.MADauSach = dbo.DAUSACH.MaDauSach AND TrangThai = 0 AND Anh='" + AnhSach.Image + "'";
            return ExcuteRetStr(sqlString);
        }
        */
    }
    
}
