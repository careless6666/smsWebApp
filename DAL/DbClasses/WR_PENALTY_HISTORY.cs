namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PENALTY_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_PENALTY_HISTORY()
        {
            AC_ACCRUAL_CHARGE = new HashSet<AC_ACCRUAL_CHARGE>();
        }

        [Key]
        public int WPH_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PEN_ID { get; set; }

        public byte OPS_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime WPH_DATETIME { get; set; }

        [StringLength(160)]
        public string WPH_COMMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_CHARGE> AC_ACCRUAL_CHARGE { get; set; }

        public virtual OPT_PENALTY_STATUS OPT_PENALTY_STATUS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_PENALTIES WR_PENALTIES { get; set; }
    }
}
