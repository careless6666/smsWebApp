namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_BONUS_CLIENTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CGN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        public virtual CGN_CAMPAIGN CGN_CAMPAIGN { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        public virtual OPT_WORK_TYPES OPT_WORK_TYPES { get; set; }
    }
}
