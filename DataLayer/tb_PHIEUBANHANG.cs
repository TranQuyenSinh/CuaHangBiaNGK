//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_PHIEUBANHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_PHIEUBANHANG()
        {
            this.tb_CHITIET_PHIEUBANHANG = new HashSet<tb_CHITIET_PHIEUBANHANG>();
        }
    
        public string IDPB { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<int> IDUSER { get; set; }
        public Nullable<double> PHIVANCHUYEN { get; set; }
        public string GHICHU { get; set; }
        public string IDKH { get; set; }
        public Nullable<double> TONGTIEN { get; set; }
        public Nullable<double> DATRA { get; set; }
        public Nullable<bool> GIASI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CHITIET_PHIEUBANHANG> tb_CHITIET_PHIEUBANHANG { get; set; }
        public virtual tb_KHACHHANG tb_KHACHHANG { get; set; }
        public virtual tb_USER tb_USER { get; set; }
    }
}
