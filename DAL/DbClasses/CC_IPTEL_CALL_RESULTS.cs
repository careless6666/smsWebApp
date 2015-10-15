namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_CALL_RESULTS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CICR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CICRT_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CICR_USER { get; set; }

        public DateTime CICR_AT { get; set; }

        [Required]
        [StringLength(222)]
        public string CICR_SID { get; set; }

        [StringLength(100)]
        public string CICR_PHONE { get; set; }

        public int CICR_DURATION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CIT_ID { get; set; }

        public int UN_ID { get; set; }

        public int WR_ID { get; set; }

        [StringLength(500)]
        public string COMMENT { get; set; }

        public virtual CC_IPTEL_CALL_RESULT_TYPES CC_IPTEL_CALL_RESULT_TYPES { get; set; }
    }
}
