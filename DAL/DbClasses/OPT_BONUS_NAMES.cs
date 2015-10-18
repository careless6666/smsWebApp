namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_BONUS_NAMES
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal OBN_ID { get; set; }

        [StringLength(50)]
        public string OBN_NAME { get; set; }

        public bool IS_DINNER { get; set; }

        public bool IS_ACTIVE { get; set; }
    }
}
