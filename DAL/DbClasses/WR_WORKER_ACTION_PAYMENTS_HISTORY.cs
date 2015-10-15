namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_ACTION_PAYMENTS_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_WORKER_ACTION_PAYMENTS_HISTORY()
        {
            AC_ACCRUALS_WORKER_ACTION_PAYMENTS = new HashSet<AC_ACCRUALS_WORKER_ACTION_PAYMENTS>();
        }

        [Key]
        public int WWAPH_ID { get; set; }

        public int WWAP_ID { get; set; }

        public int US_ID { get; set; }

        public double WWAPH_SUM { get; set; }

        public DateTime WWAPH_DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUALS_WORKER_ACTION_PAYMENTS> AC_ACCRUALS_WORKER_ACTION_PAYMENTS { get; set; }

        public virtual WR_WORKER_ACTION_PAYMENTS WR_WORKER_ACTION_PAYMENTS { get; set; }
    }
}
