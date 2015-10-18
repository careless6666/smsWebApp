namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class REASONS_FIRE_MACHINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REASONS_FIRE_MACHINE()
        {
            FIRE_MACHINE_HISTORY = new HashSet<FIRE_MACHINE_HISTORY>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REASON_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string REASON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIRE_MACHINE_HISTORY> FIRE_MACHINE_HISTORY { get; set; }
    }
}
