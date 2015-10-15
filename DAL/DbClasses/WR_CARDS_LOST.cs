namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_CARDS_LOST
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WCL_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string WR_CARDNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string WR_CARD_ACCOUNT_NUMBER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRCL_USER { get; set; }

        public DateTime WRCL_DATETIME { get; set; }

        [Required]
        [StringLength(30)]
        public string WCL_ID_CARD { get; set; }

        public DateTime? CARD_APPLIED_DATE { get; set; }

        public DateTime? CARD_ISSUED_DATE { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
