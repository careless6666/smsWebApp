namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_ACTUAL_SETTINGS_TRANSACTIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_ACTUAL_SETTINGS_TRANSACTIONS()
        {
            CL_ACTUAL_SETTINGS = new HashSet<CL_ACTUAL_SETTINGS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CAST_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CATT_ID { get; set; }

        public DateTime CAST_DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_ACTUAL_SETTINGS> CL_ACTUAL_SETTINGS { get; set; }

        public virtual CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
