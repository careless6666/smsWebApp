namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_ORDER()
        {
            CC_CALL_RESULTS = new HashSet<CC_CALL_RESULTS>();
            CC_IPTEL_LOGS = new HashSet<CC_IPTEL_LOGS>();
            CC_IPTEL_TASK_ORDER = new HashSet<CC_IPTEL_TASK_ORDER>();
            CC_WORKER_REMINDS = new HashSet<CC_WORKER_REMINDS>();
            OR_ORDER_COSTS = new HashSet<OR_ORDER_COSTS>();
            OR_ORDER_HISTORY = new HashSet<OR_ORDER_HISTORY>();
            OR_RANGE_REQUIREMENTS = new HashSet<OR_RANGE_REQUIREMENTS>();
            WR_RECRUITER_HISTORY = new HashSet<WR_RECRUITER_HISTORY>();
            OR_ORDER_COMMENTS = new HashSet<OR_ORDER_COMMENTS>();
            OR_PRE_ADD = new HashSet<OR_PRE_ADD>();
            OR_QUEUE_ACTUALISATION = new HashSet<OR_QUEUE_ACTUALISATION>();
            WR_ACTION_15x15 = new HashSet<WR_ACTION_15x15>();
            OR_ORDER_WORKERS = new HashSet<OR_ORDER_WORKERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal OR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CL_ID { get; set; }

        [StringLength(50)]
        public string WT_NAME { get; set; }

        public DateTime? OR_DATE { get; set; }

        public DateTime? OR_START_TIME { get; set; }

        public DateTime? OR_END_TIME { get; set; }

        [StringLength(300)]
        public string OR_ADDRESS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OR_WORKERS_COUNT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OR_COST_HUMAN_HOUR { get; set; }

        public bool? OR_IS_CLOSED { get; set; }

        [StringLength(8000)]
        public string OR_HOW_TO_GET { get; set; }

        [StringLength(8000)]
        public string OR_COMMENT { get; set; }

        [StringLength(100)]
        public string OR_DEPARTMENT { get; set; }

        public DateTime? OR_DATECREATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OR_WH_LIST_NUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OR_COST_UNIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_POSITION_LAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_POSITION_LNG { get; set; }

        public bool OR_IS_COVEREMAIL_SENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_US_ID_CREATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_US_ID_CLOSE { get; set; }

        public DateTime OR_CREATE_DATETIME { get; set; }

        public DateTime OR_CLOSE_DATETIME { get; set; }

        public bool OR_IS_COVEREMAIL_ERROR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID_COVEREMAIL { get; set; }

        public bool OR_IS_MISTAKEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_GENDER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OR_PRIORITY { get; set; }

        public bool OR_IS_TECHNICAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CND_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_CALL_RESULTS> CC_CALL_RESULTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_LOGS> CC_IPTEL_LOGS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_TASK_ORDER> CC_IPTEL_TASK_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_WORKER_REMINDS> CC_WORKER_REMINDS { get; set; }

        public virtual CL_CLIENTS CL_CLIENTS { get; set; }

        public virtual CL_PRIORITY CL_PRIORITY { get; set; }

        public virtual OPT_WORK_TYPES OPT_WORK_TYPES { get; set; }

        public virtual OR_LUOV OR_LUOV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_COSTS> OR_ORDER_COSTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_HISTORY> OR_ORDER_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_RANGE_REQUIREMENTS> OR_RANGE_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER_HISTORY> WR_RECRUITER_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_COMMENTS> OR_ORDER_COMMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_PRE_ADD> OR_PRE_ADD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_QUEUE_ACTUALISATION> OR_QUEUE_ACTUALISATION { get; set; }

        public virtual OR_TRAIN_CENTER_AVAILABLE OR_TRAIN_CENTER_AVAILABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_ACTION_15x15> WR_ACTION_15x15 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKERS> OR_ORDER_WORKERS { get; set; }
    }
}
