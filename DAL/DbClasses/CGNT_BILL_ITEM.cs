namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGNT_BILL_ITEM
    {
        [Key]
        public int BLTM_ID { get; set; }

        public int BL_ID { get; set; }

        public int FWT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BLTM_COST_HUMAN_HOUR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BLTM_VOLUME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BLTM_SUM { get; set; }

        public int? BLTM_TAX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BLTM_TAX_SUM { get; set; }

        public virtual CGNT_BILL CGNT_BILL { get; set; }

        public virtual OPT_FIN_WORK_TYPES OPT_FIN_WORK_TYPES { get; set; }
    }
}
