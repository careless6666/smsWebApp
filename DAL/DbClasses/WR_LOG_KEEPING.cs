namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_LOG_KEEPING
    {
        [Column(TypeName = "numeric")]
        public decimal? UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ID { get; set; }

        [StringLength(100)]
        public string KP_NAME { get; set; }

        public DateTime? KP_DATE_INSERT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? KP_SUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? US_ID { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal WRLK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? US_KEEPER_ID { get; set; }

        public DateTime? KP_DATE_KEEP { get; set; }

        public bool? KP_BEEN_KEEPED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? KP_ORDER_COUNT_DIVIDE { get; set; }
    }
}
