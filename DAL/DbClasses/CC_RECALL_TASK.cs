namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_RECALL_TASK
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CRT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CIT_ID { get; set; }

        [StringLength(300)]
        public string CRT_COMMENT { get; set; }

        public DateTime? CRT_RECALL_TIME { get; set; }

        [StringLength(25)]
        public string CRT_RECALL_PHONE { get; set; }

        public int? UN_ID { get; set; }

        public int? WR_ID { get; set; }

        public int ID_SUBSCRIBER { get; set; }

        public virtual CC_IPTEL_TASKS CC_IPTEL_TASKS { get; set; }
    }
}
