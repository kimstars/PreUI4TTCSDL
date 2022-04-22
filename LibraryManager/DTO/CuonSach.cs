using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTO
{
    class CuonSach
    {
        public int id { get; set; }
        public string MaSach { get; set; }
        public string MaDauSach { get; set; }
        public string ViTriSach { get; set; }
        public string TinhTrangMoiCu { get; set; }
        public bool TrangThai { get; set; }
    }
}
