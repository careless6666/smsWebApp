namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IVLEV_PERS_OUT
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CNT_DAYS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PERS_OUT { get; set; }
    }
}
