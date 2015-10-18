namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMPORARY_WR_DISMISSAL_ITEMS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal OPTD_ID { get; set; }

        public bool IS_CHECKED { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DISM_ITEM_COUNTER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WHO_WRITE_OFF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WHO_GIVE { get; set; }

        public DateTime WHEN_GIVE { get; set; }

        public DateTime WHEN_WRITE_OFF { get; set; }
    }
}
