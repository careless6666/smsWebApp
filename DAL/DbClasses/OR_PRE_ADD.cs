namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_PRE_ADD
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

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime OPA_CREATE { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
