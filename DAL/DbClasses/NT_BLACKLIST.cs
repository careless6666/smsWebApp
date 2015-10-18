namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NT_BLACKLIST
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal NT_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Required]
        [StringLength(926)]
        public string NTBL_COMMENT { get; set; }

        public DateTime NTBL_ADDED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? US_ID { get; set; }

        public virtual CL_NETS CL_NETS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
