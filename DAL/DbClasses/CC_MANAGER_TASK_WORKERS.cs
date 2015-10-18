namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_MANAGER_TASK_WORKERS
    {
        public int TASK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string COMMENT { get; set; }

        public bool IS_CALLED { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public virtual CC_MANAGER_TASK CC_MANAGER_TASK { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
