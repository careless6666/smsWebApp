namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_NETS_DEPARTMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_NETS_DEPARTMENTS()
        {
            CL_CLIENTS_NETS_DEPARTEMNTS = new HashSet<CL_CLIENTS_NETS_DEPARTEMNTS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal ND_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DEP_ID { get; set; }

        public bool IS_ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS_NETS_DEPARTEMNTS> CL_CLIENTS_NETS_DEPARTEMNTS { get; set; }

        public virtual CL_DEPARTMENTS CL_DEPARTMENTS { get; set; }

        public virtual CL_NETS CL_NETS { get; set; }
    }
}
