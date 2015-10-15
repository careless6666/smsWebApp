namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_STATUSES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_STATUSES()
        {
            WR_HISTORY = new HashSet<WR_HISTORY>();
            OPT_OPTIONS = new HashSet<OPT_OPTIONS>();
            WR_WORKERS = new HashSet<WR_WORKERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal ST_ID { get; set; }

        [StringLength(50)]
        public string ST_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ST_SORT_ORDER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CHANGE_STAT_WORKED_DAYS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CHANGE_STAT_WORKED_PERIOD { get; set; }

        public bool ST_IS_DISMISSAL { get; set; }

        public bool ST_IS_DISMISSAL_BY_COMPANY { get; set; }

        public bool ST_IS_DISMISSAL_BY_SECSERV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_HISTORY> WR_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_OPTIONS> OPT_OPTIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKERS> WR_WORKERS { get; set; }
    }
}
