namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_CHARGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_CHARGE()
        {
            WR_CHARGE_HISTORY = new HashSet<WR_CHARGE_HISTORY>();
        }

        [Key]
        public int WRC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CHARGE_ID { get; set; }

        public byte WRC_IS_CONFIRMED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRC_PRICE { get; set; }

        public virtual OPT_PENALTY_STATUS OPT_PENALTY_STATUS { get; set; }

        public virtual OPT_PENALTY_TYPES OPT_PENALTY_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE_HISTORY> WR_CHARGE_HISTORY { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
