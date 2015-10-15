namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_HISTORY
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WRH_ID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime WRH_DATETIME { get; set; }

        [Required]
        [StringLength(926)]
        public string WRH_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRH_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WRH_NEW_STATUS { get; set; }

        public virtual OPT_STATUSES OPT_STATUSES { get; set; }
    }
}
