namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_TEL_CODE_ZONES
    {
        [Key]
        [StringLength(6)]
        public string OTCZ_TEL_CODE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OTCZ_UNIT { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
