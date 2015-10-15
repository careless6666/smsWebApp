namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALFA_NEW_REGIONS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KLADR_ID { get; set; }

        [StringLength(16)]
        public string ALFA_ID { get; set; }

        [StringLength(16)]
        public string ALFA_TYPE { get; set; }
    }
}
