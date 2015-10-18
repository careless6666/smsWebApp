namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_ITEM_WORKER
    {
        [Key]
        public int IIW_ID { get; set; }

        public int INV_ITEM_ID { get; set; }

        public int OOWH_ID { get; set; }

        public virtual INV_ITEM INV_ITEM { get; set; }

        public virtual OR_ORDER_WORKER_HISTORY OR_ORDER_WORKER_HISTORY { get; set; }
    }
}
