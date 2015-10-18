namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PENALTIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_PENALTIES()
        {
            WR_PENALTY_HISTORY = new HashSet<WR_PENALTY_HISTORY>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal PEN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_PENALTY_TYPE { get; set; }

        public byte WRP_IS_CONFIRMED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRP_PRICE { get; set; }

        public virtual OPT_PENALTY_STATUS OPT_PENALTY_STATUS { get; set; }

        public virtual OPT_PENALTY_TYPES OPT_PENALTY_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PENALTY_HISTORY> WR_PENALTY_HISTORY { get; set; }
    }
}
