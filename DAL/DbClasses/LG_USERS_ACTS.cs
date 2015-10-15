namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LG_USERS_ACTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ACTION_TIME { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal ACTION_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OR_ID { get; set; }

        [StringLength(100)]
        public string AC_COMMENT { get; set; }
    }
}
