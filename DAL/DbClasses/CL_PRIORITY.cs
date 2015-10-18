namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_PRIORITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_PRIORITY()
        {
            CL_CLIENTS = new HashSet<CL_CLIENTS>();
            OR_ORDER = new HashSet<OR_ORDER>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CLP_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CLP_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CLP_WEIGHT { get; set; }

        public bool CLP_IS_DEFAULT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS> CL_CLIENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER> OR_ORDER { get; set; }
    }
}
