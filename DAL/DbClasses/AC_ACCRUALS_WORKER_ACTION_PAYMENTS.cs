namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_ACCRUALS_WORKER_ACTION_PAYMENTS
    {
        [Key]
        public int AAWAP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public int WWAPH_ID { get; set; }

        public virtual WR_WORKER_ACTION_PAYMENTS_HISTORY WR_WORKER_ACTION_PAYMENTS_HISTORY { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }
    }
}
