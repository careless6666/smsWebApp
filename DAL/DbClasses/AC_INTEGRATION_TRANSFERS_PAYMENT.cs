namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_INTEGRATION_TRANSFERS_PAYMENT
    {
        [Key]
        public int ACITAC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACIT_ID { get; set; }

        public int CALC_ID { get; set; }

        public virtual AC_INTEGRATION_TRANSFERS AC_INTEGRATION_TRANSFERS { get; set; }

        public virtual WR_PAYMENT WR_PAYMENT { get; set; }
    }
}
