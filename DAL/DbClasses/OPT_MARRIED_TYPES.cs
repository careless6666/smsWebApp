namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_MARRIED_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_MARRIED_TYPES()
        {
            WR_WORKERS = new HashSet<WR_WORKERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal MR_ID { get; set; }

        [StringLength(50)]
        public string MR_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKERS> WR_WORKERS { get; set; }
    }
}
