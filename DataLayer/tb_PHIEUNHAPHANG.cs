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
    
    public partial class tb_PHIEUNHAPHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_PHIEUNHAPHANG()
        {
            this.tb_CHITIET_PHIEUNHAPHANG = new HashSet<tb_CHITIET_PHIEUNHAPHANG>();
        }
    
        public string IDPN { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<double> PHIVANCHUYEN { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> IDNCC { get; set; }
        public Nullable<double> TONGTIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CHITIET_PHIEUNHAPHANG> tb_CHITIET_PHIEUNHAPHANG { get; set; }
        public virtual tb_NHACUNGCAP tb_NHACUNGCAP { get; set; }
    }
}
