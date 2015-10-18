namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMS_RECEIVE_REQUESTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMS_RECEIVE_REQUESTS()
        {
            SMS_RECEIVED_MSG = new HashSet<SMS_RECEIVED_MSG>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal SR_ID { get; set; }

        public bool SR_PROCESSED { get; set; }

        public bool RECENTLY_ADDED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SR_COUNT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SR_REMAINS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SR_RESPONSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_RECEIVED_MSG> SMS_RECEIVED_MSG { get; set; }
    }
}
