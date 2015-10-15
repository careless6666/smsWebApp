namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_DISMISSAL_ITEM_COST
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ODIC_ID { get; set; }

        public int? OPTD_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public decimal COST { get; set; }

        public int SHIFT_COUNT { get; set; }

        public DateTime DATE_START { get; set; }

        public DateTime DATE_END { get; set; }

        public virtual OPT_DISMISSAL_ITEMS OPT_DISMISSAL_ITEMS { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
