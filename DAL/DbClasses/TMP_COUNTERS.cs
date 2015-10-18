namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TMP_COUNTERS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal TMP_COUNTER { get; set; }
    }
}
