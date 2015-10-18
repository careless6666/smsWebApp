namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_DOC_TYPES_ATTRS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_DOC_TYPES_ATTRS()
        {
            OPT_DOC_STATE_ATTRIBUTES = new HashSet<OPT_DOC_STATE_ATTRIBUTES>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_DOC_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_ATTR { get; set; }

        public virtual OPT_ATTRIBUTES OPT_ATTRIBUTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_DOC_STATE_ATTRIBUTES> OPT_DOC_STATE_ATTRIBUTES { get; set; }

        public virtual OPT_DOCUMENT_TYPES OPT_DOCUMENT_TYPES { get; set; }
    }
}
