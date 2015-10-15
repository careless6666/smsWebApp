namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PAYMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_PAYMENT()
        {
            AC_INTEGRATION_TRANSFERS_PAYMENT = new HashSet<AC_INTEGRATION_TRANSFERS_PAYMENT>();
            WR_PAYMENT_ACCRUALS = new HashSet<WR_PAYMENT_ACCRUALS>();
            WR_PAYMENT_HISTORY = new HashSet<WR_PAYMENT_HISTORY>();
        }

        [Key]
        public int CALC_ID { get; set; }

        public byte CALC_TYPE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public decimal SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_INTEGRATION_TRANSFERS_PAYMENT> AC_INTEGRATION_TRANSFERS_PAYMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PAYMENT_ACCRUALS> WR_PAYMENT_ACCRUALS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PAYMENT_HISTORY> WR_PAYMENT_HISTORY { get; set; }

        public virtual WR_PAYMENT_TYPE WR_PAYMENT_TYPE { get; set; }
    }
}
