namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_IMAGES
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal IN_ID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal WRI_NUM { get; set; }

        [StringLength(50)]
        public string WRI_PATH { get; set; }

        [StringLength(50)]
        public string WRI_COMMENT { get; set; }

        public virtual OPT_IMG_NAMES OPT_IMG_NAMES { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
