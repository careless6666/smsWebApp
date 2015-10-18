namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GREEN_LIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GREEN_LIST()
        {
            GREEN_LIST_HISTORY = new HashSet<GREEN_LIST_HISTORY>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal GL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public bool IS_ACTIVE { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GREEN_LIST_HISTORY> GREEN_LIST_HISTORY { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
