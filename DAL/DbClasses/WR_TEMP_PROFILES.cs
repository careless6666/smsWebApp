namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_TEMP_PROFILES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_TEMP_PROFILES()
        {
            WR_INTERVIEW_AND_WORKER = new HashSet<WR_INTERVIEW_AND_WORKER>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal WRT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRT_UN_ID { get; set; }

        [Required]
        [StringLength(120)]
        public string WRT_NAME { get; set; }

        [Required]
        [StringLength(120)]
        public string WRT_FAMILY_NAME { get; set; }

        [Required]
        [StringLength(120)]
        public string WRT_FATHER_NAME { get; set; }

        [Required]
        [StringLength(24)]
        public string WRT_PHONE_NUM { get; set; }

        public DateTime WRT_INTERVIEW_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OIS_ID { get; set; }

        public bool WRT_IS_CONVERTED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRT_WR_UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRT_WR_WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public bool WRT_RECALL { get; set; }

        [Required]
        [StringLength(120)]
        public string WRT_VACANCY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRT_AGE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRT_IS_INCOMING_CALL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SCUP_ID { get; set; }

        [Required]
        [StringLength(400)]
        public string WRT_COMMENT { get; set; }

        public DateTime WRT_CREATED { get; set; }

        public bool WRT_IS_COME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_INTERVIEW_AND_WORKER> WR_INTERVIEW_AND_WORKER { get; set; }
    }
}
