namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_DOCS_STATES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_DOCS_STATES()
        {
            OPT_DOC_STATE_ATTRIBUTES = new HashSet<OPT_DOC_STATE_ATTRIBUTES>();
            WR_WORKER_DOCUMENTS = new HashSet<WR_WORKER_DOCUMENTS>();
        }

        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DOC_TYPE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal STATE_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_DOC_STATE_ATTRIBUTES> OPT_DOC_STATE_ATTRIBUTES { get; set; }

        public virtual OPT_DOCUMENT_TYPES OPT_DOCUMENT_TYPES { get; set; }

        public virtual WR_KLADR_COUNTRIES WR_KLADR_COUNTRIES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_DOCUMENTS> WR_WORKER_DOCUMENTS { get; set; }
    }
}
