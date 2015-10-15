namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_FIELDS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_FIELDS()
        {
            SMS_TEMPLATES_PARAMS = new HashSet<SMS_TEMPLATES_PARAMS>();
        }

        public int ID { get; set; }

        [Required]
        public string NAME { get; set; }

        [Required]
        public string KEY_CHAR_VALUE { get; set; }

        public string DESCRIPTION { get; set; }

        public int ID_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_TEMPLATES_PARAMS> SMS_TEMPLATES_PARAMS { get; set; }

        public virtual SYS_FIELDS_TYPES SYS_FIELDS_TYPES { get; set; }
    }
}
