using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTO
{
    class DocGia
    {
        public int id { get; set; }
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string DiaChi { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public System.DateTime NgayDangKi { get; set; }
        public string TenDangNhap { get; set; }
    }
}
