namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_ACTUAL_SETTINGS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CAS_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAST_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAC_ID { get; set; }

        public virtual CL_ACTUAL_CONFIGURATIONS CL_ACTUAL_CONFIGURATIONS { get; set; }

        public virtual CL_ACTUAL_SETTINGS_TRANSACTIONS CL_ACTUAL_SETTINGS_TRANSACTIONS { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }
    }
}
