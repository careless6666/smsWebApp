namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WAGES_PERIODS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal WGP_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime WGP_DATE_START { get; set; }

        [Column(TypeName = "date")]
        public DateTime WGP_DATE_END { get; set; }
    }
}
