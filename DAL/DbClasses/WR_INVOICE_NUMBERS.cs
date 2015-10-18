namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_INVOICE_NUMBERS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal WRIN_ID { get; set; }

        public int DOC_NUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CREATOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CLJN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OURJN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NT_ID { get; set; }

        public int DOC_STATE { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime END_DATE { get; set; }

        public DateTime UNLOADING_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }
    }
}
