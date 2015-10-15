namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_ACTION_BONUSES_20x100
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACT_BONUS_SUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACT_ATTENDANCE_COUNT { get; set; }
    }
}
