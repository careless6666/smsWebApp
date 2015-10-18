namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class db_updates
    {
        public Guid id { get; set; }

        [Required]
        public string name { get; set; }

        public DateTime update_date { get; set; }

        public bool is_completed { get; set; }
    }
}
