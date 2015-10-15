namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_CHARGE_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_CHARGE_GROUP()
        {
            OPT_PENALTY_TYPES = new HashSet<OPT_PENALTY_TYPES>();
        }

        [Key]
        public byte OCG_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string OCG_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string OCG_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_PENALTY_TYPES> OPT_PENALTY_TYPES { get; set; }
    }
}
