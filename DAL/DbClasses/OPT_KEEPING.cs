namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_KEEPING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_KEEPING()
        {
            WR_KEEPING = new HashSet<WR_KEEPING>();
            OPT_KEEPING_UNITS = new HashSet<OPT_KEEPING_UNITS>();
            TMP_RETURN_KEEPING = new HashSet<TMP_RETURN_KEEPING>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal KP_ID { get; set; }

        [StringLength(100)]
        public string KP_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KP_SUM { get; set; }

        public bool KP_IS_RETURN { get; set; }

        public int KP_ORDER_COUNT_RETURN { get; set; }

        public int KP_ORDER_COUNT_DIVIDE { get; set; }

        public bool KP_IS_ACTIVE { get; set; }

        public int KP_MONTH_COUNT_RETURN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_KEEPING> WR_KEEPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_KEEPING_UNITS> OPT_KEEPING_UNITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TMP_RETURN_KEEPING> TMP_RETURN_KEEPING { get; set; }
    }
}
