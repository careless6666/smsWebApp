namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_ACTION_BRING_FRIEND_2012_UNITS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WABF_SUM { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
