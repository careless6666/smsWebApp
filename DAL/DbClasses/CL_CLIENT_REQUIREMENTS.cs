namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CLIENT_REQUIREMENTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OREQ_TYPE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal REF_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        public virtual OPT_WORK_TYPES OPT_WORK_TYPES { get; set; }
    }
}