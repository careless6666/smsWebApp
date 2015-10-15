namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMPORARY_AC_ACCURAL
    {
        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal ACC_ID { get; set; }

        [StringLength(300)]
        public string ACC_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_SUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ACC_OR_ID { get; set; }

        public bool? ACC_IS_INCOME { get; set; }

        public bool? ACC_IS_CALC { get; set; }

        public DateTime? ACC_DATE { get; set; }

        public DateTime ACC_DATETIME { get; set; }

        public byte ACC_CALC_TYPE { get; set; }

        public bool ACC_IS_CALC_GIVED { get; set; }

        public DateTime ACC_GIVED_DATE { get; set; }

        public bool ACC_IS_CALC_TRANSFERRED { get; set; }

        public int AAT_ID { get; set; }
    }
}
