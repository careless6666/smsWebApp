namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_RELATED_UNITS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal SCRU_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RELATED_UN_ID { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual SC_UNIT SC_UNIT1 { get; set; }
    }
}
