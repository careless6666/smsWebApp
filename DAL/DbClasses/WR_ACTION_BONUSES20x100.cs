namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_ACTION_BONUSES20x100
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal AB_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public DateTime WHEN_BONUS_GIVED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_BONUS_SUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ACC_ID_NEXT { get; set; }
    }
}
