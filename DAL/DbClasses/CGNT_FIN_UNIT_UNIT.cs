namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGNT_FIN_UNIT_UNIT
    {
        [Key]
        public int FUU_ID { get; set; }

        public int CUN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public virtual CGNT_FIN_UNIT CGNT_FIN_UNIT { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
