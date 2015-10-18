namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_KLADR_COUNTRIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_KLADR_COUNTRIES()
        {
            OPT_DOCS_STATES = new HashSet<OPT_DOCS_STATES>();
            OPT_HOSTEL = new HashSet<OPT_HOSTEL>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal WKC_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string WKC_NAME { get; set; }

        [StringLength(30)]
        public string KeyCharValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_DOCS_STATES> OPT_DOCS_STATES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_HOSTEL> OPT_HOSTEL { get; set; }
    }
}
