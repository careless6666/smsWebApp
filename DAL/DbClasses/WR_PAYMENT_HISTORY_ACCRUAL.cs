namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PAYMENT_HISTORY_ACCRUAL
    {
        [Key]
        public int ACCA_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public int? PH_ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual WR_PAYMENT_HISTORY WR_PAYMENT_HISTORY { get; set; }
    }
}
