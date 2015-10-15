namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_REG_GIVE_MONEY
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CCRG_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public DateTime CCRG_DATE { get; set; }

        public DateTime CCRG_THEN_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCRG_THERE_UNIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCRG_THERE_PLACE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCRG_TOTAL_SUM { get; set; }

        public bool CCRG_SUM_PREPAY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCRG_MANAGER { get; set; }
    }
}
