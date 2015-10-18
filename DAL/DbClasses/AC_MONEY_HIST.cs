namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_MONEY_HIST
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal MH_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime MH_DATETIME_START { get; set; }

        public DateTime? MH_DATETIME_END { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MH_CASH_GIVE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MH_CASH_LAST { get; set; }

        public bool? MH_IS_CLOSED { get; set; }
    }
}
