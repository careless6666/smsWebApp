namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_SUPERVISORS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_SUPERVISORS()
        {
            CL_SUPERVISORS = new HashSet<CL_SUPERVISORS>();
        }

        [Column(TypeName = "numeric")]
        public decimal OST_ID { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal SCU_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_SUPERVISORS> CL_SUPERVISORS { get; set; }

        public virtual OPT_SUPERVISOR_TYPES OPT_SUPERVISOR_TYPES { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
