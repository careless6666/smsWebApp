namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GREEN_LIST_HISTORY
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal GLH_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string REASON { get; set; }

        public string COMMENT { get; set; }

        public bool IS_ACTIVE { get; set; }

        public DateTime DATE_INSERT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GL_ID { get; set; }

        public virtual GREEN_LIST GREEN_LIST { get; set; }
    }
}
