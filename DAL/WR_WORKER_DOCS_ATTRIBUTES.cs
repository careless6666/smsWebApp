//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class WR_WORKER_DOCS_ATTRIBUTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_WORKER_DOCS_ATTRIBUTES()
        {
            this.WR_WORKER_DOCUMENT_ATTR_CONTENT = new HashSet<WR_WORKER_DOCUMENT_ATTR_CONTENT>();
        }
    
        public decimal ID { get; set; }
        public decimal WORKER_DOC_ID { get; set; }
        public decimal ID_DOC_STATE_ATTR { get; set; }
    
        public virtual OPT_DOC_STATE_ATTRIBUTES OPT_DOC_STATE_ATTRIBUTES { get; set; }
        public virtual WR_WORKER_DOCUMENTS WR_WORKER_DOCUMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_DOCUMENT_ATTR_CONTENT> WR_WORKER_DOCUMENT_ATTR_CONTENT { get; set; }
    }
}
