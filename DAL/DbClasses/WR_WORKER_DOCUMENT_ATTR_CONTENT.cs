namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_DOCUMENT_ATTR_CONTENT
    {
        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_DOCUMENT_ATTR { get; set; }

        [Required]
        [StringLength(200)]
        public string ATTR_CONTENT { get; set; }

        public DateTime CREATING_DATE { get; set; }

        public virtual WR_WORKER_DOCS_ATTRIBUTES WR_WORKER_DOCS_ATTRIBUTES { get; set; }
    }
}
