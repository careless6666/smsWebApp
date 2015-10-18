namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_ACTION_BRING_FRIEND
    {
        [Key]
        public int WWABF_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FRIEND_UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FRIEND_WR_ID { get; set; }

        public int WWAP_ID { get; set; }

        public virtual WR_WORKER_ACTION_PAYMENTS WR_WORKER_ACTION_PAYMENTS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
