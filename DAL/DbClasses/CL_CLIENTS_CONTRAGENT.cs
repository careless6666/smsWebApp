namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CLIENTS_CONTRAGENT
    {
        [Key]
        public int CCGNT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        public int CGNT_ID { get; set; }

        public virtual CGNT_CONTRAGENT CGNT_CONTRAGENT { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }
    }
}
