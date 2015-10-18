namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_DOCS_ATTRIBUTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_WORKER_DOCS_ATTRIBUTES()
        {
            WR_WORKER_DOCUMENT_ATTR_CONTENT = new HashSet<WR_WORKER_DOCUMENT_ATTR_CONTENT>();
        }

        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WORKER_DOC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_DOC_STATE_ATTR { get; set; }

        public virtual OPT_DOC_STATE_ATTRIBUTES OPT_DOC_STATE_ATTRIBUTES { get; set; }

        public virtual WR_WORKER_DOCUMENTS WR_WORKER_DOCUMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_DOCUMENT_ATTR_CONTENT> WR_WORKER_DOCUMENT_ATTR_CONTENT { get; set; }
    }
}
