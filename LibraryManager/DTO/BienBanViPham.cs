using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTO
{
    class BienBanViPham
    {
       // public int id { get; set; }
        public string MaViPham { get; set; }
        public string MaDocGia { get; set; }
        public string MaNhanVien { get; set; }
        public string LyDo { get; set; }
        public Nullable<long> TienPhat { get; set; }
        public string TinhTrangSach { get; set; }
    }
}
