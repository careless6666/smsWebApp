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
    
    public partial class OPT_PENALTY_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_PENALTY_STATUS()
        {
            this.WR_CHARGE_HISTORY = new HashSet<WR_CHARGE_HISTORY>();
            this.WR_CHARGE = new HashSet<WR_CHARGE>();
            this.WR_PENALTY_HISTORY = new HashSet<WR_PENALTY_HISTORY>();
            this.WR_PENALTIES = new HashSet<WR_PENALTIES>();
        }
    
        public byte OPS_ID { get; set; }
        public string OPS_NAME { get; set; }
        public string OPS_KEYCHAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE_HISTORY> WR_CHARGE_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE> WR_CHARGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PENALTY_HISTORY> WR_PENALTY_HISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PENALTIES> WR_PENALTIES { get; set; }
    }
}
