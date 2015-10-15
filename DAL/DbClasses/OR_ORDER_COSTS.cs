namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER_COSTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_ORDER_COSTS()
        {
            OR_ORDER_COSTS_HISTORY = new HashSet<OR_ORDER_COSTS_HISTORY>();
        }

        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        public decimal ORC_COST { get; set; }

        [Key]
        public int ORC_ID { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_COSTS_HISTORY> OR_ORDER_COSTS_HISTORY { get; set; }
    }
}
