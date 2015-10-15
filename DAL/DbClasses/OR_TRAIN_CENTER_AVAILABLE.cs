namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_TRAIN_CENTER_AVAILABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_TRAIN_CENTER_AVAILABLE()
        {
            OR_TRAIN_CENTER_WORKERS = new HashSet<OR_TRAIN_CENTER_WORKERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORTC_WORKERS_MAX { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_TRAIN_CENTER_WORKERS> OR_TRAIN_CENTER_WORKERS { get; set; }
    }
}
