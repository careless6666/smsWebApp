namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_ACTION_15x15
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal WR_FRIEND_UN_ID { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal WR_FRIEND_WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_SUM { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS1 { get; set; }
    }
}
