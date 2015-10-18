namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_CALL_RESULT_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_CALL_RESULT_TYPES()
        {
            CC_CALL_RESULTS = new HashSet<CC_CALL_RESULTS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CRT_TYPE_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string CRT_TEXT { get; set; }

        public bool CRT_CUSTOMISABLE_BLOCK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CRT_BLOCK_SECONDS { get; set; }

        public bool CRT_IS_INTERNAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_CALL_RESULTS> CC_CALL_RESULTS { get; set; }
    }
}
