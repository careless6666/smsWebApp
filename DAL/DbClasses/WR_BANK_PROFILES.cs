namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_BANK_PROFILES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WRBP_ID { get; set; }

        public DateTime WRBP_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AB_ID { get; set; }

        public virtual AC_BANKS AC_BANKS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
