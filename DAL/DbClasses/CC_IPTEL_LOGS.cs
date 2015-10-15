namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_LOGS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CIL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CIL_ORDER_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CIL_UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CIL_WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CIL_ACTION_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CIL_USER { get; set; }

        public DateTime CIL_AT_TIME { get; set; }

        [Required]
        [StringLength(255)]
        public string CIL_SID { get; set; }

        public virtual CC_IPTEL_LOG_TYPES CC_IPTEL_LOG_TYPES { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
