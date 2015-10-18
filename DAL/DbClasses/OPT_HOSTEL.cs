namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_HOSTEL
    {
        [Column(TypeName = "numeric")]
        public decimal ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public bool IS_MAIN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_STATE_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_REGION_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_DISTRICT_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_TOWN_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ID_STREET_KLADR { get; set; }

        [Required]
        [StringLength(100)]
        public string HOUSE_NUMBER { get; set; }

        [Required]
        [StringLength(300)]
        public string COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DAY_COST { get; set; }

        public virtual WR_KLADR WR_KLADR { get; set; }

        public virtual WR_KLADR WR_KLADR1 { get; set; }

        public virtual WR_KLADR_COUNTRIES WR_KLADR_COUNTRIES { get; set; }

        public virtual WR_KLADR WR_KLADR2 { get; set; }

        public virtual WR_KLADR WR_KLADR3 { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
