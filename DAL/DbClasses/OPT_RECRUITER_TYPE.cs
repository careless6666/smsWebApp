namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_RECRUITER_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_RECRUITER_TYPE()
        {
            WR_RECRUITER_PERIOD = new HashSet<WR_RECRUITER_PERIOD>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ORT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ORT_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ORT_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER_PERIOD> WR_RECRUITER_PERIOD { get; set; }
    }
}
