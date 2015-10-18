namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_MEDICAL_BOOKS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal WRMB_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public DateTime WRMB_DATE_GIVED { get; set; }

        public DateTime WRMB_DATE_UPDATE { get; set; }

        public DateTime WRMB_DATE_EXPIRED { get; set; }

        [Required]
        [StringLength(64)]
        public string WRMB_NUM { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
