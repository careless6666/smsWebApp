namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS
    {
        public int ID { get; set; }

        public int ID_CONDITION { get; set; }

        public int ID_FIELD_TYPE { get; set; }

        public virtual SYS_CONDITIONS SYS_CONDITIONS { get; set; }

        public virtual SYS_FIELDS_TYPES SYS_FIELDS_TYPES { get; set; }
    }
}
