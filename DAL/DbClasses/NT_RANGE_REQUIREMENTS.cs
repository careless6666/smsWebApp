namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NT_RANGE_REQUIREMENTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal NT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public int? NT_RR_MIN { get; set; }

        public int? NT_RR_MAX { get; set; }

        public virtual CL_NETS CL_NETS { get; set; }

        public virtual OPT_RANGE_REFERENCES OPT_RANGE_REFERENCES { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
