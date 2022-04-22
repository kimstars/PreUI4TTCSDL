using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTO
{
    class PhieuMuonTra
    {
        public int id { get; set; }
        public string MaMuonTra { get; set; }
        public string MaDocGia { get; set; }
        public string MaNhanVien { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public System.DateTime HanTra { get; set; }

    }
}
