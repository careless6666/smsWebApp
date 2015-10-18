namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_KEEPING_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_KEEPING_STATUS()
        {
            WR_KEEPING_HISTORY = new HashSet<WR_KEEPING_HISTORY>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte OKS_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string OKS_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string OKS_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_KEEPING_HISTORY> WR_KEEPING_HISTORY { get; set; }
    }
}
