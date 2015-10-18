namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BANK_TRANSFERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANK_TRANSFERS()
        {
            BANK_TRANSFERS_HISTORY = new HashSet<BANK_TRANSFERS_HISTORY>();
            BANK_TRANSFERS_PAYMENT_HISTORY = new HashSet<BANK_TRANSFERS_PAYMENT_HISTORY>();
        }

        [Key]
        public int ACBF_ID { get; set; }

        public DateTime ACBF_DATE_LOAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACBF_SUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACBF_BID { get; set; }

        public virtual AC_BANKS AC_BANKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANK_TRANSFERS_HISTORY> BANK_TRANSFERS_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANK_TRANSFERS_PAYMENT_HISTORY> BANK_TRANSFERS_PAYMENT_HISTORY { get; set; }
    }
}
