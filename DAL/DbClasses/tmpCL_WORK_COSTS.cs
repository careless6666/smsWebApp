namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tmpCL_WORK_COSTS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CWC_NUM { get; set; }

        [StringLength(100)]
        public string CWC_DOC_NUM { get; set; }

        public DateTime? CWC_START { get; set; }

        public DateTime? CWC_END { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CWC_COST_HUMAN_HOUR { get; set; }

        [StringLength(200)]
        public string WT_NAME_IN_DEAL { get; set; }
    }
}
