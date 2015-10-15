namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_ACTION_STOKMANN_2012
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal WAT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FUN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WABF_SUM { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS1 { get; set; }
    }
}
