namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_ROSEURO_IDS
    {
        [Key]
        [StringLength(100)]
        public string WKL_LESS_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRE_ID { get; set; }

        public virtual WR_KLADR_LESS WR_KLADR_LESS { get; set; }
    }
}
