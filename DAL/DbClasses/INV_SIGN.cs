namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_SIGN
    {
        [Key]
        public int INV_SIGN_ID { get; set; }

        public int INV_ID { get; set; }

        public int INV_SIGN_TYPE_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string NAME { get; set; }

        public virtual INV_INVOICE INV_INVOICE { get; set; }

        public virtual INV_SIGN_TYPE INV_SIGN_TYPE { get; set; }
    }
}
