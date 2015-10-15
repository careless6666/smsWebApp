namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRE_MACHINE_HISTORY
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal FMH_ID { get; set; }

        public DateTime DATE_INSERT { get; set; }

        public int REASON_ID { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FM_ID { get; set; }

        public virtual FIRE_MACHINE FIRE_MACHINE { get; set; }

        public virtual REASONS_FIRE_MACHINE REASONS_FIRE_MACHINE { get; set; }
    }
}
