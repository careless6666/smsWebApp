namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_SHIFTS_BEFORE_PAY
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WRG_ID { get; set; }

        public int SHIFTS_COUNT { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual WR_GROUPS WR_GROUPS { get; set; }
    }
}
