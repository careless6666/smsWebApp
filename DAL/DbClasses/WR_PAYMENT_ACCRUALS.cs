namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PAYMENT_ACCRUALS
    {
        public int ID { get; set; }

        public int CALC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual WR_PAYMENT WR_PAYMENT { get; set; }
    }
}
