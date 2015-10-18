namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tmp_old_order_costs
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal or_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OR_COST_HUMAN_HOUR { get; set; }
    }
}
