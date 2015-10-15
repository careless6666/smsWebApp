namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_STATUS()
        {
            INV_HISTORY = new HashSet<INV_HISTORY>();
            OR_ORDER_HISTORY = new HashSet<OR_ORDER_HISTORY>();
            WR_DISMISSAL_ITEMS_HISTORY = new HashSet<WR_DISMISSAL_ITEMS_HISTORY>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS_ID { get; set; }

        public int STATUS_GROUP_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_HISTORY> INV_HISTORY { get; set; }

        public virtual OPT_STATUS_GROUP OPT_STATUS_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_HISTORY> OR_ORDER_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_DISMISSAL_ITEMS_HISTORY> WR_DISMISSAL_ITEMS_HISTORY { get; set; }
    }
}
