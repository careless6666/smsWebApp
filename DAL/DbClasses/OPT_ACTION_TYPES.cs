namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_ACTION_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_ACTION_TYPES()
        {
            ACT_ACTIONS = new HashSet<ACT_ACTIONS>();
        }

        [Key]
        public int OAT_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string OAT_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string KEY_CHAR_VAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACT_ACTIONS> ACT_ACTIONS { get; set; }
    }
}
