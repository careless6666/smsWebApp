namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_ITEM_ORDER
    {
        [Key]
        public int IIO_ID { get; set; }

        public int INV_ITEM_ID { get; set; }

        public int OOCH_ID { get; set; }

        public virtual INV_ITEM INV_ITEM { get; set; }

        public virtual OR_ORDER_COSTS_HISTORY OR_ORDER_COSTS_HISTORY { get; set; }
    }
}
