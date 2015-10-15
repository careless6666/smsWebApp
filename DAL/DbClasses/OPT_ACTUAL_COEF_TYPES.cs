namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_ACTUAL_COEF_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_ACTUAL_COEF_TYPES()
        {
            CL_ACTUAL_CONFIGURATIONS = new HashSet<CL_ACTUAL_CONFIGURATIONS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal OACT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string OACT_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string OACT_KEY_CHAR_VAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_ACTUAL_CONFIGURATIONS> CL_ACTUAL_CONFIGURATIONS { get; set; }
    }
}
