namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_RECRUITER_PERIOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_RECRUITER_PERIOD()
        {
            WR_RECRUITER_HISTORY = new HashSet<WR_RECRUITER_HISTORY>();
            WR_RECRUITER_PERIOD_HISTORY = new HashSet<WR_RECRUITER_PERIOD_HISTORY>();
        }

        [Key]
        public int WRRP_ID { get; set; }

        public int WRR_ID { get; set; }

        public byte ORT_ID { get; set; }

        public decimal WRR_SUM { get; set; }

        public DateTime WRRP_START { get; set; }

        public DateTime WRRP_END { get; set; }

        public virtual OPT_RECRUITER_TYPE OPT_RECRUITER_TYPE { get; set; }

        public virtual WR_RECRUITER WR_RECRUITER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER_HISTORY> WR_RECRUITER_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER_PERIOD_HISTORY> WR_RECRUITER_PERIOD_HISTORY { get; set; }
    }
}
