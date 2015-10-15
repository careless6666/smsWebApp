namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER_WORKERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_ORDER_WORKERS()
        {
            ACTION_PAYMENTS = new HashSet<ACTION_PAYMENTS>();
            OR_ORDER_WORKER_HISTORY = new HashSet<OR_ORDER_WORKER_HISTORY>();
            CGN_CAMPAIGN = new HashSet<CGN_CAMPAIGN>();
        }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal OR_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        public DateTime? ORR_WORK_START { get; set; }

        public DateTime? ORR_WORK_END { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORR_COST_HUMAN_HOUR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORR_BONUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORR_DEBONUS { get; set; }

        public bool? ORR_IS_IN_ORDER_BY_DOC { get; set; }

        public bool? ORR_IS_IN_ORDER_BY_REAL { get; set; }

        public bool? ORR_IS_CALCULATED { get; set; }

        [StringLength(1025)]
        public string ORR_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORR_COST_UNIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_CLIENT_BONUS_HOURS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_DINNER_MINUTES { get; set; }

        public bool ORR_IS_CALL_COME { get; set; }

        public bool ORR_IS_CALL_LEAVE { get; set; }

        public DateTime ORR_WORKER_ADDED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_US_ID_ADD { get; set; }

        public bool ORR_FALSE_ALARM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORR_OUTPUT_TYPE { get; set; }

        public DateTime ORR_EXPECTED_TIME { get; set; }

        public bool ORR_MARK_ABSENT { get; set; }

        public bool OR_NEED_CHANGE { get; set; }

        public bool ORR_MARK_REMEMBER { get; set; }

        [StringLength(1025)]
        public string ORR_CC_FALSE_ALARM_COMMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTION_PAYMENTS> ACTION_PAYMENTS { get; set; }

        public virtual OPT_OUTPUT_TYPE OPT_OUTPUT_TYPE { get; set; }

        public virtual OR_ORDER OR_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKER_HISTORY> OR_ORDER_WORKER_HISTORY { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }

        public virtual OR_TRAIN_CENTER_WORKERS OR_TRAIN_CENTER_WORKERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGN_CAMPAIGN> CGN_CAMPAIGN { get; set; }
    }
}
