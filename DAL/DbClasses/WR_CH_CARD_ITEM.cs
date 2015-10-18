namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_CH_CARD_ITEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CH_CARD_IT_ID { get; set; }

        public int? CH_CARD_ID { get; set; }

        public int? CH_IT_ID { get; set; }

        public virtual OPT_CH_ITEM OPT_CH_ITEM { get; set; }

        public virtual WR_CH_CARD WR_CH_CARD { get; set; }
    }
}
