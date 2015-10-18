namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_CAMPAIGN_ACTUALS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CGN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGNCA_WEIGHT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGNCA_PRIORITY { get; set; }
    }
}
