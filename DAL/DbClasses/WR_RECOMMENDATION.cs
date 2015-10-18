namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_RECOMMENDATION
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WRR_NUM { get; set; }

        [Required]
        [StringLength(250)]
        public string WRR_NAME { get; set; }

        [Required]
        [StringLength(250)]
        public string WRR_POSITION { get; set; }

        [Required]
        [StringLength(250)]
        public string WRR_COMPANY { get; set; }

        [Required]
        [StringLength(250)]
        public string WRR_PHONE { get; set; }
    }
}
