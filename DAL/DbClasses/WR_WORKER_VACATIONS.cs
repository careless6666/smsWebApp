namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_VACATIONS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime WRV_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime WRV_CREATE { get; set; }

        public int STATE_OF_MIND_ID { get; set; }

        public virtual OPT_DATE_STATE_MIND OPT_DATE_STATE_MIND { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
