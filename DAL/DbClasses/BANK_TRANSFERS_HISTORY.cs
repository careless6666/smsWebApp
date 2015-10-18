namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BANK_TRANSFERS_HISTORY
    {
        [Key]
        public int BTH_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public int ACBF_ID { get; set; }

        public int TS_ID { get; set; }

        public DateTime DATE_CREATE { get; set; }

        public virtual BANK_TRANSFERS BANK_TRANSFERS { get; set; }

        public virtual BANK_TRANSFERS_STATUS BANK_TRANSFERS_STATUS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
