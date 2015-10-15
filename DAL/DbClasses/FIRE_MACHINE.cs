namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRE_MACHINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIRE_MACHINE()
        {
            FIRE_MACHINE_HISTORY = new HashSet<FIRE_MACHINE_HISTORY>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal FM_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public DateTime DATE { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIRE_MACHINE_HISTORY> FIRE_MACHINE_HISTORY { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
