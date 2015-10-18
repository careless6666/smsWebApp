namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACTION")]
    public partial class ACTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTION()
        {
            ACTION_PAYMENTS_HISTORY = new HashSet<ACTION_PAYMENTS_HISTORY>();
        }

        public int ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public DateTime DATE_START { get; set; }

        public DateTime DATE_END { get; set; }

        public int RPH_BONUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTION_PAYMENTS_HISTORY> ACTION_PAYMENTS_HISTORY { get; set; }
    }
}
