namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_KLADR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_KLADR()
        {
            OPT_HOSTEL = new HashSet<OPT_HOSTEL>();
            OPT_HOSTEL1 = new HashSet<OPT_HOSTEL>();
            OPT_HOSTEL2 = new HashSet<OPT_HOSTEL>();
            OPT_HOSTEL3 = new HashSet<OPT_HOSTEL>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal WK_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string WK_NAME { get; set; }

        [Required]
        [StringLength(150)]
        public string WK_TYPE { get; set; }

        [Required]
        [StringLength(150)]
        public string WK_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string WK_POST_INDEX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_HOSTEL> OPT_HOSTEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_HOSTEL> OPT_HOSTEL1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_HOSTEL> OPT_HOSTEL2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_HOSTEL> OPT_HOSTEL3 { get; set; }
    }
}
