namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_ACTUAL_CONFIGURATIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_ACTUAL_CONFIGURATIONS()
        {
            CL_ACTUAL_SETTINGS = new HashSet<CL_ACTUAL_SETTINGS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CAC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OACT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OACV_ID { get; set; }

        public bool CAC_IS_DEFAULT { get; set; }

        public virtual OPT_ACTUAL_COEF_TYPES OPT_ACTUAL_COEF_TYPES { get; set; }

        public virtual OPT_ACTUAL_COEF_VALUES OPT_ACTUAL_COEF_VALUES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_ACTUAL_SETTINGS> CL_ACTUAL_SETTINGS { get; set; }
    }
}
