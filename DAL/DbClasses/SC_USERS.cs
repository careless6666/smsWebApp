namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SC_USERS()
        {
            AC_ACCURAL = new HashSet<AC_ACCURAL>();
            AC_BANKS_UNITS = new HashSet<AC_BANKS_UNITS>();
            AC_INTEGRATION_TRANSFERS = new HashSet<AC_INTEGRATION_TRANSFERS>();
            AC_INTEGRATION_TRANSFERS1 = new HashSet<AC_INTEGRATION_TRANSFERS>();
            BANK_TRANSFERS_HISTORY = new HashSet<BANK_TRANSFERS_HISTORY>();
            CC_CALL_RESULTS = new HashSet<CC_CALL_RESULTS>();
            CC_IPTEL_LOGS = new HashSet<CC_IPTEL_LOGS>();
            CC_MANAGER_TASK = new HashSet<CC_MANAGER_TASK>();
            CC_WORKER_REMINDS = new HashSet<CC_WORKER_REMINDS>();
            CL_ACTUAL_SETTINGS_TRANSACTIONS = new HashSet<CL_ACTUAL_SETTINGS_TRANSACTIONS>();
            CL_BLACKLIST = new HashSet<CL_BLACKLIST>();
            CL_CLIENTS_USERS = new HashSet<CL_CLIENTS_USERS>();
            CL_CLOSED_PERIODS = new HashSet<CL_CLOSED_PERIODS>();
            CL_CONTRACT = new HashSet<CL_CONTRACT>();
            CL_CONTRACT1 = new HashSet<CL_CONTRACT>();
            FUN_MAGIC_BUTTON = new HashSet<FUN_MAGIC_BUTTON>();
            INV_HISTORY = new HashSet<INV_HISTORY>();
            INV_INVOICE = new HashSet<INV_INVOICE>();
            INV_SENT_EMAILS = new HashSet<INV_SENT_EMAILS>();
            INV_SENT_EMAILS1 = new HashSet<INV_SENT_EMAILS>();
            LE_OBLIGATION_HISTORY = new HashSet<LE_OBLIGATION_HISTORY>();
            LOG_CC_IN_OUT = new HashSet<LOG_CC_IN_OUT>();
            NT_BLACKLIST = new HashSet<NT_BLACKLIST>();
            OR_LUOV = new HashSet<OR_LUOV>();
            OR_ORDER_COSTS_HISTORY = new HashSet<OR_ORDER_COSTS_HISTORY>();
            OR_ORDER_HISTORY = new HashSet<OR_ORDER_HISTORY>();
            OR_ORDER_WORKER_HISTORY = new HashSet<OR_ORDER_WORKER_HISTORY>();
            SC_BANK_SIGNS_RESP = new HashSet<SC_BANK_SIGNS_RESP>();
            WR_CHARGE_HISTORY = new HashSet<WR_CHARGE_HISTORY>();
            WR_INTERNAL_CONTRACT = new HashSet<WR_INTERNAL_CONTRACT>();
            WR_INTERNAL_CONTRACT1 = new HashSet<WR_INTERNAL_CONTRACT>();
            WR_INTERNAL_CONTRACT2 = new HashSet<WR_INTERNAL_CONTRACT>();
            WR_KEEPING = new HashSet<WR_KEEPING>();
            WR_KEEPING_HISTORY = new HashSet<WR_KEEPING_HISTORY>();
            WR_PENALTY_HISTORY = new HashSet<WR_PENALTY_HISTORY>();
            WR_RECRUITER_PERIOD_HISTORY = new HashSet<WR_RECRUITER_PERIOD_HISTORY>();
            WR_BANK_PROFILES = new HashSet<WR_BANK_PROFILES>();
            WR_CARDS_LOST = new HashSet<WR_CARDS_LOST>();
            WR_LABOR_CONTRACTS = new HashSet<WR_LABOR_CONTRACTS>();
            WR_PAYMENT_HISTORY = new HashSet<WR_PAYMENT_HISTORY>();
            WR_WORKER_VACATIONS = new HashSet<WR_WORKER_VACATIONS>();
            TMP_RETURN_KEEPING = new HashSet<TMP_RETURN_KEEPING>();
            CC_IPTEL_TASKS = new HashSet<CC_IPTEL_TASKS>();
            SC_UNIT = new HashSet<SC_UNIT>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [StringLength(20)]
        public string US_USERNAME { get; set; }

        public string US_PASSWORD { get; set; }

        [StringLength(100)]
        public string ROL_ROLENAME { get; set; }

        [StringLength(100)]
        public string US_FAMILY_NAME { get; set; }

        [StringLength(100)]
        public string US_FATHER_NAME { get; set; }

        [StringLength(100)]
        public string US_NAME { get; set; }

        public string US_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UN_ID { get; set; }

        public DateTime? US_PASSSET { get; set; }

        public bool US_ALLOWINTERNET { get; set; }

        [Required]
        [StringLength(512)]
        public string US_EMAIL { get; set; }

        public bool IS_PASSWORD_RESET { get; set; }

        [Required]
        [StringLength(255)]
        public string SCU_LDAP_ACCOUNT { get; set; }

        public bool SCU_IS_SYSTEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCURAL> AC_ACCURAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_BANKS_UNITS> AC_BANKS_UNITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_INTEGRATION_TRANSFERS> AC_INTEGRATION_TRANSFERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_INTEGRATION_TRANSFERS> AC_INTEGRATION_TRANSFERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANK_TRANSFERS_HISTORY> BANK_TRANSFERS_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_CALL_RESULTS> CC_CALL_RESULTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_LOGS> CC_IPTEL_LOGS { get; set; }

        public virtual CC_IPTEL_USERS_STATUSES CC_IPTEL_USERS_STATUSES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_MANAGER_TASK> CC_MANAGER_TASK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_WORKER_REMINDS> CC_WORKER_REMINDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_ACTUAL_SETTINGS_TRANSACTIONS> CL_ACTUAL_SETTINGS_TRANSACTIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_BLACKLIST> CL_BLACKLIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS_USERS> CL_CLIENTS_USERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLOSED_PERIODS> CL_CLOSED_PERIODS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT> CL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT> CL_CONTRACT1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FUN_MAGIC_BUTTON> FUN_MAGIC_BUTTON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_HISTORY> INV_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_INVOICE> INV_INVOICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_SENT_EMAILS> INV_SENT_EMAILS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_SENT_EMAILS> INV_SENT_EMAILS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LE_OBLIGATION_HISTORY> LE_OBLIGATION_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOG_CC_IN_OUT> LOG_CC_IN_OUT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NT_BLACKLIST> NT_BLACKLIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_LUOV> OR_LUOV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_COSTS_HISTORY> OR_ORDER_COSTS_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_HISTORY> OR_ORDER_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKER_HISTORY> OR_ORDER_WORKER_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_BANK_SIGNS_RESP> SC_BANK_SIGNS_RESP { get; set; }

        public virtual SC_ROLES SC_ROLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE_HISTORY> WR_CHARGE_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_INTERNAL_CONTRACT> WR_INTERNAL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_INTERNAL_CONTRACT> WR_INTERNAL_CONTRACT1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_INTERNAL_CONTRACT> WR_INTERNAL_CONTRACT2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_KEEPING> WR_KEEPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_KEEPING_HISTORY> WR_KEEPING_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PENALTY_HISTORY> WR_PENALTY_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER_PERIOD_HISTORY> WR_RECRUITER_PERIOD_HISTORY { get; set; }

        public virtual WR_SUPERVISORS WR_SUPERVISORS { get; set; }

        public virtual SC_USER_ROLES SC_USER_ROLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_BANK_PROFILES> WR_BANK_PROFILES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CARDS_LOST> WR_CARDS_LOST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_LABOR_CONTRACTS> WR_LABOR_CONTRACTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PAYMENT_HISTORY> WR_PAYMENT_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_VACATIONS> WR_WORKER_VACATIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TMP_RETURN_KEEPING> TMP_RETURN_KEEPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_TASKS> CC_IPTEL_TASKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_UNIT> SC_UNIT { get; set; }
    }
}
