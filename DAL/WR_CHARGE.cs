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
    
    public partial class WR_CHARGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_CHARGE()
        {
            this.WR_CHARGE_HISTORY = new HashSet<WR_CHARGE_HISTORY>();
        }
    
        public int WRC_ID { get; set; }
        public decimal UN_ID { get; set; }
        public decimal WR_ID { get; set; }
        public decimal CHARGE_ID { get; set; }
        public byte WRC_IS_CONFIRMED { get; set; }
        public decimal WRC_PRICE { get; set; }
    
        public virtual OPT_PENALTY_STATUS OPT_PENALTY_STATUS { get; set; }
        public virtual OPT_PENALTY_TYPES OPT_PENALTY_TYPES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE_HISTORY> WR_CHARGE_HISTORY { get; set; }
        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
