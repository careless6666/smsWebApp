namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WAGES_OPTIONS_LMK
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WRW_OPT_ID { get; set; }

        public decimal LMK_COST { get; set; }

        public virtual WR_WAGES_OPTIONS WR_WAGES_OPTIONS { get; set; }
    }
}
