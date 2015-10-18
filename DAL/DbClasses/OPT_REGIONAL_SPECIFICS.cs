namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_REGIONAL_SPECIFICS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OPT_ID { get; set; }

        [StringLength(100)]
        public string OPT_NAME { get; set; }

        [StringLength(255)]
        public string GENITIVE { get; set; }
    }
}
