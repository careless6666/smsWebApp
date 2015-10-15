namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_STATUS_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_STATUS_GROUP()
        {
            OPT_STATUS = new HashSet<OPT_STATUS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS_GROUP_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_STATUS> OPT_STATUS { get; set; }
    }
}
