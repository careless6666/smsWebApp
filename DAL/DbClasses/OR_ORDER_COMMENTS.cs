namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER_COMMENTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Required]
        [StringLength(256)]
        public string OC_COMMENT { get; set; }

        public DateTime OC_DATE { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }
    }
}
