namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_EDUCATION
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WE_NUM { get; set; }

        [Required]
        [StringLength(250)]
        public string WE_NAME { get; set; }

        [Required]
        [StringLength(250)]
        public string WE_TYPE { get; set; }

        [Required]
        [StringLength(250)]
        public string WE_PROFESSION { get; set; }

        public DateTime WE_DATE_START { get; set; }

        public DateTime WE_DATE_END { get; set; }
    }
}
