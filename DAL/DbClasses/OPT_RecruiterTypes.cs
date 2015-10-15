namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_RecruiterTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_RecruiterTypes()
        {
            WR_WORKERS = new HashSet<WR_WORKERS>();
        }

        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string SpecificName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKERS> WR_WORKERS { get; set; }
    }
}
