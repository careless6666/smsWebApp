namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_RELATIONSHIP_PENALTY_TYPES
    {
        [Key]
        public int OPT_RPT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PEN_TYPE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RELATIONSHIP_PEN_TYPE_ID { get; set; }

        public virtual OPT_PENALTY_TYPES OPT_PENALTY_TYPES { get; set; }

        public virtual OPT_PENALTY_TYPES OPT_PENALTY_TYPES1 { get; set; }
    }
}
