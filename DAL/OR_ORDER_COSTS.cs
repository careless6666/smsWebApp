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
    
    public partial class OR_ORDER_COSTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_ORDER_COSTS()
        {
            this.OR_ORDER_COSTS_HISTORY = new HashSet<OR_ORDER_COSTS_HISTORY>();
        }
    
        public decimal OR_ID { get; set; }
        public decimal ORC_COST { get; set; }
        public int ORC_ID { get; set; }
    
        public virtual OR_ORDER OR_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_COSTS_HISTORY> OR_ORDER_COSTS_HISTORY { get; set; }
    }
}
