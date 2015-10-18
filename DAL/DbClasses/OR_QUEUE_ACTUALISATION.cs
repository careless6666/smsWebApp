namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_QUEUE_ACTUALISATION
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ORQA_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORQA_STAGE { get; set; }

        public DateTime ORQA_STARTED_TIME { get; set; }

        public DateTime ORQA_DONE_TIME { get; set; }

        public bool ORQA_DONE { get; set; }

        public bool ORQA_STAFFED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORQUAP_POOL_ID { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }
    }
}
