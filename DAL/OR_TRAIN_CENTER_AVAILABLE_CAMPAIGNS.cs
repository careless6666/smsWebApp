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
    
    public partial class OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS()
        {
            this.OR_TRAIN_CENTER_WORKERS_CAMPAIGN = new HashSet<OR_TRAIN_CENTER_WORKERS_CAMPAIGN>();
        }
    
        public decimal CGN_ID { get; set; }
        public decimal ORTC_WORKERS_MAX { get; set; }
    
        public virtual CGN_CAMPAIGN CGN_CAMPAIGN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_TRAIN_CENTER_WORKERS_CAMPAIGN> OR_TRAIN_CENTER_WORKERS_CAMPAIGN { get; set; }
    }
}
