namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_ACTION_PAYMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_WORKER_ACTION_PAYMENTS()
        {
            WR_WORKER_ACTION_BRING_FRIEND = new HashSet<WR_WORKER_ACTION_BRING_FRIEND>();
            WR_WORKER_ACTION_PAYMENTS_HISTORY = new HashSet<WR_WORKER_ACTION_PAYMENTS_HISTORY>();
        }

        [Key]
        public int WWAP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public int AA_ID { get; set; }

        public DateTime WWAP_DATE { get; set; }

        public virtual ACT_ACTIONS ACT_ACTIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_ACTION_BRING_FRIEND> WR_WORKER_ACTION_BRING_FRIEND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_ACTION_PAYMENTS_HISTORY> WR_WORKER_ACTION_PAYMENTS_HISTORY { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
