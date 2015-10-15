namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_DOCUMENT_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_DOCUMENT_TYPES()
        {
            OPT_DOC_TYPES_ATTRS = new HashSet<OPT_DOC_TYPES_ATTRS>();
            OPT_DOCS_STATES = new HashSet<OPT_DOCS_STATES>();
            WR_WAITING_FOR_FMS_RESPONSE = new HashSet<WR_WAITING_FOR_FMS_RESPONSE>();
        }

        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string KEY_CHAR_VAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_DOC_TYPES_ATTRS> OPT_DOC_TYPES_ATTRS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_DOCS_STATES> OPT_DOCS_STATES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WAITING_FOR_FMS_RESPONSE> WR_WAITING_FOR_FMS_RESPONSE { get; set; }
    }
}
