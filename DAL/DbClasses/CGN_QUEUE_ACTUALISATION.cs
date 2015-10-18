namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_QUEUE_ACTUALISATION
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CGNQA_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CGN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGNQA_STAGE { get; set; }

        public DateTime CGNQA_STARTED_TIME { get; set; }

        public DateTime CGNQA_DONE_TIME { get; set; }

        public bool CGNQA_DONE { get; set; }

        public bool CGNQA_STAFFED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGNQUAP_POOL_ID { get; set; }

        public virtual CGN_CAMPAIGN CGN_CAMPAIGN { get; set; }
    }
}
