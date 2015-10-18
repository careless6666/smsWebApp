namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_INFO_SITES
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal OIS_ID { get; set; }

        [Required]
        [StringLength(400)]
        public string OIS_SITE_NAME { get; set; }

        public bool OIS_IS_PARENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OIS_PARENT_ID { get; set; }

        public bool OIS_SHOW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
