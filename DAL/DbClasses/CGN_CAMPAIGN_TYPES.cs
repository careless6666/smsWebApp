namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_CAMPAIGN_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CGN_CAMPAIGN_TYPES()
        {
            CGN_CAMPAIGN = new HashSet<CGN_CAMPAIGN>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CGNT_ID { get; set; }

        [Required]
        [StringLength(120)]
        public string CGNT_NAME { get; set; }

        [Required]
        [StringLength(400)]
        public string CGNT_COMMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGN_CAMPAIGN> CGN_CAMPAIGN { get; set; }
    }
}
