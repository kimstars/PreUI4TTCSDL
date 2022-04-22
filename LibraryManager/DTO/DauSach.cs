using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTO
{
    class DauSach
    {
        public int id { get; set; }
        public string MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public int SoLuong { get; set; }
        public Nullable<int> LanTaiBan { get; set; }
        public string NamXuatBan { get; set; }
        public long GiaTien { get; set; }
        public string MoTa { get; set; }
        public string MaTheLoai { get; set; }
    }
}
