//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace connect.model1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUONSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUONSACH()
        {
            this.THONGTINMUONTRAs = new HashSet<THONGTINMUONTRA>();
            this.BIENBANVIPHAMs = new HashSet<BIENBANVIPHAM>();
        }
    
        public string MaSach { get; set; }
        public string MaDauSach { get; set; }
        public string ViTriSach { get; set; }
        public string TinhTrangMoiCu { get; set; }
        public bool TrangThai { get; set; }
    
        public virtual DAUSACH DAUSACH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONGTINMUONTRA> THONGTINMUONTRAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENBANVIPHAM> BIENBANVIPHAMs { get; set; }
    }
}
