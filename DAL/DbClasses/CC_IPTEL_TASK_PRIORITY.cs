namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_TASK_PRIORITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_IPTEL_TASK_PRIORITY()
        {
            CC_IPTEL_TASKS = new HashSet<CC_IPTEL_TASKS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CITP_ID { get; set; }

        [StringLength(20)]
        public string CITP_NAME { get; set; }

        [StringLength(20)]
        public string CITP_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_TASKS> CC_IPTEL_TASKS { get; set; }
    }
}
