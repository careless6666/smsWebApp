namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_ACCURAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AC_ACCURAL()
        {
            AC_ACCRUAL_CHARGE = new HashSet<AC_ACCRUAL_CHARGE>();
            AC_ACCRUAL_KEEPING = new HashSet<AC_ACCRUAL_KEEPING>();
            AC_ACCRUAL_ORDER = new HashSet<AC_ACCRUAL_ORDER>();
            AC_ACCRUAL_RECRUITER = new HashSet<AC_ACCRUAL_RECRUITER>();
            AC_ACCRUAL_WR_CHARGE = new HashSet<AC_ACCRUAL_WR_CHARGE>();
            AC_ACCRUALS_WORKER_ACTION_PAYMENTS = new HashSet<AC_ACCRUALS_WORKER_ACTION_PAYMENTS>();
            ACTION_PAYMENTS_HISTORY = new HashSet<ACTION_PAYMENTS_HISTORY>();
            WR_PAYMENT_HISTORY_ACCRUAL = new HashSet<WR_PAYMENT_HISTORY_ACCRUAL>();
            AC_INTEGRATION_TRANSFERS_ACCURALS = new HashSet<AC_INTEGRATION_TRANSFERS_ACCURALS>();
            WR_DISMISSAL_HIST_ACCRUAL = new HashSet<WR_DISMISSAL_HIST_ACCRUAL>();
            WR_PAYMENT_ACCRUALS = new HashSet<WR_PAYMENT_ACCRUALS>();
            tmp_calc_worker = new HashSet<tmp_calc_worker>();
        }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ACC_ID { get; set; }

        [StringLength(300)]
        public string ACC_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACC_SUM { get; set; }

        public DateTime ACC_DATETIME { get; set; }

        public int AAT_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_CHARGE> AC_ACCRUAL_CHARGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_KEEPING> AC_ACCRUAL_KEEPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_ORDER> AC_ACCRUAL_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_RECRUITER> AC_ACCRUAL_RECRUITER { get; set; }

        public virtual AC_ACCRUAL_TYPE AC_ACCRUAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUAL_WR_CHARGE> AC_ACCRUAL_WR_CHARGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCRUALS_WORKER_ACTION_PAYMENTS> AC_ACCRUALS_WORKER_ACTION_PAYMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTION_PAYMENTS_HISTORY> ACTION_PAYMENTS_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PAYMENT_HISTORY_ACCRUAL> WR_PAYMENT_HISTORY_ACCRUAL { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_INTEGRATION_TRANSFERS_ACCURALS> AC_INTEGRATION_TRANSFERS_ACCURALS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_DISMISSAL_HIST_ACCRUAL> WR_DISMISSAL_HIST_ACCRUAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PAYMENT_ACCRUALS> WR_PAYMENT_ACCRUALS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmp_calc_worker> tmp_calc_worker { get; set; }
    }
}
