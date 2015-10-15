namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_PENALTY_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_PENALTY_STATUS()
        {
            WR_CHARGE_HISTORY = new HashSet<WR_CHARGE_HISTORY>();
            WR_CHARGE = new HashSet<WR_CHARGE>();
            WR_PENALTY_HISTORY = new HashSet<WR_PENALTY_HISTORY>();
            WR_PENALTIES = new HashSet<WR_PENALTIES>();
        }

        [Key]
        public byte OPS_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string OPS_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string OPS_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE_HISTORY> WR_CHARGE_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE> WR_CHARGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PENALTY_HISTORY> WR_PENALTY_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PENALTIES> WR_PENALTIES { get; set; }
    }
}
