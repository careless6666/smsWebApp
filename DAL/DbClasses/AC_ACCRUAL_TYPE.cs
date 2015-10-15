namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_ACCRUAL_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AC_ACCRUAL_TYPE()
        {
            AC_ACCURAL = new HashSet<AC_ACCURAL>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AAT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string AAT_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string AAT_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCURAL> AC_ACCURAL { get; set; }
    }
}
