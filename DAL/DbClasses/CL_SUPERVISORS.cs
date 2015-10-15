namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_SUPERVISORS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal SCU_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        public bool CLS_IS_RESPONSIVE { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        public virtual WR_SUPERVISORS WR_SUPERVISORS { get; set; }
    }
}
