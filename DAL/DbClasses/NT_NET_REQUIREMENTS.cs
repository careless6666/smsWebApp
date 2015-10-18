namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NT_NET_REQUIREMENTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal NT_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OREQ_TYPE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal REF_ID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
