namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_DOCUMENT_TYPES
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal DOC_ID { get; set; }

        [StringLength(300)]
        public string DOCUMENT_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRDT_PERIOD { get; set; }
    }
}
