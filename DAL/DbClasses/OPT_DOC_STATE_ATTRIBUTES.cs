namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_DOC_STATE_ATTRIBUTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_DOC_STATE_ATTRIBUTES()
        {
            WR_WORKER_DOCS_ATTRIBUTES = new HashSet<WR_WORKER_DOCS_ATTRIBUTES>();
        }

        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DOC_STATE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DOC_ATTR_ID { get; set; }

        public virtual OPT_DOCS_STATES OPT_DOCS_STATES { get; set; }

        public virtual OPT_DOC_TYPES_ATTRS OPT_DOC_TYPES_ATTRS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_DOCS_ATTRIBUTES> WR_WORKER_DOCS_ATTRIBUTES { get; set; }
    }
}
