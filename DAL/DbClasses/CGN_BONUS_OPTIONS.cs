namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_BONUS_OPTIONS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CGNBO_NET_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGNBO_ORDERS_FOR_CALC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGNBO_SUM { get; set; }

        public virtual CL_NETS CL_NETS { get; set; }
    }
}
