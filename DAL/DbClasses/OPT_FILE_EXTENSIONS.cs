namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_FILE_EXTENSIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_FILE_EXTENSIONS()
        {
            WR_INTERNAL_CONTRACT = new HashSet<WR_INTERNAL_CONTRACT>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string EXTENSION_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string MIME_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_INTERNAL_CONTRACT> WR_INTERNAL_CONTRACT { get; set; }
    }
}
