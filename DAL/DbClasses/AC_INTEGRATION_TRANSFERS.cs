namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_INTEGRATION_TRANSFERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AC_INTEGRATION_TRANSFERS()
        {
            AC_INTEGRATION_TRANSFERS_PAYMENT = new HashSet<AC_INTEGRATION_TRANSFERS_PAYMENT>();
            AC_INTEGRATION_TRANSFERS_ACCURALS = new HashSet<AC_INTEGRATION_TRANSFERS_ACCURALS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ACIT_ID { get; set; }

        public DateTime ACIT_DATE_LOAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACIT_SUM { get; set; }

        public bool ACIT_IS_GIVED { get; set; }

        public DateTime ACIT_GIVED_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACIT_USER_MADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACIT_USER_TRANSFERRED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_INTEGRATION_TRANSFERS_PAYMENT> AC_INTEGRATION_TRANSFERS_PAYMENT { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual SC_USERS SC_USERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_INTEGRATION_TRANSFERS_ACCURALS> AC_INTEGRATION_TRANSFERS_ACCURALS { get; set; }
    }
}
