namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FUN_MAGIC_BUTTON
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal FMB_CLICK { get; set; }

        public DateTime FMB_CLICK_TIME { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
