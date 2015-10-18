namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_CAMPAIGN_WORKERS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CGN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public bool CGNW_COMPLETE { get; set; }

        public bool CGNW_RECALL { get; set; }

        public DateTime CGNW_COMPLETE_TIME { get; set; }

        public virtual OR_TRAIN_CENTER_WORKERS_CAMPAIGN OR_TRAIN_CENTER_WORKERS_CAMPAIGN { get; set; }
    }
}
