namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_DataType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_DataType()
        {
            CL_JURI_NAMES_EXTENSIONS_TYPE = new HashSet<CL_JURI_NAMES_EXTENSIONS_TYPE>();
            WR_WORKERS_EXTENSIONS_TYPE = new HashSet<WR_WORKERS_EXTENSIONS_TYPE>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal TypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_JURI_NAMES_EXTENSIONS_TYPE> CL_JURI_NAMES_EXTENSIONS_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKERS_EXTENSIONS_TYPE> WR_WORKERS_EXTENSIONS_TYPE { get; set; }
    }
}
