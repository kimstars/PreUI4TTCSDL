using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTO
{
    class TaiKhoan
    {
        
        public int id { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string LoaiTK { get; set; }

        public TaiKhoan()
        {
            TenDangNhap = MatKhau = "";
            LoaiTK = "docgia";
        }
        public TaiKhoan(string user, string pass)
        {
            TenDangNhap = user;
            MatKhau = pass;
            LoaiTK = "";
        }
    }
}
