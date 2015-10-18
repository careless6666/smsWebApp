namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_DISMISSAL_ITEMS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_DISMISSAL_ITEMS()
        {
            OPT_DISMISSAL_ITEM_COST = new HashSet<OPT_DISMISSAL_ITEM_COST>();
            WR_DISMISSAL_ITEMS = new HashSet<WR_DISMISSAL_ITEMS>();
        }

        [Required]
        [StringLength(256)]
        public string OPTD_NAME { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OPTD_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_DISMISSAL_ITEM_COST> OPT_DISMISSAL_ITEM_COST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_DISMISSAL_ITEMS> WR_DISMISSAL_ITEMS { get; set; }
    }
}
