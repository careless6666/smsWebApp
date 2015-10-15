namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_DEPARTMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_DEPARTMENTS()
        {
            CL_NETS_DEPARTMENTS = new HashSet<CL_NETS_DEPARTMENTS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal DEP_ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string DEP_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_NETS_DEPARTMENTS> CL_NETS_DEPARTMENTS { get; set; }
    }
}
