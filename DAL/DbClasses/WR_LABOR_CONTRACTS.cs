namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_LABOR_CONTRACTS
    {
        [Key]
        public int WRLC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string WRLC_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime WRLC_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime WRLC_PERIOD_START { get; set; }

        [Column(TypeName = "date")]
        public DateTime WRLC_PERIOD_END { get; set; }

        [Column(TypeName = "date")]
        public DateTime WRLC_ISSUING_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
