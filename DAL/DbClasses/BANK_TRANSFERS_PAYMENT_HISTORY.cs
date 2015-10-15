namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BANK_TRANSFERS_PAYMENT_HISTORY
    {
        [Key]
        public int BTPH_ID { get; set; }

        public int ACBF_ID { get; set; }

        public int PH_ID { get; set; }

        public virtual BANK_TRANSFERS BANK_TRANSFERS { get; set; }

        public virtual WR_PAYMENT_HISTORY WR_PAYMENT_HISTORY { get; set; }
    }
}
