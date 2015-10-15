namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKER_DOC_CONTENT
    {
        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_WORKER_DOC { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] DATA_CONTENT { get; set; }

        public DateTime CREATING_DATE { get; set; }

        public virtual WR_WORKER_DOCUMENTS WR_WORKER_DOCUMENTS { get; set; }
    }
}
