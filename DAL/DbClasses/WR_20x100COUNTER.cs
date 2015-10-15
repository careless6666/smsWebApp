namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_20x100COUNTER
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte BONUS_COUNTER { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
