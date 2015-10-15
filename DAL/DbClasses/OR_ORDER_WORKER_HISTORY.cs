namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER_WORKER_HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_ORDER_WORKER_HISTORY()
        {
            AC_ACCRUAL_ORDER = new HashSet<AC_ACCRUAL_ORDER>();
            INV_ITEM_WORKER = new HashSet<INV_ITEM_WORKER>();
        }

        [Key]
        public int OOWH_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public DateTime ORR_WORK_START { get; set; }

        public DateTime ORR_WORK_END { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_COST_HUMAN_HOUR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_COST_UNIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_BONUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_DEBONUS { get; set; }

        public bool ORR_IS_IN_ORDER_BY_DOC { get; set; }

        public bool ORR_IS_IN_ORDER_BY_REAL { get; set; }

        public bool ORR_IS_CALCULATED { get; set; }

        [Required]
        [StringLength(1025)]
        public string ORR_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_CLIENT_BONUS_HOURS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_DINNER_MINUTES { get; set; }

        public bool ORR_IS_CALL_COME { get; set; }

        public bool ORR_IS_CALL_LEAVE { get; set; }

        public bool ORR_FALSE_ALARM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_OUTPUT_TYPE { get; set; }

        public DateTime ORR_EXPECTED_TIME { get; set; }

        public bool ORR_MARK_ABSENT { get; set; }

        public bool OR_NEED_CHANGE { get; set; }

        public bool IS_ORDER_CALC { get; set; }

        public int CLIENT_RATE_ID { get; set; }

        public int WORKER_RATE_ID { get; set; }

        public DateTime EDIT_TIME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_ORDER> AC_ACCRUAL_ORDER { get; set; }

        public virtual CL_RATE CL_RATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ITEM_WORKER> INV_ITEM_WORKER { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual WR_WAGES WR_WAGES { get; set; }

        public virtual OR_ORDER_WORKERS OR_ORDER_WORKERS { get; set; }
    }
}
