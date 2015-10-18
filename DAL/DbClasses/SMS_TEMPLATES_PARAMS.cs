namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMS_TEMPLATES_PARAMS
    {
        [Key]
        public int ID_SETTING { get; set; }

        public int ID_FIELD { get; set; }

        public int ID_CONDITION { get; set; }

        public int ID_SMS_TEMPLATE { get; set; }

        public string VALUE { get; set; }

        public virtual SMS_TEMPLATES SMS_TEMPLATES { get; set; }

        public virtual SYS_CONDITIONS SYS_CONDITIONS { get; set; }

        public virtual SYS_FIELDS SYS_FIELDS { get; set; }
    }
}
