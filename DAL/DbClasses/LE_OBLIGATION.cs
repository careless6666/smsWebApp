namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LE_OBLIGATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LE_OBLIGATION()
        {
            LE_OBLIGATION_HISTORY = new HashSet<LE_OBLIGATION_HISTORY>();
        }

        [Key]
        public int LEO_ID { get; set; }

        public int CON_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LEO_SUM { get; set; }

        public DateTime LEO_DATE { get; set; }

        public virtual CL_CONTRACT CL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LE_OBLIGATION_HISTORY> LE_OBLIGATION_HISTORY { get; set; }
    }
}
