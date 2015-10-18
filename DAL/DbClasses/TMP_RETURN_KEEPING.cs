namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TMP_RETURN_KEEPING
    {
        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KP_ID { get; set; }

        public DateTime? RK_DATE_INSERT { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal RK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RK_PER_SUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RK_LAST_COUNT { get; set; }

        public bool? RK_IS_TO_RETURN { get; set; }

        public virtual OPT_KEEPING OPT_KEEPING { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
