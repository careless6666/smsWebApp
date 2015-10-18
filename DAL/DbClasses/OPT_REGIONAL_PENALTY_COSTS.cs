namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_REGIONAL_PENALTY_COSTS
    {
        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PEN_TYPE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_COST { get; set; }

        public int PEN_COUNT { get; set; }

        public DateTime DATE_FROM { get; set; }

        public DateTime DATE_TO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RPC_ID { get; set; }

        public virtual OPT_PENALTY_TYPES OPT_PENALTY_TYPES { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
