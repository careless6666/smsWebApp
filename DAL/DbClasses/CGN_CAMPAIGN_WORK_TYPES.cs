namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_CAMPAIGN_WORK_TYPES
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CGNT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string WT_NAME { get; set; }
    }
}
