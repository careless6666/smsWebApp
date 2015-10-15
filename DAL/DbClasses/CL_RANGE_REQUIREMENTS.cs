namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_RANGE_REQUIREMENTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RR_ID { get; set; }

        public int? CL_RR_MIN { get; set; }

        public int? CL_RR_MAX { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        public virtual OPT_RANGE_REFERENCES OPT_RANGE_REFERENCES { get; set; }

        public virtual OPT_WORK_TYPES OPT_WORK_TYPES { get; set; }
    }
}
