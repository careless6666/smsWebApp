namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ARCH_STATUSES
    {
        [Key]
        [Column(Order = 0)]
        public DateTime AS_DATE { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal ST_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AS_COUNT { get; set; }
    }
}
