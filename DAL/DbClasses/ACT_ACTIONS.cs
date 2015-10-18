namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACT_ACTIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACT_ACTIONS()
        {
            ACT_ACTION_NUMBER_SHIFTS = new HashSet<ACT_ACTION_NUMBER_SHIFTS>();
            WR_WORKER_ACTION_PAYMENTS = new HashSet<WR_WORKER_ACTION_PAYMENTS>();
        }

        [Key]
        public int AA_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public int OAT_ID { get; set; }

        public decimal AA_SUM { get; set; }

        public DateTime AA_START_DATE { get; set; }

        public DateTime AA_END_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRG_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACT_ACTION_NUMBER_SHIFTS> ACT_ACTION_NUMBER_SHIFTS { get; set; }

        public virtual OPT_ACTION_TYPES OPT_ACTION_TYPES { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual WR_GROUPS WR_GROUPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_ACTION_PAYMENTS> WR_WORKER_ACTION_PAYMENTS { get; set; }
    }
}
