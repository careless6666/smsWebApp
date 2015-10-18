namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_BANK_SIGNS_RESP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BSR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SCUP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AB_ID { get; set; }

        public virtual AC_BANKS AC_BANKS { get; set; }

        public virtual SC_UNIT_PLACES SC_UNIT_PLACES { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
