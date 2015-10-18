namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_TASK_CAMPAIGN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CITC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CIT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CGN_ID { get; set; }

        public virtual CGN_CAMPAIGN CGN_CAMPAIGN { get; set; }

        public virtual CC_IPTEL_TASKS CC_IPTEL_TASKS { get; set; }
    }
}
