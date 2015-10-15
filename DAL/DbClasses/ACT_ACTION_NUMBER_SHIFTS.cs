namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACT_ACTION_NUMBER_SHIFTS
    {
        [Key]
        public int AANS_ID { get; set; }

        public int AA_ID { get; set; }

        public int NUMBER_SHIFTS { get; set; }

        public virtual ACT_ACTIONS ACT_ACTIONS { get; set; }
    }
}
