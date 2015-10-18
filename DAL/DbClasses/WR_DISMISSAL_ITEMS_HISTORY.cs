namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_DISMISSAL_ITEMS_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_DISMISSAL_ITEMS_HISTORY()
        {
            WR_DISMISSAL_HIST_ACCRUAL = new HashSet<WR_DISMISSAL_HIST_ACCRUAL>();
        }

        [Key]
        public int HI_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime DATE_CREATED { get; set; }

        public int STATUS_ID { get; set; }

        public int WRDI_ID { get; set; }

        public virtual OPT_STATUS OPT_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_DISMISSAL_HIST_ACCRUAL> WR_DISMISSAL_HIST_ACCRUAL { get; set; }

        public virtual WR_DISMISSAL_ITEMS WR_DISMISSAL_ITEMS { get; set; }
    }
}
