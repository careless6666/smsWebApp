namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_RECRUITER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_RECRUITER()
        {
            WR_RECRUITER_PERIOD = new HashSet<WR_RECRUITER_PERIOD>();
        }

        [Key]
        public int WRR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID_MASTER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID_MASTER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID_SLAVE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID_SLAVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER_PERIOD> WR_RECRUITER_PERIOD { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS1 { get; set; }
    }
}
