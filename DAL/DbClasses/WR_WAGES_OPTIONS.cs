namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WAGES_OPTIONS
    {
        [Key]
        public int WRW_OPT_ID { get; set; }

        public int WRW_ID { get; set; }

        public int OPT_TYPE_ID { get; set; }

        public virtual OPT_WAGE_OPTIONS_TYPE OPT_WAGE_OPTIONS_TYPE { get; set; }

        public virtual WR_WAGES WR_WAGES { get; set; }

        public virtual WR_WAGES_OPTIONS_LMK WR_WAGES_OPTIONS_LMK { get; set; }
    }
}
