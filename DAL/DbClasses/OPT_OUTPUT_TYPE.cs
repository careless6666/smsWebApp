namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_OUTPUT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_OUTPUT_TYPE()
        {
            OR_ORDER_WORKERS = new HashSet<OR_ORDER_WORKERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal OT_ID { get; set; }

        [StringLength(50)]
        public string OT_NAME { get; set; }

        public bool IsDefault { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKERS> OR_ORDER_WORKERS { get; set; }
    }
}
