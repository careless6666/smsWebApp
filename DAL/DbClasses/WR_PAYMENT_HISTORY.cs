namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PAYMENT_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_PAYMENT_HISTORY()
        {
            BANK_TRANSFERS_PAYMENT_HISTORY = new HashSet<BANK_TRANSFERS_PAYMENT_HISTORY>();
            WR_PAYMENT_HISTORY_ACCRUAL = new HashSet<WR_PAYMENT_HISTORY_ACCRUAL>();
        }

        public int CALC_ID { get; set; }

        [Key]
        public int PH_ID { get; set; }

        public bool ACCEPTED { get; set; }

        public DateTime DATE_CREATED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANK_TRANSFERS_PAYMENT_HISTORY> BANK_TRANSFERS_PAYMENT_HISTORY { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_PAYMENT WR_PAYMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PAYMENT_HISTORY_ACCRUAL> WR_PAYMENT_HISTORY_ACCRUAL { get; set; }
    }
}
