namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_MIN_RESTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WRG_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_REST { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual WR_GROUPS WR_GROUPS { get; set; }
    }
}
