namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_PLACES_SMS
    {
        public int ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SCUP_ID { get; set; }

        public int OSMST_ID { get; set; }

        public virtual OPT_SMS_TEMPLATES OPT_SMS_TEMPLATES { get; set; }

        public virtual SC_UNIT_PLACES SC_UNIT_PLACES { get; set; }
    }
}
