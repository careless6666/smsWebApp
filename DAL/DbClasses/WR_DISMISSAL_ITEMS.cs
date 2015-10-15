namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_DISMISSAL_ITEMS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_DISMISSAL_ITEMS()
        {
            WR_DISMISSAL_ITEMS_HISTORY = new HashSet<WR_DISMISSAL_ITEMS_HISTORY>();
        }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public int OPTD_ID { get; set; }

        [Key]
        public int WRDI_ID { get; set; }

        public virtual OPT_DISMISSAL_ITEMS OPT_DISMISSAL_ITEMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_DISMISSAL_ITEMS_HISTORY> WR_DISMISSAL_ITEMS_HISTORY { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
