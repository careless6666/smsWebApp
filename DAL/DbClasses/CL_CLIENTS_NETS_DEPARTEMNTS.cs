namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CLIENTS_NETS_DEPARTEMNTS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal CND_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ND_ID { get; set; }

        public bool IS_ACTIVE { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        public virtual CL_NETS_DEPARTMENTS CL_NETS_DEPARTMENTS { get; set; }
    }
}
