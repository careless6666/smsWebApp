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
    
    public partial class CL_RATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_RATE()
        {
            this.OR_ORDER_WORKER_HISTORY = new HashSet<OR_ORDER_WORKER_HISTORY>();
        }
    
        public int CR_ID { get; set; }
        public decimal CL_ID { get; set; }
        public int CCI_ID { get; set; }
        public System.DateTime CR_DATE_FROM { get; set; }
        public System.DateTime CR_DATE_TO { get; set; }
        public bool IS_MISTAKEN { get; set; }
    
        public virtual CL_CLIENTS CL_CLIENTS { get; set; }
        public virtual CL_CONTRACT_ITEM CL_CONTRACT_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKER_HISTORY> OR_ORDER_WORKER_HISTORY { get; set; }
    }
}
