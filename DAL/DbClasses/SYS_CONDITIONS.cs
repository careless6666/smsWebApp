namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_CONDITIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_CONDITIONS()
        {
            SMS_TEMPLATES_PARAMS = new HashSet<SMS_TEMPLATES_PARAMS>();
            SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS = new HashSet<SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS>();
        }

        public int ID { get; set; }

        [Required]
        public string NAME { get; set; }

        [Required]
        public string KEY_CHAR_VALUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_TEMPLATES_PARAMS> SMS_TEMPLATES_PARAMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS> SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS { get; set; }
    }
}
