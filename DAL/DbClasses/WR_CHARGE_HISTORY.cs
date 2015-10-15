namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_CHARGE_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_CHARGE_HISTORY()
        {
            AC_ACCRUAL_WR_CHARGE = new HashSet<AC_ACCRUAL_WR_CHARGE>();
        }

        [Key]
        public int WCH_ID { get; set; }

        public int WRC_ID { get; set; }

        public byte OPS_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime WCH_DATETIME { get; set; }

        [Required]
        [StringLength(250)]
        public string WCH_COMMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_WR_CHARGE> AC_ACCRUAL_WR_CHARGE { get; set; }

        public virtual OPT_PENALTY_STATUS OPT_PENALTY_STATUS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_CHARGE WR_CHARGE { get; set; }
    }
}
