namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_USER_ROLES
    {
        [StringLength(100)]
        public string ROL_ROLENAME { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public virtual SC_ROLES SC_ROLES { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
