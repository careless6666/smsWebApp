namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_CARDS_ROSEURO
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string WR_CARDNUM { get; set; }

        public bool WR_CARDISSUED { get; set; }

        [StringLength(50)]
        public string WR_CARD_ACCOUNT_NUMBER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WC_BANK_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string WCR_ID_CARD { get; set; }

        public bool WCR_IS_SENT { get; set; }

        public DateTime? CARD_APPLIED_DATE { get; set; }

        public DateTime? CARD_ISSUED_DATE { get; set; }

        public virtual AC_BANKS AC_BANKS { get; set; }
    }
}
