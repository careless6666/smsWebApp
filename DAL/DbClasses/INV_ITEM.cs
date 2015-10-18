namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INV_ITEM()
        {
            INV_ITEM_WORKER = new HashSet<INV_ITEM_WORKER>();
            INV_ITEM_ORDER = new HashSet<INV_ITEM_ORDER>();
            INV_ITEM_LEGAL_ENTITY = new HashSet<INV_ITEM_LEGAL_ENTITY>();
        }

        [Key]
        public int INV_ITEM_ID { get; set; }

        public int INV_ID { get; set; }

        public int INV_ITEM_TYPE_ID { get; set; }

        public virtual INV_INVOICE INV_INVOICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ITEM_WORKER> INV_ITEM_WORKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ITEM_ORDER> INV_ITEM_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ITEM_LEGAL_ENTITY> INV_ITEM_LEGAL_ENTITY { get; set; }

        public virtual INV_ITEM_TYPE INV_ITEM_TYPE { get; set; }
    }
}
