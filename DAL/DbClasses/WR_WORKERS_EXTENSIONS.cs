namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKERS_EXTENSIONS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal WrExtID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DATA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_WORKERS_EXTENSIONS_TYPE_ID { get; set; }

        public DateTime WR_DATE_CHANGE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal USER_ID { get; set; }

        public virtual WR_WORKERS_EXTENSIONS_TYPE WR_WORKERS_EXTENSIONS_TYPE { get; set; }
    }
}
