namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES()
        {
            CL_ACTUAL_SETTINGS_TRANSACTIONS = new HashSet<CL_ACTUAL_SETTINGS_TRANSACTIONS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CATT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CATT_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_ACTUAL_SETTINGS_TRANSACTIONS> CL_ACTUAL_SETTINGS_TRANSACTIONS { get; set; }
    }
}
