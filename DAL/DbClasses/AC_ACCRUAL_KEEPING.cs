namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_ACCRUAL_KEEPING
    {
        [Key]
        public int AAK_ID { get; set; }

        public int WKH_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual WR_KEEPING_HISTORY WR_KEEPING_HISTORY { get; set; }
    }
}
