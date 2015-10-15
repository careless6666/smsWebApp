namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_BANK_CARDS
    {
        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AB_ID { get; set; }

        [StringLength(50)]
        public string BANK_CARD_ID { get; set; }

        [StringLength(50)]
        public string CARD_NUMBER { get; set; }

        [StringLength(50)]
        public string CARD_ACCOUNT_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VALID_UNTIL { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        public virtual AC_BANKS AC_BANKS { get; set; }
    }
}
