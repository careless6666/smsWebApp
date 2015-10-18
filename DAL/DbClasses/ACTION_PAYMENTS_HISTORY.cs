namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACTION_PAYMENTS_HISTORY
    {
        public int ID { get; set; }

        public int A_ID { get; set; }

        public int AP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        public virtual AC_ACCURAL AC_ACCURAL { get; set; }

        public virtual ACTION ACTION { get; set; }

        public virtual ACTION_PAYMENTS ACTION_PAYMENTS { get; set; }
    }
}
