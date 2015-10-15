namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_DOCUMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_WORKER_DOCUMENTS()
        {
            WR_WORKER_DOC_CONTENT = new HashSet<WR_WORKER_DOC_CONTENT>();
            WR_WORKER_DOCS_ATTRIBUTES = new HashSet<WR_WORKER_DOCS_ATTRIBUTES>();
        }

        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DOC_STATE_ID { get; set; }

        public virtual OPT_DOCS_STATES OPT_DOCS_STATES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_DOC_CONTENT> WR_WORKER_DOC_CONTENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_DOCS_ATTRIBUTES> WR_WORKER_DOCS_ATTRIBUTES { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
