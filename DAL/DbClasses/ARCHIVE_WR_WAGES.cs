namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ARCHIVE_WR_WAGES
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WRG_ID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal WRW_COST { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal WRW_COST_INC { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal WRW_HOURS_INC { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal WGP_ID { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "numeric")]
        public decimal WRW_COST_LMK { get; set; }
    }
}
