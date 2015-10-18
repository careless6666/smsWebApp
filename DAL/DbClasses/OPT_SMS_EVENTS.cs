namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_SMS_EVENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_SMS_EVENTS()
        {
            OPT_SMS_EVENTS_VARIABLES = new HashSet<OPT_SMS_EVENTS_VARIABLES>();
            SMS_TEMPLATES = new HashSet<SMS_TEMPLATES>();
        }

        public int ID { get; set; }

        [Required]
        public string NAME { get; set; }

        [Required]
        public string KEY_CHAR_VALUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_SMS_EVENTS_VARIABLES> OPT_SMS_EVENTS_VARIABLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_TEMPLATES> SMS_TEMPLATES { get; set; }
    }
}