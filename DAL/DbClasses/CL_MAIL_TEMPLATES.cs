namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_MAIL_TEMPLATES
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CLMT_BODY { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CLMT_LINE { get; set; }

        public bool CLMT_MED_BOOK { get; set; }

        public bool CLMT_PASSPORT { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }
    }
}
