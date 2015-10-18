namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER_HISTORY
    {
        [Key]
        public int ORDER_HISTORY_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        public int STATUS_ID { get; set; }

        public int CON_ID { get; set; }

        public DateTime EDIT_TIME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public virtual CL_CONTRACT CL_CONTRACT { get; set; }

        public virtual OPT_STATUS OPT_STATUS { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
