namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_BLOCK
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public DateTime? CC_BLOCK_TILL { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string CC_BLOCKED_PHONE { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BLOCK_TYPE { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
