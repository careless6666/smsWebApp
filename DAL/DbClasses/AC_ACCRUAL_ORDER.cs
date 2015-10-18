namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_ACCRUAL_ORDER
    {
        [Key]
        public int ACCRUAL_ORDER_ID { get; set; }

        public int OOWH_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual OR_ORDER_WORKER_HISTORY OR_ORDER_WORKER_HISTORY { get; set; }
    }
}
