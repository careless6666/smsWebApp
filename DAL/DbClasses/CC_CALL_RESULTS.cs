namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_CALL_RESULTS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CCR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CRT_TYPE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCR_VIEW_SECONDS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCR_USER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCR_UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCR_WR_ID { get; set; }

        public DateTime CCR_RECORD_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CCR_ORDER_ID { get; set; }

        public virtual CC_CALL_RESULT_TYPES CC_CALL_RESULT_TYPES { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
