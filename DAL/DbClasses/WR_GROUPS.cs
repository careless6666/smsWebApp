namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_GROUPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_GROUPS()
        {
            ACT_ACTIONS = new HashSet<ACT_ACTIONS>();
            OPT_SHIFTS_BEFORE_PAY = new HashSet<OPT_SHIFTS_BEFORE_PAY>();
            WR_MIN_RESTS = new HashSet<WR_MIN_RESTS>();
            WR_WAGES = new HashSet<WR_WAGES>();
            WR_WORKERS = new HashSet<WR_WORKERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal WRG_ID { get; set; }

        [Required]
        [StringLength(120)]
        public string WRG_NAME { get; set; }

        public bool? WRG_IS_DEFAULT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACT_ACTIONS> ACT_ACTIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_SHIFTS_BEFORE_PAY> OPT_SHIFTS_BEFORE_PAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_MIN_RESTS> WR_MIN_RESTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WAGES> WR_WAGES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKERS> WR_WORKERS { get; set; }
    }
}
