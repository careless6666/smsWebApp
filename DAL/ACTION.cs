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
    
    public partial class ACTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTION()
        {
            this.ACTION_PAYMENTS_HISTORY = new HashSet<ACTION_PAYMENTS_HISTORY>();
        }
    
        public int ID { get; set; }
        public decimal UN_ID { get; set; }
        public System.DateTime DATE_START { get; set; }
        public System.DateTime DATE_END { get; set; }
        public int RPH_BONUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTION_PAYMENTS_HISTORY> ACTION_PAYMENTS_HISTORY { get; set; }
    }
}
