namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_KLADR_LESS
    {
        [Key]
        [StringLength(100)]
        public string WKL_LESS_NAME { get; set; }

        [Required]
        [StringLength(150)]
        public string WKL_NAME { get; set; }

        public virtual WR_ROSEURO_IDS WR_ROSEURO_IDS { get; set; }
    }
}
