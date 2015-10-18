namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_ITEM_LEGAL_ENTITY
    {
        [Key]
        public int IILE_ID { get; set; }

        public int INV_ITEM_ID { get; set; }

        public int LEOH_ID { get; set; }

        public virtual INV_ITEM INV_ITEM { get; set; }

        public virtual LE_OBLIGATION_HISTORY LE_OBLIGATION_HISTORY { get; set; }
    }
}
