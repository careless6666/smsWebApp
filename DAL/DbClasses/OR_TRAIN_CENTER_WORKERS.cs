namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_TRAIN_CENTER_WORKERS
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

        public virtual OR_ORDER_WORKERS OR_ORDER_WORKERS { get; set; }

        public virtual OR_TRAIN_CENTER_AVAILABLE OR_TRAIN_CENTER_AVAILABLE { get; set; }
    }
}
