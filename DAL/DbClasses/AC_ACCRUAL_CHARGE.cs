namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_ACCRUAL_CHARGE
    {
        [Key]
        public int AAC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public int WPH_ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual WR_PENALTY_HISTORY WR_PENALTY_HISTORY { get; set; }
    }
}
