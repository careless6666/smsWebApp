namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER_REQUIREMENTS
    {
        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OREQ_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal REF_ID { get; set; }

        [Key]
        public int ORR_ID { get; set; }
    }
}
