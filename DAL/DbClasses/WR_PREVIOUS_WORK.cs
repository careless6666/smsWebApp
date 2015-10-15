namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PREVIOUS_WORK
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WPW_NUM { get; set; }

        [Required]
        [StringLength(250)]
        public string WPW_COMPANY_NAME { get; set; }

        [Required]
        [StringLength(250)]
        public string WPW_COMPANY_ADDRESS { get; set; }

        [Required]
        [StringLength(250)]
        public string WPW_COMPANY_PHONE { get; set; }

        public DateTime WPW_DATE_START { get; set; }

        public DateTime WPW_DATE_END { get; set; }

        [Required]
        [StringLength(250)]
        public string WPW_POSITION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WPW_SALARY { get; set; }

        [Required]
        [StringLength(250)]
        public string WPW_WHY_LEFT { get; set; }
    }
}
