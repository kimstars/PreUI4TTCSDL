using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DTO
{
    class ThongTinMuonTra
    {
        public int id { get; set; }
        public string MaMuonTra { get; set; }
        public string MaSach { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }

    }
}
