namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_LOG_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_IPTEL_LOG_TYPES()
        {
            CC_IPTEL_LOGS = new HashSet<CC_IPTEL_LOGS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CILT_ACTION_TYPE { get; set; }

        [Required]
        [StringLength(255)]
        public string CILT_TEXT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_LOGS> CC_IPTEL_LOGS { get; set; }
    }
}
