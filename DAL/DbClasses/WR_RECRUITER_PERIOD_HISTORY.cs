namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_RECRUITER_PERIOD_HISTORY
    {
        [Key]
        public int WRRPH_ID { get; set; }

        public int WRRP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime WRRPH_DATETIME { get; set; }

        public bool IS_ACTIVE { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_RECRUITER_PERIOD WR_RECRUITER_PERIOD { get; set; }
    }
}
