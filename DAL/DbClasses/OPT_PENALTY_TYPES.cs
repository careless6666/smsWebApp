namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_PENALTY_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_PENALTY_TYPES()
        {
            OPT_LATERS = new HashSet<OPT_LATERS>();
            OPT_REGIONAL_PENALTY_COSTS = new HashSet<OPT_REGIONAL_PENALTY_COSTS>();
            WR_CHARGE = new HashSet<WR_CHARGE>();
            OPT_RELATIONSHIP_PENALTY_TYPES = new HashSet<OPT_RELATIONSHIP_PENALTY_TYPES>();
            OPT_RELATIONSHIP_PENALTY_TYPES1 = new HashSet<OPT_RELATIONSHIP_PENALTY_TYPES>();
            WR_PENALTIES = new HashSet<WR_PENALTIES>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal PEN_TYPE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string WR_NAME { get; set; }

        public byte OCG_ID { get; set; }

        public virtual OPT_CHARGE_GROUP OPT_CHARGE_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_LATERS> OPT_LATERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_REGIONAL_PENALTY_COSTS> OPT_REGIONAL_PENALTY_COSTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE> WR_CHARGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_RELATIONSHIP_PENALTY_TYPES> OPT_RELATIONSHIP_PENALTY_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_RELATIONSHIP_PENALTY_TYPES> OPT_RELATIONSHIP_PENALTY_TYPES1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PENALTIES> WR_PENALTIES { get; set; }
    }
}
