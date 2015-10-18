namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_NDFL
    {
        [Key]
        public int WRN_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime WRN_FROM { get; set; }

        [Column(TypeName = "date")]
        public DateTime WRN_TO { get; set; }

        public int UN_ID { get; set; }

        public int WR_ID { get; set; }
    }
}
