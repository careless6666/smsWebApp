namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOG_CC_IN_OUT
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal LCIO_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LCIO_TYPE { get; set; }

        public DateTime LCIO_DATETIME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LCIO_BLOCK_SECONDS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
