namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CLOSED_PERIODS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CLL_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CLL_US_ID { get; set; }

        public DateTime CLL_DATETIME_CPERIOD { get; set; }

        public DateTime CLL_RCREATE_DATETIME { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
