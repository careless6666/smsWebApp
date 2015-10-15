namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_JURI_NAMES_EXTENSIONS_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_JURI_NAMES_EXTENSIONS_TYPE()
        {
            CL_JURI_NAMES_EXTENSIONS = new HashSet<CL_JURI_NAMES_EXTENSIONS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal ExtensionTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public bool IsForeignKey { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_DataTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string KEY_CHAR_VALUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_JURI_NAMES_EXTENSIONS> CL_JURI_NAMES_EXTENSIONS { get; set; }

        public virtual WR_DataType WR_DataType { get; set; }
    }
}
