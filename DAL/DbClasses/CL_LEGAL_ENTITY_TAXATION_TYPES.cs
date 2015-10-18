namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_LEGAL_ENTITY_TAXATION_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_LEGAL_ENTITY_TAXATION_TYPES()
        {
            CL_JURI_NAMES = new HashSet<CL_JURI_NAMES>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TAX_TYPE_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string CAPTION { get; set; }

        [Required]
        [StringLength(30)]
        public string KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_JURI_NAMES> CL_JURI_NAMES { get; set; }
    }
}
