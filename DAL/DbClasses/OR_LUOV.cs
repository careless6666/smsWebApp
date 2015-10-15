namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_LUOV
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string ORL_FILENAME { get; set; }

        [Required]
        public byte[] ORL_CONTENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORL_USER_SUBMITTED { get; set; }

        public DateTime? ORL_SUBMITTED_TIME { get; set; }

        public bool ORL_MARK_DELETED { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
