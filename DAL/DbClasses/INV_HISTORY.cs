namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_HISTORY
    {
        [Key]
        public int IIH_ID { get; set; }

        public int INV_ID { get; set; }

        public int STATUS_ID { get; set; }

        public DateTime EDIT_TIME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public virtual INV_INVOICE INV_INVOICE { get; set; }

        public virtual OPT_STATUS OPT_STATUS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
