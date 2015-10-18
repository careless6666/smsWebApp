namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_SMS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal WRS_ID { get; set; }

        [Required]
        [StringLength(2048)]
        public string WRS_SMSTEXT { get; set; }

        [Required]
        [StringLength(32)]
        public string WRS_SMSNUMBER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRS_SMSCOUNT { get; set; }

        public bool WRS_SMSSENT { get; set; }

        public long WRS_PUSH_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRS_ERROR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRS_STATUS_ID { get; set; }

        public DateTime WRS_LASTCHK_DATE { get; set; }

        public int WRS_TYPE_ID { get; set; }

        public int UN_ID { get; set; }

        public int WR_ID { get; set; }

        public virtual WR_SMS_TYPES WR_SMS_TYPES { get; set; }
    }
}
