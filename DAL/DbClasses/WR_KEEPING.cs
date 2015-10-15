namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_KEEPING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_KEEPING()
        {
            WR_KEEPING_HISTORY = new HashSet<WR_KEEPING_HISTORY>();
        }

        [Key]
        public int WRK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KP_ID { get; set; }

        public DateTime KP_DATE_INSERT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public virtual OPT_KEEPING OPT_KEEPING { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_KEEPING_HISTORY> WR_KEEPING_HISTORY { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
