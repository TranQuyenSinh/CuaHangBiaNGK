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
    
    public partial class tb_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_USER()
        {
            this.tb_LOG = new HashSet<tb_LOG>();
            this.tb_PHIEUBANHANG = new HashSet<tb_PHIEUBANHANG>();
            this.tb_PHIEUNHAPHANG = new HashSet<tb_PHIEUNHAPHANG>();
        }
    
        public int IDUSER { get; set; }
        public string TENDAYDU { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> IDNHOM { get; set; }
        public Nullable<bool> DELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_LOG> tb_LOG { get; set; }
        public virtual tb_NHOM tb_NHOM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PHIEUBANHANG> tb_PHIEUBANHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PHIEUNHAPHANG> tb_PHIEUNHAPHANG { get; set; }
    }
}
