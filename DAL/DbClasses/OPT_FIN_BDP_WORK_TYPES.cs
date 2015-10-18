namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_FIN_BDP_WORK_TYPES
    {
        [Key]
        public int FBWT_ID { get; set; }

        public int FWT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string WT_ID { get; set; }

        public virtual OPT_FIN_WORK_TYPES OPT_FIN_WORK_TYPES { get; set; }

        public virtual OPT_WORK_TYPES OPT_WORK_TYPES { get; set; }
    }
}
