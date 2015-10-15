namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_SMS_EVENTS_VARIABLES
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SMS_EVENT { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SMS_VARIABLE { get; set; }

        public virtual OPT_SMS_EVENTS OPT_SMS_EVENTS { get; set; }

        public virtual OPT_SMS_VARIABLES OPT_SMS_VARIABLES { get; set; }
    }
}
