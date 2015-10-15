namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_ROLES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SC_ROLES()
        {
            SC_USER_ROLES = new HashSet<SC_USER_ROLES>();
            SC_USERS = new HashSet<SC_USERS>();
        }

        [Key]
        [StringLength(100)]
        public string ROL_ROLENAME { get; set; }

        public bool? ROL_USE_ADMIN { get; set; }

        public bool? ROL_USE_ADD_WORKER { get; set; }

        public bool? ROL_USE_SEE_WORKER { get; set; }

        public bool? ROL_USE_LIST_WORKER { get; set; }

        public bool? ROL_USE_ADD_CLIENT { get; set; }

        public bool? ROL_USE_LIST_CLIENT { get; set; }

        public bool? ROL_USE_ADD_ORDER { get; set; }

        public bool? ROL_USE_PRINT_BAGES { get; set; }

        public bool? ROL_USE_CLIENT_DETAILS { get; set; }

        public bool? ROL_USE_WORKER_CALL { get; set; }

        public bool? ROL_USE_WORKER_CALCULATION { get; set; }

        public bool? ROL_USE_CASH_REPORT { get; set; }

        public bool? ROL_USE_WORKER_MANAGER_REP { get; set; }

        public bool? ROL_USE_CC_MAN_REP { get; set; }

        public bool? ROL_USE_REP_WORKED_HOURS { get; set; }

        public bool? ROL_USE_WORKER_BONUS { get; set; }

        public bool ROL_USE_CC_MONEY_GIVE_REPORT { get; set; }

        public bool ROL_USE_AUTHORIZATION_VIEW { get; set; }

        public bool ROL_USE_GIVE_BANK_CARD { get; set; }

        public bool ROL_USE_CALLCENTER_CAMPAIGNS { get; set; }

        public bool ROL_USE_MANAGE_CAMPAIGN { get; set; }

        public bool ROL_USE_NONCASHMANAGE { get; set; }

        public bool ROL_USE_COVERMAIL { get; set; }

        public bool ROL_USE_MEDICAL_BOOK { get; set; }

        public bool ROL_USE_WORKER_CALC_PREVIEW { get; set; }

        public bool ROL_USE_WORKER_CALC_CALC { get; set; }

        public bool ROL_USE_BLACK_LIST { get; set; }

        public bool ROL_USE_REP_AD_EFFICACY { get; set; }

        public bool ROL_USE_REP_MAN_OC { get; set; }

        public bool ROL_USE_REP_OUTGO { get; set; }

        public bool ROL_USE_LIST_ORDERS_CC { get; set; }

        public bool ROL_USE_CAMPAIGN_TYPE_EDIT { get; set; }

        public bool ROL_USE_UNDISMISS { get; set; }

        public bool ROL_USE_CALC_CLOSED_ORDERS { get; set; }

        public bool ROL_USE_ADD_ORDER_INPAST { get; set; }

        public bool ROL_USE_JURI_NAMES { get; set; }

        public bool ROL_USE_INTERVIEW_REPORT { get; set; }

        public bool ROL_USE_REP_RECRUITER_ACCURALS { get; set; }

        public bool ROL_USE_REP_SALARY_ACCURALS { get; set; }

        public bool ROL_USE_REP_WORKER_CALCS { get; set; }

        public bool ROL_USE_REP_WORKERS_TAKEOUTS_DAMPED { get; set; }

        public bool ROL_USE_REASSIGN_BANK_CARDS { get; set; }

        public bool ROL_USE_SECURITY_SERVICE { get; set; }

        public bool ROL_USE_TRAINING_CTR_MANAGE_ORDERS { get; set; }

        public bool ROL_USE_TRAINING_CTR_CALLIN { get; set; }

        public bool ROL_USE_REP_W_STATUSES { get; set; }

        public bool ROL_USE_REP_СС_CALL_RESULTS { get; set; }

        public bool ROL_USE_SUPERVISOR_LIST { get; set; }

        public bool ROL_USE_CHANGE_CALC_TYPE { get; set; }

        public bool ROL_USE_REM_PAYM_CC { get; set; }

        public bool ROL_USE_REM_PAYM_MRPTC { get; set; }

        public bool ROL_USE_COVER_MAIL_TEMPLATES { get; set; }

        public bool ROL_USE_EDIT_AD { get; set; }

        public bool ROL_USE_REP_FIN_1C { get; set; }

        public bool ROL_USE_WAGES_EDIT { get; set; }

        public bool ROL_USE_NET_BLACK_LIST { get; set; }

        public bool ROL_USE_WORKER_BIG_CALC { get; set; }

        public bool? ROL_USE_ADD_DOCS_TO_FMS { get; set; }

        public bool? ROL_USE_HOSTELS_PAGE { get; set; }

        public bool ROL_USE_INTERVIEWS { get; set; }

        public bool? ROL_USE_ORDER_POST_EDIT { get; set; }

        public bool ROL_USE_MANAGER_GENERATE_CALL_TASK { get; set; }

        public bool ROL_USE_ACTUALISATION_CONFIGURATION { get; set; }

        public bool ROL_USE_ADD_LENTA_WORKER { get; set; }

        public bool ROL_USE_CALC_LENTA_WORKER { get; set; }

        public bool ROL_USE_CLIENT_MANAGER_RIGHTS { get; set; }

        public bool? ROL_USE_WRITE_OFF_WEALTH { get; set; }

        public bool ROL_USE_SAVE_DEFAULT_MAIL_TEMPLATE { get; set; }

        public bool ROL_USE_ADD_DEPARTMENT { get; set; }

        public bool ROL_USE_BIND_NET_DEPARTMENT { get; set; }

        public bool? ROL_USE_KEEP_ALL_ONCE { get; set; }

        public bool? ROL_USE_CALC_ACTIVE_ORDERS { get; set; }

        public bool? ROL_USE_ADD_NET { get; set; }

        public bool ROL_USE_ADD_CONTRACT { get; set; }

        public bool ROL_USE_VIEW_CONTRACT { get; set; }

        public bool ROL_USE_ADD_EDIT_ORDER_RATE { get; set; }

        public bool ROL_USE_VIEW_ORDER_RATE { get; set; }

        public bool ROL_USE_COMPARISON_WORK_TYPES { get; set; }

        public bool ROL_USE_JURI_SIGNERS { get; set; }

        public bool ROL_USE_FORM_INVOICE { get; set; }

        public bool ROL_USE_MASS_CHANGE_AGREEMENTS { get; set; }

        public bool ROL_USE_INVOICE_LIST { get; set; }

        public bool ROL_USE_INVOICE_DETAIL { get; set; }

        public bool ROL_USE_INVOICE_STATUS_REPORT { get; set; }

        public bool ROL_USE_IGNORE_ANOTHER_ORDER_CHECK { get; set; }

        public bool ROL_USE_CHANGE_INVOICE_STATUS { get; set; }

        public bool? ROL_USE_TRAINING_CENTRES_LIST { get; set; }

        public bool ROL_USE_EDIT_CONTRACT { get; set; }

        public bool ROL_USE_MASS_WORKER_CALCULATION { get; set; }

        public bool ROL_USE_DETAIL_VIEW_JURI_NAMES { get; set; }

        public bool ROL_USE_DELETE_JURI_NAMES { get; set; }

        public bool ROL_USE_UPLOAD_NDFL_LIST { get; set; }

        public bool ROL_USE_ENABLED_KEEPING { get; set; }

        public bool ROL_USE_ENABLED_CANCEL_KEEPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_USER_ROLES> SC_USER_ROLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_USERS> SC_USERS { get; set; }
    }
}
