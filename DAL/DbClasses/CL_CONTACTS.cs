namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CONTACTS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CN_ID { get; set; }

        [StringLength(50)]
        public string CN_NAME { get; set; }

        [StringLength(300)]
        public string CN_CONTACT { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [StringLength(100)]
        public string CN_PHONE_2 { get; set; }

        [StringLength(100)]
        public string CN_PHONE_MOBILE { get; set; }

        [StringLength(100)]
        public string CN_MOBILE_2 { get; set; }

        [StringLength(100)]
        public string CN_EMAIL { get; set; }

        [StringLength(100)]
        public string CN_POST { get; set; }

        [StringLength(300)]
        public string CN_COMMENT { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }
    }
}
