//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FIRE_MACHINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIRE_MACHINE()
        {
            this.FIRE_MACHINE_HISTORY = new HashSet<FIRE_MACHINE_HISTORY>();
        }
    
        public decimal FM_ID { get; set; }
        public decimal UN_ID { get; set; }
        public decimal WR_ID { get; set; }
        public System.DateTime DATE { get; set; }
        public bool IS_ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIRE_MACHINE_HISTORY> FIRE_MACHINE_HISTORY { get; set; }
        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
