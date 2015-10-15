namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_EMAILS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OEML_TYPE { get; set; }

        [Required]
        [StringLength(512)]
        public string OEML_EMAIL { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
