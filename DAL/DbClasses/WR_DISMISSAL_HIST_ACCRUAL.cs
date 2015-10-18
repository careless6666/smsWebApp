namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_DISMISSAL_HIST_ACCRUAL
    {
        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public int HI_ID { get; set; }

        public int ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual WR_DISMISSAL_ITEMS_HISTORY WR_DISMISSAL_ITEMS_HISTORY { get; set; }
    }
}
