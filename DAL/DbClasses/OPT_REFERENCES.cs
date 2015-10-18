namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_REFERENCES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_REFERENCES()
        {
            OPT_REFERENCES_UNIT = new HashSet<OPT_REFERENCES_UNIT>();
            WR_WORKER_REFERENCES = new HashSet<WR_WORKER_REFERENCES>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal REF_ID { get; set; }

        [StringLength(50)]
        public string REF_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_REFERENCES_UNIT> OPT_REFERENCES_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_REFERENCES> WR_WORKER_REFERENCES { get; set; }
    }
}
