namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_WR_WAGE
    {
        [Key]
        public int CWR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        public int WRW_ID { get; set; }

        public DateTime DATE_START { get; set; }

        public DateTime DATE_END { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        public virtual WR_WAGES WR_WAGES { get; set; }
    }
}
