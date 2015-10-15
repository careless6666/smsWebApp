namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_AUTHORIZATION_LOG
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal USAL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal USAL_USID { get; set; }

        public DateTime USAL_LOGIN_DTIME { get; set; }

        public DateTime USAL_LASTCHK_DTIME { get; set; }

        [Column(TypeName = "date")]
        public DateTime USAL_DATE { get; set; }
    }
}
