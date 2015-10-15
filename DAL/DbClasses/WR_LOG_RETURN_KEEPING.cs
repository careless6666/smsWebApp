namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_LOG_RETURN_KEEPING
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal WRLRK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRLK_ID { get; set; }
    }
}
