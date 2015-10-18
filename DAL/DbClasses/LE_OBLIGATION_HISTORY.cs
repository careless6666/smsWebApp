namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LE_OBLIGATION_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LE_OBLIGATION_HISTORY()
        {
            INV_ITEM_LEGAL_ENTITY = new HashSet<INV_ITEM_LEGAL_ENTITY>();
        }

        [Key]
        public int LEOH_ID { get; set; }

        public int LEO_ID { get; set; }

        public DateTime EDIT_TIME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Required]
        [StringLength(160)]
        public string LEOH_COMMENT { get; set; }

        public byte[] LEOH_DATA { get; set; }

        [StringLength(10)]
        public string LEOH_DATA_EXT { get; set; }

        public bool IS_ACCEPTED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ITEM_LEGAL_ENTITY> INV_ITEM_LEGAL_ENTITY { get; set; }

        public virtual LE_OBLIGATION LE_OBLIGATION { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
