namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_DATE_STATE_MIND
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_DATE_STATE_MIND()
        {
            WR_WORKER_VACATIONS = new HashSet<WR_WORKER_VACATIONS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATE_OF_MIND_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string STATE_OF_MIND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_VACATIONS> WR_WORKER_VACATIONS { get; set; }
    }
}
