namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMS_SEND_CONDITIONS_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMS_SEND_CONDITIONS_TYPES()
        {
            SMS_SEND_CONDITIONS_PARAMS = new HashSet<SMS_SEND_CONDITIONS_PARAMS>();
        }

        public int ID { get; set; }

        [Required]
        public string NAME { get; set; }

        [Required]
        public string KEY_CHAR_VALUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_SEND_CONDITIONS_PARAMS> SMS_SEND_CONDITIONS_PARAMS { get; set; }
    }
}
