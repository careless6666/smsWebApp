namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMS_SEND_CONDITIONS_PARAMS
    {
        public int ID_TYPE { get; set; }

        public int ID_SMS_TEMPLATE { get; set; }

        public string VALUE { get; set; }

        public int ID_SMS_SEND_CONDITIONS { get; set; }

        public int ID { get; set; }

        public virtual SMS_SEND_CONDITIONS SMS_SEND_CONDITIONS { get; set; }

        public virtual SMS_SEND_CONDITIONS_TYPES SMS_SEND_CONDITIONS_TYPES { get; set; }

        public virtual SMS_TEMPLATES SMS_TEMPLATES { get; set; }
    }
}
