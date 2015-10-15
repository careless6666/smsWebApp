namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_REGIONAL_SMS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OSMST_ID { get; set; }

        public bool IsActive { get; set; }

        [StringLength(512)]
        public string OverrideText { get; set; }

        public virtual OPT_SMS_TEMPLATES OPT_SMS_TEMPLATES { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
