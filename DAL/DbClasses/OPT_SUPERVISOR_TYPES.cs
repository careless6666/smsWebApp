namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_SUPERVISOR_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_SUPERVISOR_TYPES()
        {
            WR_SUPERVISORS = new HashSet<WR_SUPERVISORS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal OST_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string OST_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_SUPERVISORS> WR_SUPERVISORS { get; set; }
    }
}
