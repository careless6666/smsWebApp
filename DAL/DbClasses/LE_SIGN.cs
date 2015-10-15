namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LE_SIGN
    {
        [Key]
        public int LE_SIGN_ID { get; set; }

        public int CLJN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public int INV_SIGN_TYPE_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string NAME { get; set; }

        public virtual CL_JURI_NAMES CL_JURI_NAMES { get; set; }

        public virtual INV_SIGN_TYPE INV_SIGN_TYPE { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
