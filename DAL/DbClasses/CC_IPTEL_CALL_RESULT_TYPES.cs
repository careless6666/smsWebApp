namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_CALL_RESULT_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_IPTEL_CALL_RESULT_TYPES()
        {
            CC_IPTEL_CALL_RESULTS = new HashSet<CC_IPTEL_CALL_RESULTS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CICRT_TYPE { get; set; }

        [Required]
        [StringLength(244)]
        public string CICRT_TEXT { get; set; }

        [StringLength(20)]
        public string CICRT_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_CALL_RESULTS> CC_IPTEL_CALL_RESULTS { get; set; }
    }
}
