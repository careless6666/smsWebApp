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
    
    public partial class SMS_RECEIVE_REQUESTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMS_RECEIVE_REQUESTS()
        {
            this.SMS_RECEIVED_MSG = new HashSet<SMS_RECEIVED_MSG>();
        }
    
        public decimal SR_ID { get; set; }
        public bool SR_PROCESSED { get; set; }
        public bool RECENTLY_ADDED { get; set; }
        public decimal SR_COUNT { get; set; }
        public decimal SR_REMAINS { get; set; }
        public decimal SR_RESPONSE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_RECEIVED_MSG> SMS_RECEIVED_MSG { get; set; }
    }
}
