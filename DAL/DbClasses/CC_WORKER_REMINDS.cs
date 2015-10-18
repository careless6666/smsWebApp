namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_WORKER_REMINDS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CWR_ORDER_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CWR_UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CWR_WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CWR_USER_CREATE { get; set; }

        public DateTime CWR_AT_TIME { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
