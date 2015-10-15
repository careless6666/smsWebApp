namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMS_TEMPLATES_HISTORY
    {
        public int ID { get; set; }

        public int ID_SMS_TEMPLATE { get; set; }

        public DateTime EDIT_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public string COMMENT { get; set; }

        public virtual SMS_TEMPLATES SMS_TEMPLATES { get; set; }
    }
}
