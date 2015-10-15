namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_SMS_TEMPLATES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_SMS_TEMPLATES()
        {
            OPT_REGIONAL_SMS = new HashSet<OPT_REGIONAL_SMS>();
            SC_PLACES_SMS = new HashSet<SC_PLACES_SMS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OSMST_ID { get; set; }

        [Required]
        [StringLength(512)]
        public string OSMST_TEXT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_REGIONAL_SMS> OPT_REGIONAL_SMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_PLACES_SMS> SC_PLACES_SMS { get; set; }
    }
}
