namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_USERS_STATUSES
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CIU_STATUS { get; set; }

        public DateTime CIU_ACTIVE_AT { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
