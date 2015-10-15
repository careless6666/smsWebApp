namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACTION_PAYMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTION_PAYMENTS()
        {
            ACTION_PAYMENTS_HISTORY = new HashSet<ACTION_PAYMENTS_HISTORY>();
        }

        public int ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        public virtual OR_ORDER_WORKERS OR_ORDER_WORKERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTION_PAYMENTS_HISTORY> ACTION_PAYMENTS_HISTORY { get; set; }
    }
}
