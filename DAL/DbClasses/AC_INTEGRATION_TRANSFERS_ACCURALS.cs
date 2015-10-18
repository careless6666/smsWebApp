namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_INTEGRATION_TRANSFERS_ACCURALS
    {
        [Key]
        public int ACITAC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACIT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual AC_INTEGRATION_TRANSFERS AC_INTEGRATION_TRANSFERS { get; set; }
    }
}
