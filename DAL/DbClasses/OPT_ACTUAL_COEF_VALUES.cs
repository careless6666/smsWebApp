namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_ACTUAL_COEF_VALUES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_ACTUAL_COEF_VALUES()
        {
            CL_ACTUAL_CONFIGURATIONS = new HashSet<CL_ACTUAL_CONFIGURATIONS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal OACV_ID { get; set; }

        public int OACV_VALUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_ACTUAL_CONFIGURATIONS> CL_ACTUAL_CONFIGURATIONS { get; set; }
    }
}
