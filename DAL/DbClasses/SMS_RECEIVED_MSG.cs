namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMS_RECEIVED_MSG
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal SR_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal SRM_ID { get; set; }

        public long SRM_RESP_ID { get; set; }

        [Required]
        [StringLength(32)]
        public string SRM_SRC_NUMBER { get; set; }

        [Required]
        [StringLength(32)]
        public string SRM_NUMBER { get; set; }

        [Required]
        [StringLength(2048)]
        public string SRM_TEXT { get; set; }

        public DateTime SRM_DATETIME { get; set; }

        public bool SRM_PROCESSED { get; set; }

        public virtual SMS_RECEIVE_REQUESTS SMS_RECEIVE_REQUESTS { get; set; }
    }
}
