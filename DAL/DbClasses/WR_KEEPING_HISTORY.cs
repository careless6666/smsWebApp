namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_KEEPING_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_KEEPING_HISTORY()
        {
            AC_ACCRUAL_KEEPING = new HashSet<AC_ACCRUAL_KEEPING>();
        }

        [Key]
        public int WKH_ID { get; set; }

        public int WRK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime WKH_DATE { get; set; }

        public int WKH_ORDER_COUNT { get; set; }

        public byte OKS_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_KEEPING> AC_ACCRUAL_KEEPING { get; set; }

        public virtual OPT_KEEPING_STATUS OPT_KEEPING_STATUS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_KEEPING WR_KEEPING { get; set; }
    }
}
