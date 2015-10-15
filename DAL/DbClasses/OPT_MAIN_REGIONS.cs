namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_MAIN_REGIONS
    {
        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID_MAIN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID_SUBORDINATE { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual SC_UNIT SC_UNIT1 { get; set; }
    }
}
