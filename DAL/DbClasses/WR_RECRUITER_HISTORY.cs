namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_RECRUITER_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_RECRUITER_HISTORY()
        {
            AC_ACCRUAL_RECRUITER = new HashSet<AC_ACCRUAL_RECRUITER>();
        }

        [Key]
        public int WRRH_ID { get; set; }

        public int WRRP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        public decimal WRRH_AMOUNT { get; set; }

        public DateTime WRRH_DATETIME { get; set; }

        public bool WRRH_IS_PLUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_RECRUITER> AC_ACCRUAL_RECRUITER { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual WR_RECRUITER_PERIOD WR_RECRUITER_PERIOD { get; set; }
    }
}
