namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WAGES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_WAGES()
        {
            CL_WR_WAGE = new HashSet<CL_WR_WAGE>();
            OR_ORDER_WORKER_HISTORY = new HashSet<OR_ORDER_WORKER_HISTORY>();
            WR_WAGES_OPTIONS = new HashSet<WR_WAGES_OPTIONS>();
            WR_WAGES1 = new HashSet<WR_WAGES>();
        }

        [Required]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRG_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRW_COST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRW_COST_INC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRW_HOURS_INC { get; set; }

        [Key]
        public int WRW_ID { get; set; }

        public int? WRW_MASTER_ID { get; set; }

        public int WIC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string WRW_NAME { get; set; }

        public bool IS_MISTAKEN { get; set; }

        public DateTime WRW_DATE_CREATED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_WR_WAGE> CL_WR_WAGE { get; set; }

        public virtual OPT_WORK_TYPES OPT_WORK_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKER_HISTORY> OR_ORDER_WORKER_HISTORY { get; set; }

        public virtual WR_GROUPS WR_GROUPS { get; set; }

        public virtual WR_INTERNAL_CONTRACT WR_INTERNAL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WAGES_OPTIONS> WR_WAGES_OPTIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WAGES> WR_WAGES1 { get; set; }

        public virtual WR_WAGES WR_WAGES2 { get; set; }
    }
}
