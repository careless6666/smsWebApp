namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_JURI_NAMES_EXTENSIONS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal JrNmExtID { get; set; }

        public int JURI_NAME_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DATA { get; set; }

        [StringLength(20)]
        public string COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_JURI_NAMES_EXTENSIONS_TYPE_ID { get; set; }

        public DateTime CL_DATE_CHANGE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal USER_ID { get; set; }

        public virtual CL_JURI_NAMES CL_JURI_NAMES { get; set; }

        public virtual CL_JURI_NAMES_EXTENSIONS_TYPE CL_JURI_NAMES_EXTENSIONS_TYPE { get; set; }
    }
}
