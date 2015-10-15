namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_RATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_RATE()
        {
            OR_ORDER_WORKER_HISTORY = new HashSet<OR_ORDER_WORKER_HISTORY>();
        }

        [Key]
        public int CR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        public int CCI_ID { get; set; }

        public DateTime CR_DATE_FROM { get; set; }

        public DateTime CR_DATE_TO { get; set; }

        public bool IS_MISTAKEN { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        public virtual CL_CONTRACT_ITEM CL_CONTRACT_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKER_HISTORY> OR_ORDER_WORKER_HISTORY { get; set; }
    }
}
