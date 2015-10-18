namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_WKAC
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CCILT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OIS_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime CCILT_AT { get; set; }

        [Required]
        [StringLength(120)]
        public string COMMENT { get; set; }

        [Required]
        [StringLength(50)]
        public string TELEFON { get; set; }
    }
}
