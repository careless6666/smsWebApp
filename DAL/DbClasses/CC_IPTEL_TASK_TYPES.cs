namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_TASK_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_IPTEL_TASK_TYPES()
        {
            CC_IPTEL_TASKS = new HashSet<CC_IPTEL_TASKS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CITT_ID { get; set; }

        [Required]
        [StringLength(244)]
        public string CITT_TEXT { get; set; }

        [Required]
        [StringLength(50)]
        public string CITT_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_TASKS> CC_IPTEL_TASKS { get; set; }
    }
}
