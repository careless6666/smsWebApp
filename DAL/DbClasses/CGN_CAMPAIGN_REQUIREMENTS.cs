namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_CAMPAIGN_REQUIREMENTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CGNT_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CGNR_TYPE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal REF_ID { get; set; }
    }
}
