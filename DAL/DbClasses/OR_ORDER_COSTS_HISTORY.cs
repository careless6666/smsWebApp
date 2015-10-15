namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER_COSTS_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_ORDER_COSTS_HISTORY()
        {
            INV_ITEM_ORDER = new HashSet<INV_ITEM_ORDER>();
        }

        [Key]
        public int OOCH_ID { get; set; }

        public int ORC_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime OOCH_DATE { get; set; }

        [Required]
        [StringLength(160)]
        public string OOCH_COMMENT { get; set; }

        public byte[] OOCH_DATA { get; set; }

        [StringLength(10)]
        public string OOCH_DATA_EXT { get; set; }

        public bool IS_ACCEPTED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ITEM_ORDER> INV_ITEM_ORDER { get; set; }

        public virtual OR_ORDER_COSTS OR_ORDER_COSTS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
