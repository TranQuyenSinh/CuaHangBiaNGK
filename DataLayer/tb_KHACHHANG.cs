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
    
    public partial class tb_KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_KHACHHANG()
        {
            this.tb_PHIEUBANHANG = new HashSet<tb_PHIEUBANHANG>();
        }
    
        public string IDKH { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public string SODIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public Nullable<bool> DELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PHIEUBANHANG> tb_PHIEUBANHANG { get; set; }
    }
}
