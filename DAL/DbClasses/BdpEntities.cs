namespace DAL.DbClasses
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BdpEntities : DbContext
    {
        public BdpEntities()
            : base("name=BdpEntities")
        {
        }

        public virtual DbSet<AC_ACCRUAL_CHARGE> AC_ACCRUAL_CHARGE { get; set; }
        public virtual DbSet<AC_ACCRUAL_KEEPING> AC_ACCRUAL_KEEPING { get; set; }
        public virtual DbSet<AC_ACCRUAL_ORDER> AC_ACCRUAL_ORDER { get; set; }
        public virtual DbSet<AC_ACCRUAL_RECRUITER> AC_ACCRUAL_RECRUITER { get; set; }
        public virtual DbSet<AC_ACCRUAL_TYPE> AC_ACCRUAL_TYPE { get; set; }
        public virtual DbSet<AC_ACCRUAL_WR_CHARGE> AC_ACCRUAL_WR_CHARGE { get; set; }
        public virtual DbSet<AC_ACCRUALS_WORKER_ACTION_PAYMENTS> AC_ACCRUALS_WORKER_ACTION_PAYMENTS { get; set; }
        public virtual DbSet<AC_ACCURAL> AC_ACCURAL { get; set; }
        public virtual DbSet<AC_BANKS> AC_BANKS { get; set; }
        public virtual DbSet<AC_BANKS_UNITS> AC_BANKS_UNITS { get; set; }
        public virtual DbSet<AC_BANKS_UNITS_ACTIONS> AC_BANKS_UNITS_ACTIONS { get; set; }
        public virtual DbSet<AC_INTEGRATION_TRANSFERS> AC_INTEGRATION_TRANSFERS { get; set; }
        public virtual DbSet<AC_INTEGRATION_TRANSFERS_ACCURALS> AC_INTEGRATION_TRANSFERS_ACCURALS { get; set; }
        public virtual DbSet<AC_INTEGRATION_TRANSFERS_PAYMENT> AC_INTEGRATION_TRANSFERS_PAYMENT { get; set; }
        public virtual DbSet<AC_MONEY_HIST> AC_MONEY_HIST { get; set; }
        public virtual DbSet<ACT_ACTION_NUMBER_SHIFTS> ACT_ACTION_NUMBER_SHIFTS { get; set; }
        public virtual DbSet<ACT_ACTIONS> ACT_ACTIONS { get; set; }
        public virtual DbSet<ACTION> ACTIONs { get; set; }
        public virtual DbSet<ACTION_PAYMENTS> ACTION_PAYMENTS { get; set; }
        public virtual DbSet<ACTION_PAYMENTS_HISTORY> ACTION_PAYMENTS_HISTORY { get; set; }
        public virtual DbSet<ALFA_NEW_REGIONS> ALFA_NEW_REGIONS { get; set; }
        public virtual DbSet<ARCH_STATUSES> ARCH_STATUSES { get; set; }
        public virtual DbSet<BANK_TRANSFERS> BANK_TRANSFERS { get; set; }
        public virtual DbSet<BANK_TRANSFERS_HISTORY> BANK_TRANSFERS_HISTORY { get; set; }
        public virtual DbSet<BANK_TRANSFERS_PAYMENT_HISTORY> BANK_TRANSFERS_PAYMENT_HISTORY { get; set; }
        public virtual DbSet<BANK_TRANSFERS_STATUS> BANK_TRANSFERS_STATUS { get; set; }
        public virtual DbSet<CC_BLOCK> CC_BLOCK { get; set; }
        public virtual DbSet<CC_CALL_RESULT_TYPES> CC_CALL_RESULT_TYPES { get; set; }
        public virtual DbSet<CC_CALL_RESULTS> CC_CALL_RESULTS { get; set; }
        public virtual DbSet<CC_CALLBACK_BLOCK> CC_CALLBACK_BLOCK { get; set; }
        public virtual DbSet<CC_IPTEL_CALL_RESULT_TYPES> CC_IPTEL_CALL_RESULT_TYPES { get; set; }
        public virtual DbSet<CC_IPTEL_CALL_RESULTS> CC_IPTEL_CALL_RESULTS { get; set; }
        public virtual DbSet<CC_IPTEL_LOG_TYPES> CC_IPTEL_LOG_TYPES { get; set; }
        public virtual DbSet<CC_IPTEL_LOGS> CC_IPTEL_LOGS { get; set; }
        public virtual DbSet<CC_IPTEL_SID_INFO> CC_IPTEL_SID_INFO { get; set; }
        public virtual DbSet<CC_IPTEL_TASK_CAMPAIGN> CC_IPTEL_TASK_CAMPAIGN { get; set; }
        public virtual DbSet<CC_IPTEL_TASK_ORDER> CC_IPTEL_TASK_ORDER { get; set; }
        public virtual DbSet<CC_IPTEL_TASK_PRIORITY> CC_IPTEL_TASK_PRIORITY { get; set; }
        public virtual DbSet<CC_IPTEL_TASK_STATUS> CC_IPTEL_TASK_STATUS { get; set; }
        public virtual DbSet<CC_IPTEL_TASK_TYPES> CC_IPTEL_TASK_TYPES { get; set; }
        public virtual DbSet<CC_IPTEL_TASKS> CC_IPTEL_TASKS { get; set; }
        public virtual DbSet<CC_IPTEL_USERS_STATUSES> CC_IPTEL_USERS_STATUSES { get; set; }
        public virtual DbSet<CC_IPTEL_WKAC> CC_IPTEL_WKAC { get; set; }
        public virtual DbSet<CC_MANAGER_TASK> CC_MANAGER_TASK { get; set; }
        public virtual DbSet<CC_MANAGER_TASK_CANDIDATES> CC_MANAGER_TASK_CANDIDATES { get; set; }
        public virtual DbSet<CC_MANAGER_TASK_TYPE> CC_MANAGER_TASK_TYPE { get; set; }
        public virtual DbSet<CC_MANAGER_TASK_WORKERS> CC_MANAGER_TASK_WORKERS { get; set; }
        public virtual DbSet<CC_RECALL_TASK> CC_RECALL_TASK { get; set; }
        public virtual DbSet<CC_REG_GIVE_MONEY> CC_REG_GIVE_MONEY { get; set; }
        public virtual DbSet<CC_WORKER_REMINDS> CC_WORKER_REMINDS { get; set; }
        public virtual DbSet<CGN_BONUS_OPTIONS> CGN_BONUS_OPTIONS { get; set; }
        public virtual DbSet<CGN_CAMPAIGN> CGN_CAMPAIGN { get; set; }
        public virtual DbSet<CGN_CAMPAIGN_ACTUALS> CGN_CAMPAIGN_ACTUALS { get; set; }
        public virtual DbSet<CGN_CAMPAIGN_REQUIREMENTS> CGN_CAMPAIGN_REQUIREMENTS { get; set; }
        public virtual DbSet<CGN_CAMPAIGN_TYPES> CGN_CAMPAIGN_TYPES { get; set; }
        public virtual DbSet<CGN_CAMPAIGN_WORK_TYPES> CGN_CAMPAIGN_WORK_TYPES { get; set; }
        public virtual DbSet<CGN_CAMPAIGN_WORKERS> CGN_CAMPAIGN_WORKERS { get; set; }
        public virtual DbSet<CGN_QUEUE_ACTUALISATION> CGN_QUEUE_ACTUALISATION { get; set; }
        public virtual DbSet<CGNT_BILL> CGNT_BILL { get; set; }
        public virtual DbSet<CGNT_BILL_ITEM> CGNT_BILL_ITEM { get; set; }
        public virtual DbSet<CGNT_CONTRAGENT> CGNT_CONTRAGENT { get; set; }
        public virtual DbSet<CGNT_FIN_UNIT> CGNT_FIN_UNIT { get; set; }
        public virtual DbSet<CGNT_FIN_UNIT_UNIT> CGNT_FIN_UNIT_UNIT { get; set; }
        public virtual DbSet<CL_ACTUAL_CONFIGURATIONS> CL_ACTUAL_CONFIGURATIONS { get; set; }
        public virtual DbSet<CL_ACTUAL_SETTINGS> CL_ACTUAL_SETTINGS { get; set; }
        public virtual DbSet<CL_ACTUAL_SETTINGS_TRANSACTIONS> CL_ACTUAL_SETTINGS_TRANSACTIONS { get; set; }
        public virtual DbSet<CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES> CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES { get; set; }
        public virtual DbSet<CL_BLACKLIST> CL_BLACKLIST { get; set; }
        public virtual DbSet<CL_CLIENT_REQUIREMENTS> CL_CLIENT_REQUIREMENTS { get; set; }
        public virtual DbSet<CL_CLIENTS> CL_CLIENTS { get; set; }
        public virtual DbSet<CL_CLIENTS_CONTRAGENT> CL_CLIENTS_CONTRAGENT { get; set; }
        public virtual DbSet<CL_CLIENTS_NETS_DEPARTEMNTS> CL_CLIENTS_NETS_DEPARTEMNTS { get; set; }
        public virtual DbSet<CL_CLIENTS_USERS> CL_CLIENTS_USERS { get; set; }
        public virtual DbSet<CL_CLOSED_PERIODS> CL_CLOSED_PERIODS { get; set; }
        public virtual DbSet<CL_CONTACTS> CL_CONTACTS { get; set; }
        public virtual DbSet<CL_CONTRACT> CL_CONTRACT { get; set; }
        public virtual DbSet<CL_CONTRACT_ITEM> CL_CONTRACT_ITEM { get; set; }
        public virtual DbSet<CL_CONTRACT_WORK_TYPE> CL_CONTRACT_WORK_TYPE { get; set; }
        public virtual DbSet<CL_DEPARTMENTS> CL_DEPARTMENTS { get; set; }
        public virtual DbSet<CL_JURI_NAMES> CL_JURI_NAMES { get; set; }
        public virtual DbSet<CL_JURI_NAMES_EXTENSIONS> CL_JURI_NAMES_EXTENSIONS { get; set; }
        public virtual DbSet<CL_JURI_NAMES_EXTENSIONS_TYPE> CL_JURI_NAMES_EXTENSIONS_TYPE { get; set; }
        public virtual DbSet<CL_JURI_NETS> CL_JURI_NETS { get; set; }
        public virtual DbSet<CL_LEGAL_ENTITY_TAXATION_TYPES> CL_LEGAL_ENTITY_TAXATION_TYPES { get; set; }
        public virtual DbSet<CL_MAIL_TEMPLATES> CL_MAIL_TEMPLATES { get; set; }
        public virtual DbSet<CL_NETS> CL_NETS { get; set; }
        public virtual DbSet<CL_NETS_DEPARTMENTS> CL_NETS_DEPARTMENTS { get; set; }
        public virtual DbSet<CL_PRIORITY> CL_PRIORITY { get; set; }
        public virtual DbSet<CL_RANGE_REQUIREMENTS> CL_RANGE_REQUIREMENTS { get; set; }
        public virtual DbSet<CL_RATE> CL_RATE { get; set; }
        public virtual DbSet<CL_SUPERVISORS> CL_SUPERVISORS { get; set; }
        public virtual DbSet<CL_WORK_COSTS> CL_WORK_COSTS { get; set; }
        public virtual DbSet<CL_WR_WAGE> CL_WR_WAGE { get; set; }
        public virtual DbSet<db_updates> db_updates { get; set; }
        public virtual DbSet<FIRE_MACHINE> FIRE_MACHINE { get; set; }
        public virtual DbSet<FIRE_MACHINE_HISTORY> FIRE_MACHINE_HISTORY { get; set; }
        public virtual DbSet<FUN_MAGIC_BUTTON> FUN_MAGIC_BUTTON { get; set; }
        public virtual DbSet<GREEN_LIST> GREEN_LIST { get; set; }
        public virtual DbSet<GREEN_LIST_HISTORY> GREEN_LIST_HISTORY { get; set; }
        public virtual DbSet<INV_HISTORY> INV_HISTORY { get; set; }
        public virtual DbSet<INV_INVOICE> INV_INVOICE { get; set; }
        public virtual DbSet<INV_ITEM> INV_ITEM { get; set; }
        public virtual DbSet<INV_ITEM_LEGAL_ENTITY> INV_ITEM_LEGAL_ENTITY { get; set; }
        public virtual DbSet<INV_ITEM_ORDER> INV_ITEM_ORDER { get; set; }
        public virtual DbSet<INV_ITEM_TYPE> INV_ITEM_TYPE { get; set; }
        public virtual DbSet<INV_ITEM_WORKER> INV_ITEM_WORKER { get; set; }
        public virtual DbSet<INV_SENT_EMAILS> INV_SENT_EMAILS { get; set; }
        public virtual DbSet<INV_SIGN> INV_SIGN { get; set; }
        public virtual DbSet<INV_SIGN_TYPE> INV_SIGN_TYPE { get; set; }
        public virtual DbSet<IVLEV_OR_ORDER_ACTUALS> IVLEV_OR_ORDER_ACTUALS { get; set; }
        public virtual DbSet<IVLEV_PERS_OUT> IVLEV_PERS_OUT { get; set; }
        public virtual DbSet<LE_OBLIGATION> LE_OBLIGATION { get; set; }
        public virtual DbSet<LE_OBLIGATION_HISTORY> LE_OBLIGATION_HISTORY { get; set; }
        public virtual DbSet<LE_SIGN> LE_SIGN { get; set; }
        public virtual DbSet<LOG_CC_IN_OUT> LOG_CC_IN_OUT { get; set; }
        public virtual DbSet<NT_BLACKLIST> NT_BLACKLIST { get; set; }
        public virtual DbSet<NT_NET_REQUIREMENTS> NT_NET_REQUIREMENTS { get; set; }
        public virtual DbSet<NT_RANGE_REQUIREMENTS> NT_RANGE_REQUIREMENTS { get; set; }
        public virtual DbSet<OPT_ACTION_BONUSES_20x100> OPT_ACTION_BONUSES_20x100 { get; set; }
        public virtual DbSet<OPT_ACTION_TYPES> OPT_ACTION_TYPES { get; set; }
        public virtual DbSet<OPT_ACTUAL_COEF_TYPES> OPT_ACTUAL_COEF_TYPES { get; set; }
        public virtual DbSet<OPT_ACTUAL_COEF_VALUES> OPT_ACTUAL_COEF_VALUES { get; set; }
        public virtual DbSet<OPT_ATTRIBUTES> OPT_ATTRIBUTES { get; set; }
        public virtual DbSet<OPT_BANK_CARDS> OPT_BANK_CARDS { get; set; }
        public virtual DbSet<OPT_BONUS_NAMES> OPT_BONUS_NAMES { get; set; }
        public virtual DbSet<OPT_CH_ITEM> OPT_CH_ITEM { get; set; }
        public virtual DbSet<OPT_CHARACTERISTIC> OPT_CHARACTERISTIC { get; set; }
        public virtual DbSet<OPT_CHARGE_GROUP> OPT_CHARGE_GROUP { get; set; }
        public virtual DbSet<OPT_DATE_STATE_MIND> OPT_DATE_STATE_MIND { get; set; }
        public virtual DbSet<OPT_DISMISSAL_ITEM_COST> OPT_DISMISSAL_ITEM_COST { get; set; }
        public virtual DbSet<OPT_DISMISSAL_ITEMS> OPT_DISMISSAL_ITEMS { get; set; }
        public virtual DbSet<OPT_DOC_STATE_ATTRIBUTES> OPT_DOC_STATE_ATTRIBUTES { get; set; }
        public virtual DbSet<OPT_DOC_TYPES_ATTRS> OPT_DOC_TYPES_ATTRS { get; set; }
        public virtual DbSet<OPT_DOCS_STATES> OPT_DOCS_STATES { get; set; }
        public virtual DbSet<OPT_DOCUMENT_TYPES> OPT_DOCUMENT_TYPES { get; set; }
        public virtual DbSet<OPT_EMAILS> OPT_EMAILS { get; set; }
        public virtual DbSet<OPT_FILE_EXTENSIONS> OPT_FILE_EXTENSIONS { get; set; }
        public virtual DbSet<OPT_FIN_BDP_WORK_TYPES> OPT_FIN_BDP_WORK_TYPES { get; set; }
        public virtual DbSet<OPT_FIN_WORK_TYPES> OPT_FIN_WORK_TYPES { get; set; }
        public virtual DbSet<OPT_HOSTEL> OPT_HOSTEL { get; set; }
        public virtual DbSet<OPT_IMG_NAMES> OPT_IMG_NAMES { get; set; }
        public virtual DbSet<OPT_INFO_SITES> OPT_INFO_SITES { get; set; }
        public virtual DbSet<OPT_INTERVIEW_TYPE> OPT_INTERVIEW_TYPE { get; set; }
        public virtual DbSet<OPT_KEEPING> OPT_KEEPING { get; set; }
        public virtual DbSet<OPT_KEEPING_STATUS> OPT_KEEPING_STATUS { get; set; }
        public virtual DbSet<OPT_KEEPING_UNITS> OPT_KEEPING_UNITS { get; set; }
        public virtual DbSet<OPT_LATERS> OPT_LATERS { get; set; }
        public virtual DbSet<OPT_MAIN_REGIONS> OPT_MAIN_REGIONS { get; set; }
        public virtual DbSet<OPT_MARRIED_TYPES> OPT_MARRIED_TYPES { get; set; }
        public virtual DbSet<OPT_NATIONALITY_TYPES> OPT_NATIONALITY_TYPES { get; set; }
        public virtual DbSet<OPT_OUTPUT_TYPE> OPT_OUTPUT_TYPE { get; set; }
        public virtual DbSet<OPT_PENALTY_STATUS> OPT_PENALTY_STATUS { get; set; }
        public virtual DbSet<OPT_PENALTY_TYPES> OPT_PENALTY_TYPES { get; set; }
        public virtual DbSet<OPT_RANGE_REFERENCES> OPT_RANGE_REFERENCES { get; set; }
        public virtual DbSet<OPT_RECRUITER_TYPE> OPT_RECRUITER_TYPE { get; set; }
        public virtual DbSet<OPT_RecruiterTypes> OPT_RecruiterTypes { get; set; }
        public virtual DbSet<OPT_REFERENCES> OPT_REFERENCES { get; set; }
        public virtual DbSet<OPT_REFERENCES_CHECK_SEQURITY> OPT_REFERENCES_CHECK_SEQURITY { get; set; }
        public virtual DbSet<OPT_REFERENCES_UNIT> OPT_REFERENCES_UNIT { get; set; }
        public virtual DbSet<OPT_REGIONAL_PENALTY_COSTS> OPT_REGIONAL_PENALTY_COSTS { get; set; }
        public virtual DbSet<OPT_REGIONAL_SMS> OPT_REGIONAL_SMS { get; set; }
        public virtual DbSet<OPT_REGIONAL_SPECIFICS> OPT_REGIONAL_SPECIFICS { get; set; }
        public virtual DbSet<OPT_RELATIONSHIP_PENALTY_TYPES> OPT_RELATIONSHIP_PENALTY_TYPES { get; set; }
        public virtual DbSet<OPT_SHEDULE> OPT_SHEDULE { get; set; }
        public virtual DbSet<OPT_SHEDULE_TYPE> OPT_SHEDULE_TYPE { get; set; }
        public virtual DbSet<OPT_SHIFTS_BEFORE_PAY> OPT_SHIFTS_BEFORE_PAY { get; set; }
        public virtual DbSet<OPT_SIZES> OPT_SIZES { get; set; }
        public virtual DbSet<OPT_SMS_EVENTS> OPT_SMS_EVENTS { get; set; }
        public virtual DbSet<OPT_SMS_TEMPLATES> OPT_SMS_TEMPLATES { get; set; }
        public virtual DbSet<OPT_SMS_VARIABLES> OPT_SMS_VARIABLES { get; set; }
        public virtual DbSet<OPT_STATUS> OPT_STATUS { get; set; }
        public virtual DbSet<OPT_STATUS_GROUP> OPT_STATUS_GROUP { get; set; }
        public virtual DbSet<OPT_STATUSES> OPT_STATUSES { get; set; }
        public virtual DbSet<OPT_SUPERVISOR_TYPES> OPT_SUPERVISOR_TYPES { get; set; }
        public virtual DbSet<OPT_TEL_CODE_ZONES> OPT_TEL_CODE_ZONES { get; set; }
        public virtual DbSet<OPT_WAGE_OPTIONS_TYPE> OPT_WAGE_OPTIONS_TYPE { get; set; }
        public virtual DbSet<OPT_WORK_TYPES> OPT_WORK_TYPES { get; set; }
        public virtual DbSet<OR_LUOV> OR_LUOV { get; set; }
        public virtual DbSet<OR_ORDER> OR_ORDER { get; set; }
        public virtual DbSet<OR_ORDER_ACTUALS> OR_ORDER_ACTUALS { get; set; }
        public virtual DbSet<OR_ORDER_COMMENTS> OR_ORDER_COMMENTS { get; set; }
        public virtual DbSet<OR_ORDER_COSTS> OR_ORDER_COSTS { get; set; }
        public virtual DbSet<OR_ORDER_COSTS_HISTORY> OR_ORDER_COSTS_HISTORY { get; set; }
        public virtual DbSet<OR_ORDER_HISTORY> OR_ORDER_HISTORY { get; set; }
        public virtual DbSet<OR_ORDER_REQUIREMENTS> OR_ORDER_REQUIREMENTS { get; set; }
        public virtual DbSet<OR_ORDER_WORKER_HISTORY> OR_ORDER_WORKER_HISTORY { get; set; }
        public virtual DbSet<OR_ORDER_WORKERS> OR_ORDER_WORKERS { get; set; }
        public virtual DbSet<OR_PRE_ADD> OR_PRE_ADD { get; set; }
        public virtual DbSet<OR_QUEUE_ACTUALISATION> OR_QUEUE_ACTUALISATION { get; set; }
        public virtual DbSet<OR_RANGE_REQUIREMENTS> OR_RANGE_REQUIREMENTS { get; set; }
        public virtual DbSet<OR_TRAIN_CENTER_AVAILABLE> OR_TRAIN_CENTER_AVAILABLE { get; set; }
        public virtual DbSet<OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS> OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS { get; set; }
        public virtual DbSet<OR_TRAIN_CENTER_WORKERS> OR_TRAIN_CENTER_WORKERS { get; set; }
        public virtual DbSet<OR_TRAIN_CENTER_WORKERS_CAMPAIGN> OR_TRAIN_CENTER_WORKERS_CAMPAIGN { get; set; }
        public virtual DbSet<REASONS_FIRE_MACHINE> REASONS_FIRE_MACHINE { get; set; }
        public virtual DbSet<SC_AUTHORIZATION_LOG> SC_AUTHORIZATION_LOG { get; set; }
        public virtual DbSet<SC_BANK_SIGNS_RESP> SC_BANK_SIGNS_RESP { get; set; }
        public virtual DbSet<SC_PLACES_SMS> SC_PLACES_SMS { get; set; }
        public virtual DbSet<SC_RELATED_UNITS> SC_RELATED_UNITS { get; set; }
        public virtual DbSet<SC_ROLES> SC_ROLES { get; set; }
        public virtual DbSet<SC_UNIT> SC_UNIT { get; set; }
        public virtual DbSet<SC_UNIT_PLACES> SC_UNIT_PLACES { get; set; }
        public virtual DbSet<SC_USERS> SC_USERS { get; set; }
        public virtual DbSet<SMS_RECEIVE_REQUESTS> SMS_RECEIVE_REQUESTS { get; set; }
        public virtual DbSet<SMS_RECEIVED_MSG> SMS_RECEIVED_MSG { get; set; }
        public virtual DbSet<SMS_SEND_CONDITIONS> SMS_SEND_CONDITIONS { get; set; }
        public virtual DbSet<SMS_SEND_CONDITIONS_PARAMS> SMS_SEND_CONDITIONS_PARAMS { get; set; }
        public virtual DbSet<SMS_SEND_CONDITIONS_TYPES> SMS_SEND_CONDITIONS_TYPES { get; set; }
        public virtual DbSet<SMS_TEMPLATES> SMS_TEMPLATES { get; set; }
        public virtual DbSet<SMS_TEMPLATES_HISTORY> SMS_TEMPLATES_HISTORY { get; set; }
        public virtual DbSet<SMS_TEMPLATES_PARAMS> SMS_TEMPLATES_PARAMS { get; set; }
        public virtual DbSet<SYS_CONDITIONS> SYS_CONDITIONS { get; set; }
        public virtual DbSet<SYS_FIELDS> SYS_FIELDS { get; set; }
        public virtual DbSet<SYS_FIELDS_TYPES> SYS_FIELDS_TYPES { get; set; }
        public virtual DbSet<SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS> SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS { get; set; }
        public virtual DbSet<TEMPORARY_AC_ACCURAL> TEMPORARY_AC_ACCURAL { get; set; }
        public virtual DbSet<TEMPORARY_WR_DISMISSAL_ITEMS> TEMPORARY_WR_DISMISSAL_ITEMS { get; set; }
        public virtual DbSet<tmp_calc_file> tmp_calc_file { get; set; }
        public virtual DbSet<tmp_calc_worker> tmp_calc_worker { get; set; }
        public virtual DbSet<TMP_RETURN_KEEPING> TMP_RETURN_KEEPING { get; set; }
        public virtual DbSet<WR_ACTION_15x15> WR_ACTION_15x15 { get; set; }
        public virtual DbSet<WR_ACTION_BONUSES20x100> WR_ACTION_BONUSES20x100 { get; set; }
        public virtual DbSet<WR_ACTION_BRING_FRIEND_2012_CALCS> WR_ACTION_BRING_FRIEND_2012_CALCS { get; set; }
        public virtual DbSet<WR_ACTION_BRING_FRIEND_2012_UNITS> WR_ACTION_BRING_FRIEND_2012_UNITS { get; set; }
        public virtual DbSet<WR_ACTION_STOKMANN_2012> WR_ACTION_STOKMANN_2012 { get; set; }
        public virtual DbSet<WR_BANK_PROFILES> WR_BANK_PROFILES { get; set; }
        public virtual DbSet<WR_CARDS_LOST> WR_CARDS_LOST { get; set; }
        public virtual DbSet<WR_CARDS_ROSEURO> WR_CARDS_ROSEURO { get; set; }
        public virtual DbSet<WR_CH_CARD> WR_CH_CARD { get; set; }
        public virtual DbSet<WR_CH_CARD_ITEM> WR_CH_CARD_ITEM { get; set; }
        public virtual DbSet<WR_CHARGE> WR_CHARGE { get; set; }
        public virtual DbSet<WR_CHARGE_HISTORY> WR_CHARGE_HISTORY { get; set; }
        public virtual DbSet<WR_DataType> WR_DataType { get; set; }
        public virtual DbSet<WR_DISMISSAL_HIST_ACCRUAL> WR_DISMISSAL_HIST_ACCRUAL { get; set; }
        public virtual DbSet<WR_DISMISSAL_ITEMS> WR_DISMISSAL_ITEMS { get; set; }
        public virtual DbSet<WR_DISMISSAL_ITEMS_HISTORY> WR_DISMISSAL_ITEMS_HISTORY { get; set; }
        public virtual DbSet<WR_DOCUMENT_TYPES> WR_DOCUMENT_TYPES { get; set; }
        public virtual DbSet<WR_DOCUMENTS> WR_DOCUMENTS { get; set; }
        public virtual DbSet<WR_EDUCATION> WR_EDUCATION { get; set; }
        public virtual DbSet<WR_FAMILY> WR_FAMILY { get; set; }
        public virtual DbSet<WR_GROUPS> WR_GROUPS { get; set; }
        public virtual DbSet<WR_HISTORY> WR_HISTORY { get; set; }
        public virtual DbSet<WR_IMAGES> WR_IMAGES { get; set; }
        public virtual DbSet<WR_INTERNAL_CONTRACT> WR_INTERNAL_CONTRACT { get; set; }
        public virtual DbSet<WR_INTERVIEW> WR_INTERVIEW { get; set; }
        public virtual DbSet<WR_INTERVIEW_AND_WORKER> WR_INTERVIEW_AND_WORKER { get; set; }
        public virtual DbSet<WR_INVOICE_NUMBERS> WR_INVOICE_NUMBERS { get; set; }
        public virtual DbSet<WR_KEEPING> WR_KEEPING { get; set; }
        public virtual DbSet<WR_KEEPING_HISTORY> WR_KEEPING_HISTORY { get; set; }
        public virtual DbSet<WR_KLADR> WR_KLADR { get; set; }
        public virtual DbSet<WR_KLADR_COUNTRIES> WR_KLADR_COUNTRIES { get; set; }
        public virtual DbSet<WR_KLADR_LESS> WR_KLADR_LESS { get; set; }
        public virtual DbSet<WR_LABOR_CONTRACTS> WR_LABOR_CONTRACTS { get; set; }
        public virtual DbSet<WR_LENTA_CARD> WR_LENTA_CARD { get; set; }
        public virtual DbSet<WR_LOG_KEEPING> WR_LOG_KEEPING { get; set; }
        public virtual DbSet<WR_LOG_RETURN_KEEPING> WR_LOG_RETURN_KEEPING { get; set; }
        public virtual DbSet<WR_MEDICAL_BOOKS> WR_MEDICAL_BOOKS { get; set; }
        public virtual DbSet<WR_MIN_RESTS> WR_MIN_RESTS { get; set; }
        public virtual DbSet<WR_NDFL> WR_NDFL { get; set; }
        public virtual DbSet<WR_PAYMENT> WR_PAYMENT { get; set; }
        public virtual DbSet<WR_PAYMENT_ACCRUALS> WR_PAYMENT_ACCRUALS { get; set; }
        public virtual DbSet<WR_PAYMENT_HISTORY> WR_PAYMENT_HISTORY { get; set; }
        public virtual DbSet<WR_PAYMENT_HISTORY_ACCRUAL> WR_PAYMENT_HISTORY_ACCRUAL { get; set; }
        public virtual DbSet<WR_PAYMENT_TYPE> WR_PAYMENT_TYPE { get; set; }
        public virtual DbSet<WR_PENALTIES> WR_PENALTIES { get; set; }
        public virtual DbSet<WR_PENALTY_HISTORY> WR_PENALTY_HISTORY { get; set; }
        public virtual DbSet<WR_PREVIOUS_WORK> WR_PREVIOUS_WORK { get; set; }
        public virtual DbSet<WR_REALLY> WR_REALLY { get; set; }
        public virtual DbSet<WR_RECOMMENDATION> WR_RECOMMENDATION { get; set; }
        public virtual DbSet<WR_RECRUITER> WR_RECRUITER { get; set; }
        public virtual DbSet<WR_RECRUITER_HISTORY> WR_RECRUITER_HISTORY { get; set; }
        public virtual DbSet<WR_RECRUITER_PERIOD> WR_RECRUITER_PERIOD { get; set; }
        public virtual DbSet<WR_RECRUITER_PERIOD_HISTORY> WR_RECRUITER_PERIOD_HISTORY { get; set; }
        public virtual DbSet<WR_ROSEURO_IDS> WR_ROSEURO_IDS { get; set; }
        public virtual DbSet<WR_SHEDULE_ITEM> WR_SHEDULE_ITEM { get; set; }
        public virtual DbSet<WR_SMS> WR_SMS { get; set; }
        public virtual DbSet<WR_SMS_TYPES> WR_SMS_TYPES { get; set; }
        public virtual DbSet<WR_SUPERVISORS> WR_SUPERVISORS { get; set; }
        public virtual DbSet<WR_TEMP_PROFILES> WR_TEMP_PROFILES { get; set; }
        public virtual DbSet<WR_WAGES> WR_WAGES { get; set; }
        public virtual DbSet<WR_WAGES_OPTIONS> WR_WAGES_OPTIONS { get; set; }
        public virtual DbSet<WR_WAGES_OPTIONS_LMK> WR_WAGES_OPTIONS_LMK { get; set; }
        public virtual DbSet<WR_WAGES_PERIODS> WR_WAGES_PERIODS { get; set; }
        public virtual DbSet<WR_WAITING_FOR_FMS_RESPONSE> WR_WAITING_FOR_FMS_RESPONSE { get; set; }
        public virtual DbSet<WR_WORKER_ACTION_BRING_FRIEND> WR_WORKER_ACTION_BRING_FRIEND { get; set; }
        public virtual DbSet<WR_WORKER_ACTION_PAYMENTS> WR_WORKER_ACTION_PAYMENTS { get; set; }
        public virtual DbSet<WR_WORKER_ACTION_PAYMENTS_HISTORY> WR_WORKER_ACTION_PAYMENTS_HISTORY { get; set; }
        public virtual DbSet<WR_WORKER_COMMENTS> WR_WORKER_COMMENTS { get; set; }
        public virtual DbSet<WR_WORKER_DOC_CONTENT> WR_WORKER_DOC_CONTENT { get; set; }
        public virtual DbSet<WR_WORKER_DOCS_ATTRIBUTES> WR_WORKER_DOCS_ATTRIBUTES { get; set; }
        public virtual DbSet<WR_WORKER_DOCUMENT_ATTR_CONTENT> WR_WORKER_DOCUMENT_ATTR_CONTENT { get; set; }
        public virtual DbSet<WR_WORKER_DOCUMENTS> WR_WORKER_DOCUMENTS { get; set; }
        public virtual DbSet<WR_WORKER_REFERENCES> WR_WORKER_REFERENCES { get; set; }
        public virtual DbSet<WR_WORKER_VACATIONS> WR_WORKER_VACATIONS { get; set; }
        public virtual DbSet<WR_WORKER_WORK_TYPE> WR_WORKER_WORK_TYPE { get; set; }
        public virtual DbSet<WR_WORKERS> WR_WORKERS { get; set; }
        public virtual DbSet<WR_WORKERS_EXTENSIONS> WR_WORKERS_EXTENSIONS { get; set; }
        public virtual DbSet<WR_WORKERS_EXTENSIONS_TYPE> WR_WORKERS_EXTENSIONS_TYPE { get; set; }
        public virtual DbSet<ARCHIVE_WR_WAGES> ARCHIVE_WR_WAGES { get; set; }
        public virtual DbSet<CGN_BONUS_CLIENTS> CGN_BONUS_CLIENTS { get; set; }
        public virtual DbSet<LG_USERS_ACTS> LG_USERS_ACTS { get; set; }
        public virtual DbSet<OPT_OPTIONS> OPT_OPTIONS { get; set; }
        public virtual DbSet<OPT_SMS_EVENTS_VARIABLES> OPT_SMS_EVENTS_VARIABLES { get; set; }
        public virtual DbSet<SC_USER_ROLES> SC_USER_ROLES { get; set; }
        public virtual DbSet<TMP_COUNTERS> TMP_COUNTERS { get; set; }
        public virtual DbSet<tmp_old_costs> tmp_old_costs { get; set; }
        public virtual DbSet<tmp_old_order_costs> tmp_old_order_costs { get; set; }
        public virtual DbSet<tmpCL_WORK_COSTS> tmpCL_WORK_COSTS { get; set; }
        public virtual DbSet<WR_20x100COUNTER> WR_20x100COUNTER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AC_ACCRUAL_CHARGE>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCRUAL_KEEPING>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCRUAL_ORDER>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCRUAL_RECRUITER>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCRUAL_TYPE>()
                .Property(e => e.AAT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AC_ACCRUAL_TYPE>()
                .Property(e => e.AAT_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<AC_ACCRUAL_TYPE>()
                .HasMany(e => e.AC_ACCURAL)
                .WithRequired(e => e.AC_ACCRUAL_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCRUAL_WR_CHARGE>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCRUALS_WORKER_ACTION_PAYMENTS>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCURAL>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCURAL>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCURAL>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCURAL>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_ACCURAL>()
                .Property(e => e.ACC_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .Property(e => e.ACC_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.AC_ACCRUAL_CHARGE)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.AC_ACCRUAL_KEEPING)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.AC_ACCRUAL_ORDER)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.AC_ACCRUAL_RECRUITER)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.AC_ACCRUAL_WR_CHARGE)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.AC_ACCRUALS_WORKER_ACTION_PAYMENTS)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.ACTION_PAYMENTS_HISTORY)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.WR_PAYMENT_HISTORY_ACCRUAL)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.AC_INTEGRATION_TRANSFERS_ACCURALS)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.WR_DISMISSAL_HIST_ACCRUAL)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.WR_PAYMENT_ACCRUALS)
                .WithRequired(e => e.AC_ACCURAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_ACCURAL>()
                .HasMany(e => e.tmp_calc_worker)
                .WithMany(e => e.AC_ACCURAL)
                .Map(m => m.ToTable("tmp_calc_worker_accrual").MapLeftKey("AccId").MapRightKey("TcwId"));

            modelBuilder.Entity<AC_BANKS>()
                .Property(e => e.AB_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_BANKS>()
                .Property(e => e.AB_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<AC_BANKS>()
                .HasMany(e => e.AC_BANKS_UNITS)
                .WithRequired(e => e.AC_BANKS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_BANKS>()
                .HasMany(e => e.BANK_TRANSFERS)
                .WithRequired(e => e.AC_BANKS)
                .HasForeignKey(e => e.ACBF_BID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_BANKS>()
                .HasMany(e => e.WR_CARDS_ROSEURO)
                .WithRequired(e => e.AC_BANKS)
                .HasForeignKey(e => e.WC_BANK_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_BANKS>()
                .HasMany(e => e.OPT_BANK_CARDS)
                .WithRequired(e => e.AC_BANKS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_BANKS>()
                .HasMany(e => e.SC_BANK_SIGNS_RESP)
                .WithRequired(e => e.AC_BANKS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_BANKS>()
                .HasMany(e => e.WR_BANK_PROFILES)
                .WithRequired(e => e.AC_BANKS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_BANKS_UNITS>()
                .Property(e => e.AB_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_BANKS_UNITS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_BANKS_UNITS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_BANKS_UNITS>()
                .HasMany(e => e.AC_BANKS_UNITS_ACTIONS)
                .WithRequired(e => e.AC_BANKS_UNITS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS>()
                .Property(e => e.ACIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS>()
                .Property(e => e.ACIT_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS>()
                .Property(e => e.ACIT_USER_MADE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS>()
                .Property(e => e.ACIT_USER_TRANSFERRED)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS>()
                .HasMany(e => e.AC_INTEGRATION_TRANSFERS_PAYMENT)
                .WithRequired(e => e.AC_INTEGRATION_TRANSFERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS>()
                .HasMany(e => e.AC_INTEGRATION_TRANSFERS_ACCURALS)
                .WithRequired(e => e.AC_INTEGRATION_TRANSFERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS_ACCURALS>()
                .Property(e => e.ACIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS_ACCURALS>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_INTEGRATION_TRANSFERS_PAYMENT>()
                .Property(e => e.ACIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_MONEY_HIST>()
                .Property(e => e.MH_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_MONEY_HIST>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<AC_MONEY_HIST>()
                .Property(e => e.MH_CASH_GIVE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AC_MONEY_HIST>()
                .Property(e => e.MH_CASH_LAST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ACT_ACTIONS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ACT_ACTIONS>()
                .Property(e => e.AA_SUM)
                .HasPrecision(19, 2);

            modelBuilder.Entity<ACT_ACTIONS>()
                .Property(e => e.WRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ACT_ACTIONS>()
                .HasMany(e => e.ACT_ACTION_NUMBER_SHIFTS)
                .WithRequired(e => e.ACT_ACTIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACT_ACTIONS>()
                .HasMany(e => e.WR_WORKER_ACTION_PAYMENTS)
                .WithRequired(e => e.ACT_ACTIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACTION>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ACTION>()
                .HasMany(e => e.ACTION_PAYMENTS_HISTORY)
                .WithRequired(e => e.ACTION)
                .HasForeignKey(e => e.A_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACTION_PAYMENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ACTION_PAYMENTS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ACTION_PAYMENTS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ACTION_PAYMENTS>()
                .HasMany(e => e.ACTION_PAYMENTS_HISTORY)
                .WithRequired(e => e.ACTION_PAYMENTS)
                .HasForeignKey(e => e.AP_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACTION_PAYMENTS_HISTORY>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ARCH_STATUSES>()
                .Property(e => e.ST_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ARCH_STATUSES>()
                .Property(e => e.AS_COUNT)
                .HasPrecision(10, 0);

            modelBuilder.Entity<BANK_TRANSFERS>()
                .Property(e => e.ACBF_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<BANK_TRANSFERS>()
                .Property(e => e.ACBF_BID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<BANK_TRANSFERS>()
                .HasMany(e => e.BANK_TRANSFERS_HISTORY)
                .WithRequired(e => e.BANK_TRANSFERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANK_TRANSFERS>()
                .HasMany(e => e.BANK_TRANSFERS_PAYMENT_HISTORY)
                .WithRequired(e => e.BANK_TRANSFERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANK_TRANSFERS_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<BANK_TRANSFERS_STATUS>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BANK_TRANSFERS_STATUS>()
                .Property(e => e.KeyChar)
                .IsUnicode(false);

            modelBuilder.Entity<BANK_TRANSFERS_STATUS>()
                .HasMany(e => e.BANK_TRANSFERS_HISTORY)
                .WithRequired(e => e.BANK_TRANSFERS_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_BLOCK>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_BLOCK>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_BLOCK>()
                .Property(e => e.CC_BLOCKED_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CC_CALL_RESULT_TYPES>()
                .Property(e => e.CRT_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULT_TYPES>()
                .Property(e => e.CRT_TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_CALL_RESULT_TYPES>()
                .Property(e => e.CRT_BLOCK_SECONDS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULT_TYPES>()
                .HasMany(e => e.CC_CALL_RESULTS)
                .WithRequired(e => e.CC_CALL_RESULT_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_CALL_RESULTS>()
                .Property(e => e.CCR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULTS>()
                .Property(e => e.CRT_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULTS>()
                .Property(e => e.CCR_VIEW_SECONDS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULTS>()
                .Property(e => e.CCR_USER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULTS>()
                .Property(e => e.CCR_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULTS>()
                .Property(e => e.CCR_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALL_RESULTS>()
                .Property(e => e.CCR_ORDER_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALLBACK_BLOCK>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_CALLBACK_BLOCK>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULT_TYPES>()
                .Property(e => e.CICRT_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULT_TYPES>()
                .Property(e => e.CICRT_TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULT_TYPES>()
                .Property(e => e.CICRT_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULT_TYPES>()
                .HasMany(e => e.CC_IPTEL_CALL_RESULTS)
                .WithRequired(e => e.CC_IPTEL_CALL_RESULT_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULTS>()
                .Property(e => e.CICR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULTS>()
                .Property(e => e.CICRT_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULTS>()
                .Property(e => e.CICR_USER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULTS>()
                .Property(e => e.CICR_SID)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULTS>()
                .Property(e => e.CICR_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULTS>()
                .Property(e => e.CIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_CALL_RESULTS>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_LOG_TYPES>()
                .Property(e => e.CILT_ACTION_TYPE)
                .HasPrecision(5, 0);

            modelBuilder.Entity<CC_IPTEL_LOG_TYPES>()
                .Property(e => e.CILT_TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_LOG_TYPES>()
                .HasMany(e => e.CC_IPTEL_LOGS)
                .WithRequired(e => e.CC_IPTEL_LOG_TYPES)
                .HasForeignKey(e => e.CIL_ACTION_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_IPTEL_LOGS>()
                .Property(e => e.CIL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_LOGS>()
                .Property(e => e.CIL_ORDER_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_LOGS>()
                .Property(e => e.CIL_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_LOGS>()
                .Property(e => e.CIL_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_LOGS>()
                .Property(e => e.CIL_ACTION_TYPE)
                .HasPrecision(5, 0);

            modelBuilder.Entity<CC_IPTEL_LOGS>()
                .Property(e => e.CIL_USER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_LOGS>()
                .Property(e => e.CIL_SID)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_SID_INFO>()
                .Property(e => e.CISI_SID)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_TASK_CAMPAIGN>()
                .Property(e => e.CIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_TASK_CAMPAIGN>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_TASK_ORDER>()
                .Property(e => e.CIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_TASK_ORDER>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_TASK_PRIORITY>()
                .Property(e => e.CITP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_TASK_PRIORITY>()
                .Property(e => e.CITP_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_TASK_PRIORITY>()
                .HasMany(e => e.CC_IPTEL_TASKS)
                .WithRequired(e => e.CC_IPTEL_TASK_PRIORITY)
                .HasForeignKey(e => e.CIT_PRIORITY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_IPTEL_TASK_STATUS>()
                .Property(e => e.CITS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_TASK_STATUS>()
                .Property(e => e.CITS_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_TASK_STATUS>()
                .HasMany(e => e.CC_IPTEL_TASKS)
                .WithRequired(e => e.CC_IPTEL_TASK_STATUS)
                .HasForeignKey(e => e.CIT_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_IPTEL_TASK_TYPES>()
                .Property(e => e.CITT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_TASK_TYPES>()
                .Property(e => e.CITT_TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_TASK_TYPES>()
                .Property(e => e.CITT_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_TASK_TYPES>()
                .HasMany(e => e.CC_IPTEL_TASKS)
                .WithRequired(e => e.CC_IPTEL_TASK_TYPES)
                .HasForeignKey(e => e.CIT_TASK_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_IPTEL_TASKS>()
                .Property(e => e.CIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_TASKS>()
                .Property(e => e.CIT_TASK_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_TASKS>()
                .HasMany(e => e.CC_MANAGER_TASK)
                .WithRequired(e => e.CC_IPTEL_TASKS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_IPTEL_TASKS>()
                .HasMany(e => e.SC_USERS)
                .WithMany(e => e.CC_IPTEL_TASKS)
                .Map(m => m.ToTable("CC_IPTEL_TASK_USERS").MapLeftKey("CIT_ID").MapRightKey("CITU_USER"));

            modelBuilder.Entity<CC_IPTEL_USERS_STATUSES>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_USERS_STATUSES>()
                .Property(e => e.CIU_STATUS)
                .HasPrecision(3, 0);

            modelBuilder.Entity<CC_IPTEL_WKAC>()
                .Property(e => e.CCILT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_WKAC>()
                .Property(e => e.OIS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_WKAC>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_IPTEL_WKAC>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_IPTEL_WKAC>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<CC_MANAGER_TASK>()
                .Property(e => e.CIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_MANAGER_TASK>()
                .Property(e => e.WORK_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CC_MANAGER_TASK>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_MANAGER_TASK>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_MANAGER_TASK>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_MANAGER_TASK>()
                .HasMany(e => e.CC_MANAGER_TASK_CANDIDATES)
                .WithRequired(e => e.CC_MANAGER_TASK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_MANAGER_TASK>()
                .HasMany(e => e.CC_MANAGER_TASK_WORKERS)
                .WithRequired(e => e.CC_MANAGER_TASK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_MANAGER_TASK_CANDIDATES>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<CC_MANAGER_TASK_CANDIDATES>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_MANAGER_TASK_CANDIDATES>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<CC_MANAGER_TASK_TYPE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CC_MANAGER_TASK_TYPE>()
                .HasMany(e => e.CC_MANAGER_TASK)
                .WithRequired(e => e.CC_MANAGER_TASK_TYPE)
                .HasForeignKey(e => e.CALL_LIST_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CC_MANAGER_TASK_WORKERS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_MANAGER_TASK_WORKERS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_MANAGER_TASK_WORKERS>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_RECALL_TASK>()
                .Property(e => e.CIT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_RECALL_TASK>()
                .Property(e => e.CRT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CC_RECALL_TASK>()
                .Property(e => e.CRT_RECALL_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.CCRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.CCRG_THERE_UNIT)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.CCRG_THERE_PLACE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.CCRG_TOTAL_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CC_REG_GIVE_MONEY>()
                .Property(e => e.CCRG_MANAGER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_WORKER_REMINDS>()
                .Property(e => e.CWR_ORDER_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_WORKER_REMINDS>()
                .Property(e => e.CWR_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_WORKER_REMINDS>()
                .Property(e => e.CWR_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CC_WORKER_REMINDS>()
                .Property(e => e.CWR_USER_CREATE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_BONUS_OPTIONS>()
                .Property(e => e.CGNBO_NET_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_BONUS_OPTIONS>()
                .Property(e => e.CGNBO_ORDERS_FOR_CALC)
                .HasPrecision(4, 0);

            modelBuilder.Entity<CGN_BONUS_OPTIONS>()
                .Property(e => e.CGNBO_SUM)
                .HasPrecision(6, 2);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.CGNT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.CGN_WORKERS_NEED)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.CGNT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.CGN_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.CGN_POSITION_LAT)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .Property(e => e.CGN_POSITION_LNG)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .HasMany(e => e.CGN_BONUS_CLIENTS)
                .WithRequired(e => e.CGN_CAMPAIGN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .HasMany(e => e.CGN_QUEUE_ACTUALISATION)
                .WithRequired(e => e.CGN_CAMPAIGN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .HasOptional(e => e.OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS)
                .WithRequired(e => e.CGN_CAMPAIGN);

            modelBuilder.Entity<CGN_CAMPAIGN>()
                .HasMany(e => e.OR_ORDER_WORKERS)
                .WithMany(e => e.CGN_CAMPAIGN)
                .Map(m => m.ToTable("CGN_BONUS_CALCULATED_ORDERS").MapLeftKey("CGN_ID").MapRightKey(new[] { "OR_ID", "UN_ID", "WR_ID" }));

            modelBuilder.Entity<CGN_CAMPAIGN_ACTUALS>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_ACTUALS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_ACTUALS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_ACTUALS>()
                .Property(e => e.CGNCA_WEIGHT)
                .HasPrecision(10, 8);

            modelBuilder.Entity<CGN_CAMPAIGN_ACTUALS>()
                .Property(e => e.CGNCA_PRIORITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_REQUIREMENTS>()
                .Property(e => e.CGNT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_REQUIREMENTS>()
                .Property(e => e.CGNR_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_REQUIREMENTS>()
                .Property(e => e.REF_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_TYPES>()
                .Property(e => e.CGNT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_TYPES>()
                .Property(e => e.CGNT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CGN_CAMPAIGN_TYPES>()
                .Property(e => e.CGNT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CGN_CAMPAIGN_TYPES>()
                .HasMany(e => e.CGN_CAMPAIGN)
                .WithRequired(e => e.CGN_CAMPAIGN_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGN_CAMPAIGN_WORK_TYPES>()
                .Property(e => e.CGNT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_WORK_TYPES>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CGN_CAMPAIGN_WORKERS>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_WORKERS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_WORKERS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_CAMPAIGN_WORKERS>()
                .HasOptional(e => e.OR_TRAIN_CENTER_WORKERS_CAMPAIGN)
                .WithRequired(e => e.CGN_CAMPAIGN_WORKERS);

            modelBuilder.Entity<CGN_QUEUE_ACTUALISATION>()
                .Property(e => e.CGNQA_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_QUEUE_ACTUALISATION>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_QUEUE_ACTUALISATION>()
                .Property(e => e.CGNQA_STAGE)
                .HasPrecision(5, 0);

            modelBuilder.Entity<CGN_QUEUE_ACTUALISATION>()
                .Property(e => e.CGNQUAP_POOL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGNT_BILL>()
                .Property(e => e.BL_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<CGNT_BILL>()
                .Property(e => e.BL_SUM)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CGNT_BILL>()
                .Property(e => e.BL_TAX_SUM)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CGNT_BILL_ITEM>()
                .Property(e => e.BLTM_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CGNT_BILL_ITEM>()
                .Property(e => e.BLTM_VOLUME)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CGNT_BILL_ITEM>()
                .Property(e => e.BLTM_SUM)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CGNT_BILL_ITEM>()
                .Property(e => e.BLTM_TAX_SUM)
                .HasPrecision(19, 2);

            modelBuilder.Entity<CGNT_CONTRAGENT>()
                .Property(e => e.CGNT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CGNT_CONTRAGENT>()
                .Property(e => e.CGNT_INN)
                .HasPrecision(12, 0);

            modelBuilder.Entity<CGNT_CONTRAGENT>()
                .Property(e => e.CGNT_KPP)
                .HasPrecision(9, 0);

            modelBuilder.Entity<CGNT_CONTRAGENT>()
                .HasMany(e => e.CGNT_BILL)
                .WithRequired(e => e.CGNT_CONTRAGENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGNT_CONTRAGENT>()
                .HasMany(e => e.CL_CLIENTS_CONTRAGENT)
                .WithRequired(e => e.CGNT_CONTRAGENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGNT_FIN_UNIT>()
                .Property(e => e.CUN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CGNT_FIN_UNIT>()
                .HasMany(e => e.CGNT_CONTRAGENT)
                .WithRequired(e => e.CGNT_FIN_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGNT_FIN_UNIT>()
                .HasMany(e => e.CGNT_FIN_UNIT_UNIT)
                .WithRequired(e => e.CGNT_FIN_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CGNT_FIN_UNIT_UNIT>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_CONFIGURATIONS>()
                .Property(e => e.CAC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_CONFIGURATIONS>()
                .Property(e => e.OACT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_CONFIGURATIONS>()
                .Property(e => e.OACV_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_CONFIGURATIONS>()
                .HasMany(e => e.CL_ACTUAL_SETTINGS)
                .WithRequired(e => e.CL_ACTUAL_CONFIGURATIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS>()
                .Property(e => e.CAS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS>()
                .Property(e => e.CAST_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS>()
                .Property(e => e.CAC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS_TRANSACTIONS>()
                .Property(e => e.CAST_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS_TRANSACTIONS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS_TRANSACTIONS>()
                .Property(e => e.CATT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS_TRANSACTIONS>()
                .HasMany(e => e.CL_ACTUAL_SETTINGS)
                .WithRequired(e => e.CL_ACTUAL_SETTINGS_TRANSACTIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES>()
                .Property(e => e.CATT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES>()
                .HasMany(e => e.CL_ACTUAL_SETTINGS_TRANSACTIONS)
                .WithRequired(e => e.CL_ACTUAL_SETTINGS_TRANSACTIONS_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_BLACKLIST>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_BLACKLIST>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_BLACKLIST>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_BLACKLIST>()
                .Property(e => e.CLBL_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CL_BLACKLIST>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENT_REQUIREMENTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENT_REQUIREMENTS>()
                .Property(e => e.OREQ_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENT_REQUIREMENTS>()
                .Property(e => e.REF_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENT_REQUIREMENTS>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_INFO)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_POSITION_LAT)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_POSITION_LNG)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_PERMANENTW_PERCENT)
                .HasPrecision(3, 0);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_HOW_TO_GET)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .Property(e => e.CL_PRIORITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_ACTUAL_SETTINGS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_BLACKLIST)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_CLIENTS_USERS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_CLIENTS_CONTRAGENT)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_RANGE_REQUIREMENTS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_RATE)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_WR_WAGE)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CGN_BONUS_CLIENTS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_CLIENTS_NETS_DEPARTEMNTS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasOptional(e => e.CL_MAIL_TEMPLATES)
                .WithRequired(e => e.CL_CLIENTS);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_SUPERVISORS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.GREEN_LIST)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_CONTACTS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_WORK_COSTS)
                .WithRequired(e => e.CL_CLIENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CLIENTS>()
                .HasMany(e => e.CL_CLIENTS1)
                .WithMany(e => e.CL_CLIENTS2)
                .Map(m => m.ToTable("CL_CLIENT_ANALOGUE").MapLeftKey("ANALOGUE_CL_ID").MapRightKey("PARENT_CL_ID"));

            modelBuilder.Entity<CL_CLIENTS_CONTRAGENT>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS_NETS_DEPARTEMNTS>()
                .Property(e => e.CND_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS_NETS_DEPARTEMNTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS_NETS_DEPARTEMNTS>()
                .Property(e => e.ND_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS_USERS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLIENTS_USERS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLOSED_PERIODS>()
                .Property(e => e.CLL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CLOSED_PERIODS>()
                .Property(e => e.CLL_US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_PHONE_2)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_PHONE_MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_MOBILE_2)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_POST)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTACTS>()
                .Property(e => e.CN_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTRACT>()
                .Property(e => e.CON_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTRACT>()
                .Property(e => e.CON_MIN_DURATION)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CL_CONTRACT>()
                .Property(e => e.CON_SIGNATORY)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTRACT>()
                .Property(e => e.RP_SIGNATORY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CONTRACT>()
                .Property(e => e.CON_DATA_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTRACT>()
                .Property(e => e.US_ADDED)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_CONTRACT>()
                .HasMany(e => e.CL_CONTRACT_ITEM)
                .WithRequired(e => e.CL_CONTRACT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CONTRACT>()
                .HasMany(e => e.CL_CONTRACT1)
                .WithOptional(e => e.CL_CONTRACT2)
                .HasForeignKey(e => e.CON_MASTER_ID);

            modelBuilder.Entity<CL_CONTRACT>()
                .HasMany(e => e.INV_INVOICE)
                .WithRequired(e => e.CL_CONTRACT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CONTRACT>()
                .HasMany(e => e.LE_OBLIGATION)
                .WithRequired(e => e.CL_CONTRACT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CONTRACT>()
                .HasMany(e => e.OR_ORDER_HISTORY)
                .WithRequired(e => e.CL_CONTRACT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CONTRACT_ITEM>()
                .Property(e => e.CCI_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTRACT_ITEM>()
                .Property(e => e.CCI_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CL_CONTRACT_ITEM>()
                .HasMany(e => e.CL_CONTRACT_ITEM1)
                .WithOptional(e => e.CL_CONTRACT_ITEM2)
                .HasForeignKey(e => e.CCI_MASTER_ID);

            modelBuilder.Entity<CL_CONTRACT_ITEM>()
                .HasMany(e => e.CL_RATE)
                .WithRequired(e => e.CL_CONTRACT_ITEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_CONTRACT_WORK_TYPE>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTRACT_WORK_TYPE>()
                .Property(e => e.CL_WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_CONTRACT_WORK_TYPE>()
                .HasMany(e => e.CL_CONTRACT_ITEM)
                .WithRequired(e => e.CL_CONTRACT_WORK_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_DEPARTMENTS>()
                .Property(e => e.DEP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_DEPARTMENTS>()
                .Property(e => e.DEP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_DEPARTMENTS>()
                .HasMany(e => e.CL_NETS_DEPARTMENTS)
                .WithRequired(e => e.CL_DEPARTMENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_ORGANIZATION_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_SHORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_INN)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_KPP)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_CURRENT_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_OFFSETING_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_BANK)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_BIC)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .Property(e => e.CLJN_SIGNATORY)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .HasMany(e => e.CL_CONTRACT)
                .WithRequired(e => e.CL_JURI_NAMES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .HasMany(e => e.LE_SIGN)
                .WithRequired(e => e.CL_JURI_NAMES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_JURI_NAMES>()
                .HasMany(e => e.CL_JURI_NAMES_EXTENSIONS)
                .WithRequired(e => e.CL_JURI_NAMES)
                .HasForeignKey(e => e.JURI_NAME_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS>()
                .Property(e => e.JrNmExtID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS>()
                .Property(e => e.DATA)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS>()
                .Property(e => e.CL_JURI_NAMES_EXTENSIONS_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS>()
                .Property(e => e.USER_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS_TYPE>()
                .Property(e => e.ExtensionTypeID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS_TYPE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS_TYPE>()
                .Property(e => e.WR_DataTypeId)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS_TYPE>()
                .Property(e => e.KEY_CHAR_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<CL_JURI_NAMES_EXTENSIONS_TYPE>()
                .HasMany(e => e.CL_JURI_NAMES_EXTENSIONS)
                .WithRequired(e => e.CL_JURI_NAMES_EXTENSIONS_TYPE)
                .HasForeignKey(e => e.CL_JURI_NAMES_EXTENSIONS_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_JURI_NETS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_JURI_NETS>()
                .HasMany(e => e.CL_CONTRACT_WORK_TYPE)
                .WithRequired(e => e.CL_JURI_NETS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_LEGAL_ENTITY_TAXATION_TYPES>()
                .Property(e => e.CAPTION)
                .IsUnicode(false);

            modelBuilder.Entity<CL_LEGAL_ENTITY_TAXATION_TYPES>()
                .Property(e => e.KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<CL_LEGAL_ENTITY_TAXATION_TYPES>()
                .HasMany(e => e.CL_JURI_NAMES)
                .WithRequired(e => e.CL_LEGAL_ENTITY_TAXATION_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_MAIL_TEMPLATES>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_MAIL_TEMPLATES>()
                .Property(e => e.CLMT_BODY)
                .IsUnicode(false);

            modelBuilder.Entity<CL_MAIL_TEMPLATES>()
                .Property(e => e.CLMT_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<CL_NETS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_NETS>()
                .Property(e => e.NT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_NETS>()
                .HasOptional(e => e.CGN_BONUS_OPTIONS)
                .WithRequired(e => e.CL_NETS);

            modelBuilder.Entity<CL_NETS>()
                .HasMany(e => e.CL_JURI_NETS)
                .WithRequired(e => e.CL_NETS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_NETS>()
                .HasMany(e => e.NT_BLACKLIST)
                .WithRequired(e => e.CL_NETS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_NETS>()
                .HasMany(e => e.NT_RANGE_REQUIREMENTS)
                .WithRequired(e => e.CL_NETS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_NETS>()
                .HasMany(e => e.CL_NETS_DEPARTMENTS)
                .WithRequired(e => e.CL_NETS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_NETS_DEPARTMENTS>()
                .Property(e => e.ND_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_NETS_DEPARTMENTS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_NETS_DEPARTMENTS>()
                .Property(e => e.DEP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_NETS_DEPARTMENTS>()
                .HasMany(e => e.CL_CLIENTS_NETS_DEPARTEMNTS)
                .WithRequired(e => e.CL_NETS_DEPARTMENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_PRIORITY>()
                .Property(e => e.CLP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_PRIORITY>()
                .Property(e => e.CLP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_PRIORITY>()
                .Property(e => e.CLP_WEIGHT)
                .HasPrecision(4, 0);

            modelBuilder.Entity<CL_PRIORITY>()
                .HasMany(e => e.CL_CLIENTS)
                .WithRequired(e => e.CL_PRIORITY1)
                .HasForeignKey(e => e.CL_PRIORITY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_PRIORITY>()
                .HasMany(e => e.OR_ORDER)
                .WithRequired(e => e.CL_PRIORITY)
                .HasForeignKey(e => e.OR_PRIORITY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_RANGE_REQUIREMENTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_RANGE_REQUIREMENTS>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_RATE>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_RATE>()
                .HasMany(e => e.OR_ORDER_WORKER_HISTORY)
                .WithRequired(e => e.CL_RATE)
                .HasForeignKey(e => e.CLIENT_RATE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CL_SUPERVISORS>()
                .Property(e => e.SCU_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_SUPERVISORS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_WORK_COSTS>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CL_WORK_COSTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_WORK_COSTS>()
                .Property(e => e.CWC_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CL_WORK_COSTS>()
                .Property(e => e.CWC_DOC_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<CL_WORK_COSTS>()
                .Property(e => e.CWC_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CL_WORK_COSTS>()
                .Property(e => e.WT_NAME_IN_DEAL)
                .IsUnicode(false);

            modelBuilder.Entity<CL_WR_WAGE>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FIRE_MACHINE>()
                .Property(e => e.FM_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FIRE_MACHINE>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FIRE_MACHINE>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FIRE_MACHINE>()
                .HasMany(e => e.FIRE_MACHINE_HISTORY)
                .WithRequired(e => e.FIRE_MACHINE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIRE_MACHINE_HISTORY>()
                .Property(e => e.FMH_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FIRE_MACHINE_HISTORY>()
                .Property(e => e.FM_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FUN_MAGIC_BUTTON>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<FUN_MAGIC_BUTTON>()
                .Property(e => e.FMB_CLICK)
                .HasPrecision(10, 0);

            modelBuilder.Entity<GREEN_LIST>()
                .Property(e => e.GL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<GREEN_LIST>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<GREEN_LIST>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<GREEN_LIST>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<GREEN_LIST_HISTORY>()
                .Property(e => e.GLH_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<GREEN_LIST_HISTORY>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<GREEN_LIST_HISTORY>()
                .Property(e => e.GL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<INV_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<INV_INVOICE>()
                .Property(e => e.INV_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<INV_INVOICE>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<INV_INVOICE>()
                .Property(e => e.INV_SUM)
                .HasPrecision(19, 2);

            modelBuilder.Entity<INV_INVOICE>()
                .Property(e => e.INV_VAT)
                .HasPrecision(19, 2);

            modelBuilder.Entity<INV_INVOICE>()
                .Property(e => e.INV_TAX)
                .HasPrecision(19, 2);

            modelBuilder.Entity<INV_INVOICE>()
                .HasMany(e => e.INV_HISTORY)
                .WithRequired(e => e.INV_INVOICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_INVOICE>()
                .HasMany(e => e.INV_ITEM)
                .WithRequired(e => e.INV_INVOICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_INVOICE>()
                .HasMany(e => e.INV_SIGN)
                .WithRequired(e => e.INV_INVOICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_ITEM>()
                .HasMany(e => e.INV_ITEM_WORKER)
                .WithRequired(e => e.INV_ITEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_ITEM>()
                .HasMany(e => e.INV_ITEM_ORDER)
                .WithRequired(e => e.INV_ITEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_ITEM>()
                .HasMany(e => e.INV_ITEM_LEGAL_ENTITY)
                .WithRequired(e => e.INV_ITEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_ITEM_TYPE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INV_ITEM_TYPE>()
                .Property(e => e.KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<INV_ITEM_TYPE>()
                .HasMany(e => e.INV_ITEM)
                .WithRequired(e => e.INV_ITEM_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_SENT_EMAILS>()
                .Property(e => e.FROM_US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<INV_SENT_EMAILS>()
                .Property(e => e.TO_US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<INV_SENT_EMAILS>()
                .HasMany(e => e.INV_INVOICE)
                .WithMany(e => e.INV_SENT_EMAILS)
                .Map(m => m.ToTable("INV_SENT_INVOICES").MapLeftKey("EMAIL_ID").MapRightKey("INV_ID"));

            modelBuilder.Entity<INV_SIGN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INV_SIGN_TYPE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INV_SIGN_TYPE>()
                .Property(e => e.KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<INV_SIGN_TYPE>()
                .HasMany(e => e.INV_SIGN)
                .WithRequired(e => e.INV_SIGN_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INV_SIGN_TYPE>()
                .HasMany(e => e.LE_SIGN)
                .WithRequired(e => e.INV_SIGN_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IVLEV_OR_ORDER_ACTUALS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<IVLEV_OR_ORDER_ACTUALS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<IVLEV_OR_ORDER_ACTUALS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<IVLEV_OR_ORDER_ACTUALS>()
                .Property(e => e.ORAC_WEIGHT)
                .HasPrecision(10, 8);

            modelBuilder.Entity<IVLEV_PERS_OUT>()
                .Property(e => e.CNT_DAYS)
                .HasPrecision(4, 0);

            modelBuilder.Entity<IVLEV_PERS_OUT>()
                .Property(e => e.PERS_OUT)
                .HasPrecision(11, 10);

            modelBuilder.Entity<LE_OBLIGATION>()
                .Property(e => e.LEO_SUM)
                .HasPrecision(19, 2);

            modelBuilder.Entity<LE_OBLIGATION>()
                .HasMany(e => e.LE_OBLIGATION_HISTORY)
                .WithRequired(e => e.LE_OBLIGATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LE_OBLIGATION_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LE_OBLIGATION_HISTORY>()
                .Property(e => e.LEOH_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<LE_OBLIGATION_HISTORY>()
                .Property(e => e.LEOH_DATA_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<LE_OBLIGATION_HISTORY>()
                .HasMany(e => e.INV_ITEM_LEGAL_ENTITY)
                .WithRequired(e => e.LE_OBLIGATION_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LE_SIGN>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LE_SIGN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_CC_IN_OUT>()
                .Property(e => e.LCIO_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LOG_CC_IN_OUT>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LOG_CC_IN_OUT>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LOG_CC_IN_OUT>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LOG_CC_IN_OUT>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LOG_CC_IN_OUT>()
                .Property(e => e.LCIO_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LOG_CC_IN_OUT>()
                .Property(e => e.LCIO_BLOCK_SECONDS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_BLACKLIST>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_BLACKLIST>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_BLACKLIST>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_BLACKLIST>()
                .Property(e => e.NTBL_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<NT_BLACKLIST>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_NET_REQUIREMENTS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_NET_REQUIREMENTS>()
                .Property(e => e.OREQ_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_NET_REQUIREMENTS>()
                .Property(e => e.REF_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_NET_REQUIREMENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_RANGE_REQUIREMENTS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NT_RANGE_REQUIREMENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_ACTION_BONUSES_20x100>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_ACTION_BONUSES_20x100>()
                .Property(e => e.ACT_BONUS_SUM)
                .HasPrecision(8, 2);

            modelBuilder.Entity<OPT_ACTION_BONUSES_20x100>()
                .Property(e => e.ACT_ATTENDANCE_COUNT)
                .HasPrecision(2, 0);

            modelBuilder.Entity<OPT_ACTION_TYPES>()
                .HasMany(e => e.ACT_ACTIONS)
                .WithRequired(e => e.OPT_ACTION_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_ACTUAL_COEF_TYPES>()
                .Property(e => e.OACT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_ACTUAL_COEF_TYPES>()
                .HasMany(e => e.CL_ACTUAL_CONFIGURATIONS)
                .WithRequired(e => e.OPT_ACTUAL_COEF_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_ACTUAL_COEF_VALUES>()
                .Property(e => e.OACV_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_ACTUAL_COEF_VALUES>()
                .HasMany(e => e.CL_ACTUAL_CONFIGURATIONS)
                .WithRequired(e => e.OPT_ACTUAL_COEF_VALUES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_ATTRIBUTES>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_ATTRIBUTES>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_ATTRIBUTES>()
                .Property(e => e.KEY_CHAR_VAL)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_ATTRIBUTES>()
                .HasMany(e => e.OPT_DOC_TYPES_ATTRS)
                .WithRequired(e => e.OPT_ATTRIBUTES)
                .HasForeignKey(e => e.ID_ATTR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_BANK_CARDS>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_BANK_CARDS>()
                .Property(e => e.AB_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_BANK_CARDS>()
                .Property(e => e.CARD_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_BANK_CARDS>()
                .Property(e => e.CARD_ACCOUNT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_BONUS_NAMES>()
                .Property(e => e.OBN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_BONUS_NAMES>()
                .Property(e => e.OBN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_CH_ITEM>()
                .Property(e => e.CH_IT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_CHARACTERISTIC>()
                .Property(e => e.CH_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_CHARGE_GROUP>()
                .Property(e => e.OCG_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_CHARGE_GROUP>()
                .Property(e => e.OCG_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_CHARGE_GROUP>()
                .HasMany(e => e.OPT_PENALTY_TYPES)
                .WithRequired(e => e.OPT_CHARGE_GROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DATE_STATE_MIND>()
                .HasMany(e => e.WR_WORKER_VACATIONS)
                .WithRequired(e => e.OPT_DATE_STATE_MIND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DISMISSAL_ITEM_COST>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DISMISSAL_ITEM_COST>()
                .Property(e => e.COST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OPT_DISMISSAL_ITEMS>()
                .Property(e => e.OPTD_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_DISMISSAL_ITEMS>()
                .HasMany(e => e.WR_DISMISSAL_ITEMS)
                .WithRequired(e => e.OPT_DISMISSAL_ITEMS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DOC_STATE_ATTRIBUTES>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOC_STATE_ATTRIBUTES>()
                .Property(e => e.DOC_STATE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOC_STATE_ATTRIBUTES>()
                .Property(e => e.DOC_ATTR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOC_STATE_ATTRIBUTES>()
                .HasMany(e => e.WR_WORKER_DOCS_ATTRIBUTES)
                .WithRequired(e => e.OPT_DOC_STATE_ATTRIBUTES)
                .HasForeignKey(e => e.ID_DOC_STATE_ATTR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DOC_TYPES_ATTRS>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOC_TYPES_ATTRS>()
                .Property(e => e.ID_DOC_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOC_TYPES_ATTRS>()
                .Property(e => e.ID_ATTR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOC_TYPES_ATTRS>()
                .HasMany(e => e.OPT_DOC_STATE_ATTRIBUTES)
                .WithRequired(e => e.OPT_DOC_TYPES_ATTRS)
                .HasForeignKey(e => e.DOC_ATTR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DOCS_STATES>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOCS_STATES>()
                .Property(e => e.DOC_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOCS_STATES>()
                .Property(e => e.STATE_ID)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_DOCS_STATES>()
                .HasMany(e => e.OPT_DOC_STATE_ATTRIBUTES)
                .WithRequired(e => e.OPT_DOCS_STATES)
                .HasForeignKey(e => e.DOC_STATE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DOCS_STATES>()
                .HasMany(e => e.WR_WORKER_DOCUMENTS)
                .WithRequired(e => e.OPT_DOCS_STATES)
                .HasForeignKey(e => e.DOC_STATE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DOCUMENT_TYPES>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_DOCUMENT_TYPES>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_DOCUMENT_TYPES>()
                .Property(e => e.KEY_CHAR_VAL)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_DOCUMENT_TYPES>()
                .HasMany(e => e.OPT_DOC_TYPES_ATTRS)
                .WithRequired(e => e.OPT_DOCUMENT_TYPES)
                .HasForeignKey(e => e.ID_DOC_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DOCUMENT_TYPES>()
                .HasMany(e => e.OPT_DOCS_STATES)
                .WithRequired(e => e.OPT_DOCUMENT_TYPES)
                .HasForeignKey(e => e.DOC_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_DOCUMENT_TYPES>()
                .HasMany(e => e.WR_WAITING_FOR_FMS_RESPONSE)
                .WithRequired(e => e.OPT_DOCUMENT_TYPES)
                .HasForeignKey(e => e.IdDocType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_EMAILS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_EMAILS>()
                .Property(e => e.OEML_TYPE)
                .HasPrecision(3, 0);

            modelBuilder.Entity<OPT_EMAILS>()
                .Property(e => e.OEML_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_FILE_EXTENSIONS>()
                .Property(e => e.EXTENSION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_FILE_EXTENSIONS>()
                .Property(e => e.MIME_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_FILE_EXTENSIONS>()
                .HasMany(e => e.WR_INTERNAL_CONTRACT)
                .WithRequired(e => e.OPT_FILE_EXTENSIONS)
                .HasForeignKey(e => e.FILE_EXT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_FIN_BDP_WORK_TYPES>()
                .Property(e => e.WT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_FIN_WORK_TYPES>()
                .Property(e => e.FWT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_FIN_WORK_TYPES>()
                .Property(e => e.FWT_UNIT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_FIN_WORK_TYPES>()
                .HasMany(e => e.CGNT_BILL_ITEM)
                .WithRequired(e => e.OPT_FIN_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_FIN_WORK_TYPES>()
                .HasMany(e => e.OPT_FIN_BDP_WORK_TYPES)
                .WithRequired(e => e.OPT_FIN_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.ID_STATE_KLADR)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.ID_REGION_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.ID_DISTRICT_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.ID_TOWN_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.ID_STREET_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.HOUSE_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_HOSTEL>()
                .Property(e => e.DAY_COST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OPT_IMG_NAMES>()
                .Property(e => e.IN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_IMG_NAMES>()
                .Property(e => e.IN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_IMG_NAMES>()
                .HasMany(e => e.WR_IMAGES)
                .WithRequired(e => e.OPT_IMG_NAMES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_INFO_SITES>()
                .Property(e => e.OIS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_INFO_SITES>()
                .Property(e => e.OIS_SITE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_INFO_SITES>()
                .Property(e => e.OIS_PARENT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_INFO_SITES>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_INTERVIEW_TYPE>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_INTERVIEW_TYPE>()
                .Property(e => e.KeyCharValue)
                .IsFixedLength();

            modelBuilder.Entity<OPT_INTERVIEW_TYPE>()
                .HasMany(e => e.WR_INTERVIEW)
                .WithRequired(e => e.OPT_INTERVIEW_TYPE)
                .HasForeignKey(e => e.IdInterViewType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_KEEPING>()
                .Property(e => e.KP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_KEEPING>()
                .Property(e => e.KP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_KEEPING>()
                .Property(e => e.KP_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OPT_KEEPING>()
                .HasMany(e => e.WR_KEEPING)
                .WithRequired(e => e.OPT_KEEPING)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_KEEPING>()
                .HasMany(e => e.OPT_KEEPING_UNITS)
                .WithRequired(e => e.OPT_KEEPING)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_KEEPING>()
                .HasMany(e => e.TMP_RETURN_KEEPING)
                .WithRequired(e => e.OPT_KEEPING)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_KEEPING_STATUS>()
                .Property(e => e.OKS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_KEEPING_STATUS>()
                .Property(e => e.OKS_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_KEEPING_STATUS>()
                .HasMany(e => e.WR_KEEPING_HISTORY)
                .WithRequired(e => e.OPT_KEEPING_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_KEEPING_UNITS>()
                .Property(e => e.KP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_KEEPING_UNITS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_LATERS>()
                .Property(e => e.ID)
                .HasPrecision(2, 0);

            modelBuilder.Entity<OPT_LATERS>()
                .Property(e => e.MINIMUM)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_LATERS>()
                .Property(e => e.MAXIMUM)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_LATERS>()
                .Property(e => e.PEN_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_MAIN_REGIONS>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_MAIN_REGIONS>()
                .Property(e => e.UN_ID_MAIN)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_MAIN_REGIONS>()
                .Property(e => e.UN_ID_SUBORDINATE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_MARRIED_TYPES>()
                .Property(e => e.MR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_MARRIED_TYPES>()
                .Property(e => e.MR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_NATIONALITY_TYPES>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_NATIONALITY_TYPES>()
                .Property(e => e.NT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_OUTPUT_TYPE>()
                .Property(e => e.OT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_OUTPUT_TYPE>()
                .Property(e => e.OT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_OUTPUT_TYPE>()
                .HasMany(e => e.OR_ORDER_WORKERS)
                .WithRequired(e => e.OPT_OUTPUT_TYPE)
                .HasForeignKey(e => e.ORR_OUTPUT_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_STATUS>()
                .Property(e => e.OPS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_PENALTY_STATUS>()
                .Property(e => e.OPS_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_PENALTY_STATUS>()
                .HasMany(e => e.WR_CHARGE_HISTORY)
                .WithRequired(e => e.OPT_PENALTY_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_STATUS>()
                .HasMany(e => e.WR_CHARGE)
                .WithRequired(e => e.OPT_PENALTY_STATUS)
                .HasForeignKey(e => e.WRC_IS_CONFIRMED)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_STATUS>()
                .HasMany(e => e.WR_PENALTY_HISTORY)
                .WithRequired(e => e.OPT_PENALTY_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_STATUS>()
                .HasMany(e => e.WR_PENALTIES)
                .WithRequired(e => e.OPT_PENALTY_STATUS)
                .HasForeignKey(e => e.WRP_IS_CONFIRMED)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .Property(e => e.PEN_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .Property(e => e.WR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .HasMany(e => e.OPT_LATERS)
                .WithRequired(e => e.OPT_PENALTY_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .HasMany(e => e.OPT_REGIONAL_PENALTY_COSTS)
                .WithRequired(e => e.OPT_PENALTY_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .HasMany(e => e.WR_CHARGE)
                .WithRequired(e => e.OPT_PENALTY_TYPES)
                .HasForeignKey(e => e.CHARGE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .HasMany(e => e.OPT_RELATIONSHIP_PENALTY_TYPES)
                .WithRequired(e => e.OPT_PENALTY_TYPES)
                .HasForeignKey(e => e.PEN_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .HasMany(e => e.OPT_RELATIONSHIP_PENALTY_TYPES1)
                .WithRequired(e => e.OPT_PENALTY_TYPES1)
                .HasForeignKey(e => e.RELATIONSHIP_PEN_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_PENALTY_TYPES>()
                .HasMany(e => e.WR_PENALTIES)
                .WithRequired(e => e.OPT_PENALTY_TYPES)
                .HasForeignKey(e => e.WR_PENALTY_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_RANGE_REFERENCES>()
                .Property(e => e.RR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_RANGE_REFERENCES>()
                .HasMany(e => e.CL_RANGE_REQUIREMENTS)
                .WithRequired(e => e.OPT_RANGE_REFERENCES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_RANGE_REFERENCES>()
                .HasMany(e => e.NT_RANGE_REQUIREMENTS)
                .WithRequired(e => e.OPT_RANGE_REFERENCES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_RANGE_REFERENCES>()
                .HasMany(e => e.OR_RANGE_REQUIREMENTS)
                .WithRequired(e => e.OPT_RANGE_REFERENCES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_RECRUITER_TYPE>()
                .Property(e => e.ORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_RECRUITER_TYPE>()
                .Property(e => e.ORT_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_RECRUITER_TYPE>()
                .HasMany(e => e.WR_RECRUITER_PERIOD)
                .WithRequired(e => e.OPT_RECRUITER_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_RecruiterTypes>()
                .Property(e => e.Id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_RecruiterTypes>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_RecruiterTypes>()
                .Property(e => e.SpecificName)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_RecruiterTypes>()
                .HasMany(e => e.WR_WORKERS)
                .WithRequired(e => e.OPT_RecruiterTypes)
                .HasForeignKey(e => e.WR_RecruiterActionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_REFERENCES>()
                .Property(e => e.REF_ID)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OPT_REFERENCES>()
                .Property(e => e.REF_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_REFERENCES>()
                .HasMany(e => e.OPT_REFERENCES_UNIT)
                .WithRequired(e => e.OPT_REFERENCES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_REFERENCES>()
                .HasMany(e => e.WR_WORKER_REFERENCES)
                .WithRequired(e => e.OPT_REFERENCES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_REFERENCES_CHECK_SEQURITY>()
                .HasMany(e => e.OPT_REFERENCES_UNIT)
                .WithRequired(e => e.OPT_REFERENCES_CHECK_SEQURITY)
                .HasForeignKey(e => e.RUS_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_REFERENCES_UNIT>()
                .Property(e => e.REF_ID)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OPT_REFERENCES_UNIT>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_REGIONAL_PENALTY_COSTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_REGIONAL_PENALTY_COSTS>()
                .Property(e => e.PEN_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_REGIONAL_PENALTY_COSTS>()
                .Property(e => e.WR_COST)
                .HasPrecision(6, 2);

            modelBuilder.Entity<OPT_REGIONAL_SMS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_REGIONAL_SPECIFICS>()
                .Property(e => e.UN_ID)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_REGIONAL_SPECIFICS>()
                .Property(e => e.OPT_ID)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_REGIONAL_SPECIFICS>()
                .Property(e => e.OPT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_REGIONAL_SPECIFICS>()
                .Property(e => e.GENITIVE)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_RELATIONSHIP_PENALTY_TYPES>()
                .Property(e => e.PEN_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_RELATIONSHIP_PENALTY_TYPES>()
                .Property(e => e.RELATIONSHIP_PEN_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_SHEDULE>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_SHEDULE>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_SHEDULE>()
                .HasMany(e => e.WR_SHEDULE_ITEM)
                .WithRequired(e => e.OPT_SHEDULE)
                .HasForeignKey(e => e.IdShedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_SHEDULE_TYPE>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_SHEDULE_TYPE>()
                .Property(e => e.KeyCharValue)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_SHEDULE_TYPE>()
                .HasMany(e => e.OPT_SHEDULE)
                .WithRequired(e => e.OPT_SHEDULE_TYPE)
                .HasForeignKey(e => e.IsSheduleType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_SHIFTS_BEFORE_PAY>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_SHIFTS_BEFORE_PAY>()
                .Property(e => e.WRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_SIZES>()
                .Property(e => e.SZ_SIZE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_SIZES>()
                .HasMany(e => e.WR_WORKERS)
                .WithRequired(e => e.OPT_SIZES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_SMS_EVENTS>()
                .HasMany(e => e.OPT_SMS_EVENTS_VARIABLES)
                .WithRequired(e => e.OPT_SMS_EVENTS)
                .HasForeignKey(e => e.ID_SMS_EVENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_SMS_EVENTS>()
                .HasMany(e => e.SMS_TEMPLATES)
                .WithRequired(e => e.OPT_SMS_EVENTS)
                .HasForeignKey(e => e.ID_SMS_EVENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_SMS_TEMPLATES>()
                .Property(e => e.OSMST_TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_SMS_TEMPLATES>()
                .HasMany(e => e.OPT_REGIONAL_SMS)
                .WithRequired(e => e.OPT_SMS_TEMPLATES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_SMS_TEMPLATES>()
                .HasMany(e => e.SC_PLACES_SMS)
                .WithRequired(e => e.OPT_SMS_TEMPLATES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_SMS_VARIABLES>()
                .HasMany(e => e.OPT_SMS_EVENTS_VARIABLES)
                .WithRequired(e => e.OPT_SMS_VARIABLES)
                .HasForeignKey(e => e.ID_SMS_VARIABLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_STATUS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_STATUS>()
                .Property(e => e.KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_STATUS>()
                .HasMany(e => e.INV_HISTORY)
                .WithRequired(e => e.OPT_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_STATUS>()
                .HasMany(e => e.OR_ORDER_HISTORY)
                .WithRequired(e => e.OPT_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_STATUS>()
                .HasMany(e => e.WR_DISMISSAL_ITEMS_HISTORY)
                .WithRequired(e => e.OPT_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_STATUS_GROUP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_STATUS_GROUP>()
                .Property(e => e.KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_STATUS_GROUP>()
                .HasMany(e => e.OPT_STATUS)
                .WithRequired(e => e.OPT_STATUS_GROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_STATUSES>()
                .Property(e => e.ST_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_STATUSES>()
                .Property(e => e.ST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_STATUSES>()
                .Property(e => e.ST_SORT_ORDER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_STATUSES>()
                .Property(e => e.CHANGE_STAT_WORKED_DAYS)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OPT_STATUSES>()
                .Property(e => e.CHANGE_STAT_WORKED_PERIOD)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OPT_STATUSES>()
                .HasMany(e => e.WR_HISTORY)
                .WithOptional(e => e.OPT_STATUSES)
                .HasForeignKey(e => e.WRH_NEW_STATUS);

            modelBuilder.Entity<OPT_STATUSES>()
                .HasMany(e => e.OPT_OPTIONS)
                .WithOptional(e => e.OPT_STATUSES)
                .HasForeignKey(e => e.DEFAULT_STATUS);

            modelBuilder.Entity<OPT_STATUSES>()
                .HasMany(e => e.WR_WORKERS)
                .WithOptional(e => e.OPT_STATUSES)
                .HasForeignKey(e => e.ST_ID_CURR);

            modelBuilder.Entity<OPT_SUPERVISOR_TYPES>()
                .Property(e => e.OST_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_SUPERVISOR_TYPES>()
                .Property(e => e.OST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_SUPERVISOR_TYPES>()
                .HasMany(e => e.WR_SUPERVISORS)
                .WithRequired(e => e.OPT_SUPERVISOR_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_TEL_CODE_ZONES>()
                .Property(e => e.OTCZ_TEL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_TEL_CODE_ZONES>()
                .Property(e => e.OTCZ_UNIT)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_WAGE_OPTIONS_TYPE>()
                .Property(e => e.TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_WAGE_OPTIONS_TYPE>()
                .Property(e => e.KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_WAGE_OPTIONS_TYPE>()
                .HasMany(e => e.WR_WAGES_OPTIONS)
                .WithRequired(e => e.OPT_WAGE_OPTIONS_TYPE)
                .HasForeignKey(e => e.OPT_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .Property(e => e.WT_COST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .Property(e => e.WT_UNIT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .Property(e => e.WT_SERVICE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.CL_CLIENT_REQUIREMENTS)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.CL_CONTRACT_WORK_TYPE)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.CL_RANGE_REQUIREMENTS)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.CL_WORK_COSTS)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.OPT_FIN_BDP_WORK_TYPES)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .HasForeignKey(e => e.WT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.CGN_BONUS_CLIENTS)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.WR_WAGES)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPT_WORK_TYPES>()
                .HasMany(e => e.WR_WORKER_WORK_TYPE)
                .WithRequired(e => e.OPT_WORK_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_LUOV>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_LUOV>()
                .Property(e => e.ORL_FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<OR_LUOV>()
                .Property(e => e.ORL_USER_SUBMITTED)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_WORKERS_COUNT)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_HOW_TO_GET)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_WH_LIST_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_COST_UNIT)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_POSITION_LAT)
                .HasPrecision(18, 8);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_POSITION_LNG)
                .HasPrecision(18, 8);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_US_ID_CREATE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_US_ID_CLOSE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.US_ID_COVEREMAIL)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_GENDER)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.OR_PRIORITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .Property(e => e.CND_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.CC_CALL_RESULTS)
                .WithOptional(e => e.OR_ORDER)
                .HasForeignKey(e => e.CCR_ORDER_ID);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.CC_IPTEL_LOGS)
                .WithOptional(e => e.OR_ORDER)
                .HasForeignKey(e => e.CIL_ORDER_ID);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.CC_WORKER_REMINDS)
                .WithRequired(e => e.OR_ORDER)
                .HasForeignKey(e => e.CWR_ORDER_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasOptional(e => e.OR_LUOV)
                .WithRequired(e => e.OR_ORDER);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.OR_ORDER_COSTS)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.OR_ORDER_HISTORY)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.OR_RANGE_REQUIREMENTS)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.WR_RECRUITER_HISTORY)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.OR_ORDER_COMMENTS)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.OR_PRE_ADD)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.OR_QUEUE_ACTUALISATION)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasOptional(e => e.OR_TRAIN_CENTER_AVAILABLE)
                .WithRequired(e => e.OR_ORDER);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.WR_ACTION_15x15)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER>()
                .HasMany(e => e.OR_ORDER_WORKERS)
                .WithRequired(e => e.OR_ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER_ACTUALS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_ACTUALS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_ACTUALS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_ACTUALS>()
                .Property(e => e.ORAC_WEIGHT)
                .HasPrecision(10, 8);

            modelBuilder.Entity<OR_ORDER_ACTUALS>()
                .Property(e => e.ORAC_PRIORITY)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_COMMENTS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_COMMENTS>()
                .Property(e => e.OC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_COMMENTS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_COMMENTS>()
                .Property(e => e.OC_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER_COSTS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_COSTS>()
                .Property(e => e.ORC_COST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_COSTS>()
                .HasMany(e => e.OR_ORDER_COSTS_HISTORY)
                .WithRequired(e => e.OR_ORDER_COSTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER_COSTS_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_COSTS_HISTORY>()
                .Property(e => e.OOCH_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER_COSTS_HISTORY>()
                .Property(e => e.OOCH_DATA_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER_COSTS_HISTORY>()
                .HasMany(e => e.INV_ITEM_ORDER)
                .WithRequired(e => e.OR_ORDER_COSTS_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER_HISTORY>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_REQUIREMENTS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_REQUIREMENTS>()
                .Property(e => e.OREQ_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_REQUIREMENTS>()
                .Property(e => e.REF_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_COST_UNIT)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_BONUS)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_DEBONUS)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_CLIENT_BONUS_HOURS)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_DINNER_MINUTES)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.ORR_OUTPUT_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .HasMany(e => e.AC_ACCRUAL_ORDER)
                .WithRequired(e => e.OR_ORDER_WORKER_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER_WORKER_HISTORY>()
                .HasMany(e => e.INV_ITEM_WORKER)
                .WithRequired(e => e.OR_ORDER_WORKER_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_BONUS)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_DEBONUS)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_COST_UNIT)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_CLIENT_BONUS_HOURS)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_DINNER_MINUTES)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_US_ID_ADD)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .Property(e => e.ORR_OUTPUT_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .HasMany(e => e.ACTION_PAYMENTS)
                .WithRequired(e => e.OR_ORDER_WORKERS)
                .HasForeignKey(e => new { e.OR_ID, e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .HasMany(e => e.OR_ORDER_WORKER_HISTORY)
                .WithRequired(e => e.OR_ORDER_WORKERS)
                .HasForeignKey(e => new { e.OR_ID, e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_ORDER_WORKERS>()
                .HasOptional(e => e.OR_TRAIN_CENTER_WORKERS)
                .WithRequired(e => e.OR_ORDER_WORKERS);

            modelBuilder.Entity<OR_PRE_ADD>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_PRE_ADD>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_PRE_ADD>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_PRE_ADD>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_QUEUE_ACTUALISATION>()
                .Property(e => e.ORQA_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_QUEUE_ACTUALISATION>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_QUEUE_ACTUALISATION>()
                .Property(e => e.ORQA_STAGE)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OR_QUEUE_ACTUALISATION>()
                .Property(e => e.ORQUAP_POOL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_RANGE_REQUIREMENTS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_AVAILABLE>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_AVAILABLE>()
                .Property(e => e.ORTC_WORKERS_MAX)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_AVAILABLE>()
                .HasMany(e => e.OR_TRAIN_CENTER_WORKERS)
                .WithRequired(e => e.OR_TRAIN_CENTER_AVAILABLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS>()
                .Property(e => e.ORTC_WORKERS_MAX)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS>()
                .HasMany(e => e.OR_TRAIN_CENTER_WORKERS_CAMPAIGN)
                .WithRequired(e => e.OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OR_TRAIN_CENTER_WORKERS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_WORKERS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_WORKERS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_WORKERS_CAMPAIGN>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_WORKERS_CAMPAIGN>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OR_TRAIN_CENTER_WORKERS_CAMPAIGN>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<REASONS_FIRE_MACHINE>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<REASONS_FIRE_MACHINE>()
                .HasMany(e => e.FIRE_MACHINE_HISTORY)
                .WithRequired(e => e.REASONS_FIRE_MACHINE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_AUTHORIZATION_LOG>()
                .Property(e => e.USAL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_AUTHORIZATION_LOG>()
                .Property(e => e.USAL_USID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_BANK_SIGNS_RESP>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_BANK_SIGNS_RESP>()
                .Property(e => e.SCUP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_BANK_SIGNS_RESP>()
                .Property(e => e.AB_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_PLACES_SMS>()
                .Property(e => e.SCUP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_RELATED_UNITS>()
                .Property(e => e.SCRU_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_RELATED_UNITS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_RELATED_UNITS>()
                .Property(e => e.RELATED_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_ROLES>()
                .Property(e => e.ROL_ROLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_UNIT>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_UNIT>()
                .Property(e => e.UN_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_UNIT>()
                .Property(e => e.UN_MIN_REST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SC_UNIT>()
                .Property(e => e.UN_HOUR_OFFSET)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SC_UNIT>()
                .Property(e => e.IP_TEL_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<SC_UNIT>()
                .Property(e => e.UN_POSITION_LAT)
                .HasPrecision(18, 8);

            modelBuilder.Entity<SC_UNIT>()
                .Property(e => e.UN_POSITION_LNG)
                .HasPrecision(18, 8);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.AC_BANKS_UNITS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.ACT_ACTIONS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.CC_MANAGER_TASK)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.CGNT_FIN_UNIT_UNIT)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.CL_CLIENTS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.LE_SIGN)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.NT_NET_REQUIREMENTS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.NT_RANGE_REQUIREMENTS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_DISMISSAL_ITEM_COST)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_EMAILS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_HOSTEL)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_INFO_SITES)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_KEEPING_UNITS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_MAIN_REGIONS)
                .WithRequired(e => e.SC_UNIT)
                .HasForeignKey(e => e.UN_ID_MAIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_MAIN_REGIONS1)
                .WithRequired(e => e.SC_UNIT1)
                .HasForeignKey(e => e.UN_ID_SUBORDINATE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_REFERENCES_UNIT)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_REGIONAL_PENALTY_COSTS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_REGIONAL_SMS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_SHIFTS_BEFORE_PAY)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.OPT_TEL_CODE_ZONES)
                .WithRequired(e => e.SC_UNIT)
                .HasForeignKey(e => e.OTCZ_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.SC_RELATED_UNITS)
                .WithRequired(e => e.SC_UNIT)
                .HasForeignKey(e => e.UN_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.SC_RELATED_UNITS1)
                .WithRequired(e => e.SC_UNIT1)
                .HasForeignKey(e => e.RELATED_UN_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.SC_UNIT_PLACES)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasOptional(e => e.WR_ACTION_BRING_FRIEND_2012_UNITS)
                .WithRequired(e => e.SC_UNIT);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.WR_MIN_RESTS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.WR_WORKERS)
                .WithRequired(e => e.SC_UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT>()
                .HasMany(e => e.SC_USERS)
                .WithMany(e => e.SC_UNIT)
                .Map(m => m.ToTable("SC_USER_UNITS").MapLeftKey("UN_ID").MapRightKey("US_ID"));

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .Property(e => e.SCUP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .Property(e => e.SCUP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .Property(e => e.SCUP_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .Property(e => e.SCUP_HOWTOGET)
                .IsUnicode(false);

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .HasMany(e => e.SC_BANK_SIGNS_RESP)
                .WithRequired(e => e.SC_UNIT_PLACES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .HasMany(e => e.SC_PLACES_SMS)
                .WithRequired(e => e.SC_UNIT_PLACES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_UNIT_PLACES>()
                .HasMany(e => e.WR_INTERVIEW)
                .WithRequired(e => e.SC_UNIT_PLACES)
                .HasForeignKey(e => e.IdPlace)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.ROL_ROLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_FAMILY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_FATHER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.US_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .Property(e => e.SCU_LDAP_ACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.AC_ACCURAL)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.AC_BANKS_UNITS)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.AC_INTEGRATION_TRANSFERS)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.ACIT_USER_MADE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.AC_INTEGRATION_TRANSFERS1)
                .WithRequired(e => e.SC_USERS1)
                .HasForeignKey(e => e.ACIT_USER_TRANSFERRED)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.BANK_TRANSFERS_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CC_CALL_RESULTS)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.CCR_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CC_IPTEL_LOGS)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.CIL_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasOptional(e => e.CC_IPTEL_USERS_STATUSES)
                .WithRequired(e => e.SC_USERS);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CC_MANAGER_TASK)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CC_WORKER_REMINDS)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.CWR_USER_CREATE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CL_ACTUAL_SETTINGS_TRANSACTIONS)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CL_BLACKLIST)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CL_CLIENTS_USERS)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CL_CLOSED_PERIODS)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.CLL_US_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CL_CONTRACT)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.RP_SIGNATORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.CL_CONTRACT1)
                .WithRequired(e => e.SC_USERS1)
                .HasForeignKey(e => e.US_ADDED)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.FUN_MAGIC_BUTTON)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.INV_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.INV_INVOICE)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.INV_SENT_EMAILS)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.FROM_US_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.INV_SENT_EMAILS1)
                .WithRequired(e => e.SC_USERS1)
                .HasForeignKey(e => e.TO_US_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.LE_OBLIGATION_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.LOG_CC_IN_OUT)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.OR_LUOV)
                .WithOptional(e => e.SC_USERS)
                .HasForeignKey(e => e.ORL_USER_SUBMITTED);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.OR_ORDER_COSTS_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.OR_ORDER_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.OR_ORDER_WORKER_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.SC_BANK_SIGNS_RESP)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_CHARGE_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_INTERNAL_CONTRACT)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.US_ADDED)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_INTERNAL_CONTRACT1)
                .WithRequired(e => e.SC_USERS1)
                .HasForeignKey(e => e.US_ADDED)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_INTERNAL_CONTRACT2)
                .WithRequired(e => e.SC_USERS2)
                .HasForeignKey(e => e.US_ADDED)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_KEEPING)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_KEEPING_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_PENALTY_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_RECRUITER_PERIOD_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasOptional(e => e.WR_SUPERVISORS)
                .WithRequired(e => e.SC_USERS);

            modelBuilder.Entity<SC_USERS>()
                .HasOptional(e => e.SC_USER_ROLES)
                .WithRequired(e => e.SC_USERS);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_BANK_PROFILES)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_CARDS_LOST)
                .WithRequired(e => e.SC_USERS)
                .HasForeignKey(e => e.WRCL_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_LABOR_CONTRACTS)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_PAYMENT_HISTORY)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_USERS>()
                .HasMany(e => e.WR_WORKER_VACATIONS)
                .WithRequired(e => e.SC_USERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SMS_RECEIVE_REQUESTS>()
                .Property(e => e.SR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SMS_RECEIVE_REQUESTS>()
                .Property(e => e.SR_COUNT)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SMS_RECEIVE_REQUESTS>()
                .Property(e => e.SR_REMAINS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SMS_RECEIVE_REQUESTS>()
                .Property(e => e.SR_RESPONSE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SMS_RECEIVE_REQUESTS>()
                .HasMany(e => e.SMS_RECEIVED_MSG)
                .WithRequired(e => e.SMS_RECEIVE_REQUESTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SMS_RECEIVED_MSG>()
                .Property(e => e.SR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SMS_RECEIVED_MSG>()
                .Property(e => e.SRM_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SMS_RECEIVED_MSG>()
                .Property(e => e.SRM_SRC_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SMS_RECEIVED_MSG>()
                .Property(e => e.SRM_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SMS_RECEIVED_MSG>()
                .Property(e => e.SRM_TEXT)
                .IsUnicode(false);

            modelBuilder.Entity<SMS_SEND_CONDITIONS>()
                .HasMany(e => e.SMS_SEND_CONDITIONS_PARAMS)
                .WithRequired(e => e.SMS_SEND_CONDITIONS)
                .HasForeignKey(e => e.ID_SMS_SEND_CONDITIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SMS_SEND_CONDITIONS_TYPES>()
                .HasMany(e => e.SMS_SEND_CONDITIONS_PARAMS)
                .WithRequired(e => e.SMS_SEND_CONDITIONS_TYPES)
                .HasForeignKey(e => e.ID_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SMS_TEMPLATES>()
                .Property(e => e.MESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<SMS_TEMPLATES>()
                .HasMany(e => e.SMS_SEND_CONDITIONS_PARAMS)
                .WithRequired(e => e.SMS_TEMPLATES)
                .HasForeignKey(e => e.ID_SMS_TEMPLATE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SMS_TEMPLATES>()
                .HasMany(e => e.SMS_TEMPLATES_HISTORY)
                .WithRequired(e => e.SMS_TEMPLATES)
                .HasForeignKey(e => e.ID_SMS_TEMPLATE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SMS_TEMPLATES>()
                .HasMany(e => e.SMS_TEMPLATES_PARAMS)
                .WithRequired(e => e.SMS_TEMPLATES)
                .HasForeignKey(e => e.ID_SMS_TEMPLATE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SMS_TEMPLATES_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SYS_CONDITIONS>()
                .HasMany(e => e.SMS_TEMPLATES_PARAMS)
                .WithRequired(e => e.SYS_CONDITIONS)
                .HasForeignKey(e => e.ID_CONDITION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SYS_CONDITIONS>()
                .HasMany(e => e.SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS)
                .WithRequired(e => e.SYS_CONDITIONS)
                .HasForeignKey(e => e.ID_CONDITION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SYS_FIELDS>()
                .HasMany(e => e.SMS_TEMPLATES_PARAMS)
                .WithRequired(e => e.SYS_FIELDS)
                .HasForeignKey(e => e.ID_FIELD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SYS_FIELDS_TYPES>()
                .HasMany(e => e.SYS_FIELDS)
                .WithRequired(e => e.SYS_FIELDS_TYPES)
                .HasForeignKey(e => e.ID_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SYS_FIELDS_TYPES>()
                .HasMany(e => e.SYS_FIELDS_TYPES_AVAILABLE_CONDITIONS)
                .WithRequired(e => e.SYS_FIELDS_TYPES)
                .HasForeignKey(e => e.ID_FIELD_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TEMPORARY_AC_ACCURAL>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_AC_ACCURAL>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_AC_ACCURAL>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_AC_ACCURAL>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_AC_ACCURAL>()
                .Property(e => e.ACC_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TEMPORARY_AC_ACCURAL>()
                .Property(e => e.ACC_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TEMPORARY_AC_ACCURAL>()
                .Property(e => e.ACC_OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_WR_DISMISSAL_ITEMS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_WR_DISMISSAL_ITEMS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_WR_DISMISSAL_ITEMS>()
                .Property(e => e.OPTD_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_WR_DISMISSAL_ITEMS>()
                .Property(e => e.WHO_WRITE_OFF)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMPORARY_WR_DISMISSAL_ITEMS>()
                .Property(e => e.WHO_GIVE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tmp_calc_file>()
                .HasMany(e => e.tmp_calc_worker)
                .WithRequired(e => e.tmp_calc_file)
                .HasForeignKey(e => e.FileId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tmp_calc_worker>()
                .Property(e => e.UnId)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tmp_calc_worker>()
                .Property(e => e.WrId)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TMP_RETURN_KEEPING>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TMP_RETURN_KEEPING>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TMP_RETURN_KEEPING>()
                .Property(e => e.KP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TMP_RETURN_KEEPING>()
                .Property(e => e.RK_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TMP_RETURN_KEEPING>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TMP_RETURN_KEEPING>()
                .Property(e => e.RK_PER_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TMP_RETURN_KEEPING>()
                .Property(e => e.RK_LAST_COUNT)
                .HasPrecision(3, 0);

            modelBuilder.Entity<WR_ACTION_15x15>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_15x15>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_15x15>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_15x15>()
                .Property(e => e.WR_FRIEND_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_15x15>()
                .Property(e => e.WR_FRIEND_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_15x15>()
                .Property(e => e.WR_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_ACTION_BONUSES20x100>()
                .Property(e => e.AB_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BONUSES20x100>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BONUSES20x100>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BONUSES20x100>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BONUSES20x100>()
                .Property(e => e.WR_BONUS_SUM)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WR_ACTION_BONUSES20x100>()
                .Property(e => e.ACC_ID_NEXT)
                .HasPrecision(9, 0);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_CALCS>()
                .Property(e => e.WABF_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_CALCS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_CALCS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_CALCS>()
                .Property(e => e.FUN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_CALCS>()
                .Property(e => e.FWR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_CALCS>()
                .Property(e => e.WABF_SUM)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_UNITS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_BRING_FRIEND_2012_UNITS>()
                .Property(e => e.WABF_SUM)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WR_ACTION_STOKMANN_2012>()
                .Property(e => e.WAT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_STOKMANN_2012>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_STOKMANN_2012>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_STOKMANN_2012>()
                .Property(e => e.FUN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_STOKMANN_2012>()
                .Property(e => e.FWR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ACTION_STOKMANN_2012>()
                .Property(e => e.WABF_SUM)
                .HasPrecision(12, 2);

            modelBuilder.Entity<WR_BANK_PROFILES>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_BANK_PROFILES>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_BANK_PROFILES>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_BANK_PROFILES>()
                .Property(e => e.AB_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_LOST>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_LOST>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_LOST>()
                .Property(e => e.WCL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_LOST>()
                .Property(e => e.WR_CARDNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CARDS_LOST>()
                .Property(e => e.WR_CARD_ACCOUNT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CARDS_LOST>()
                .Property(e => e.WRCL_USER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_LOST>()
                .Property(e => e.WCL_ID_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CARDS_ROSEURO>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_ROSEURO>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_ROSEURO>()
                .Property(e => e.WR_CARDNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CARDS_ROSEURO>()
                .Property(e => e.WR_CARD_ACCOUNT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CARDS_ROSEURO>()
                .Property(e => e.WC_BANK_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CARDS_ROSEURO>()
                .Property(e => e.WCR_ID_CARD)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CH_CARD>()
                .Property(e => e.CH_CARD_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CH_CARD>()
                .Property(e => e.CH_CARD_CAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WR_CH_CARD>()
                .HasMany(e => e.WR_WORKERS)
                .WithRequired(e => e.WR_CH_CARD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_CHARGE>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CHARGE>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CHARGE>()
                .Property(e => e.CHARGE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CHARGE>()
                .Property(e => e.WRC_PRICE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_CHARGE>()
                .HasMany(e => e.WR_CHARGE_HISTORY)
                .WithRequired(e => e.WR_CHARGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_CHARGE_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_CHARGE_HISTORY>()
                .Property(e => e.WCH_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_CHARGE_HISTORY>()
                .HasMany(e => e.AC_ACCRUAL_WR_CHARGE)
                .WithRequired(e => e.WR_CHARGE_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_DataType>()
                .Property(e => e.TypeID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_DataType>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_DataType>()
                .HasMany(e => e.CL_JURI_NAMES_EXTENSIONS_TYPE)
                .WithRequired(e => e.WR_DataType)
                .HasForeignKey(e => e.WR_DataTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_DataType>()
                .HasMany(e => e.WR_WORKERS_EXTENSIONS_TYPE)
                .WithRequired(e => e.WR_DataType)
                .HasForeignKey(e => e.WR_DataTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_DISMISSAL_HIST_ACCRUAL>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_DISMISSAL_ITEMS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_DISMISSAL_ITEMS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_DISMISSAL_ITEMS>()
                .HasMany(e => e.WR_DISMISSAL_ITEMS_HISTORY)
                .WithRequired(e => e.WR_DISMISSAL_ITEMS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_DISMISSAL_ITEMS_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_DISMISSAL_ITEMS_HISTORY>()
                .HasMany(e => e.WR_DISMISSAL_HIST_ACCRUAL)
                .WithRequired(e => e.WR_DISMISSAL_ITEMS_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_DOCUMENT_TYPES>()
                .Property(e => e.DOC_ID)
                .HasPrecision(8, 0);

            modelBuilder.Entity<WR_DOCUMENT_TYPES>()
                .Property(e => e.DOCUMENT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_DOCUMENT_TYPES>()
                .Property(e => e.WRDT_PERIOD)
                .HasPrecision(2, 0);

            modelBuilder.Entity<WR_DOCUMENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(8, 0);

            modelBuilder.Entity<WR_DOCUMENTS>()
                .Property(e => e.WR_ID)
                .HasPrecision(8, 0);

            modelBuilder.Entity<WR_DOCUMENTS>()
                .Property(e => e.DOC_ID)
                .HasPrecision(8, 0);

            modelBuilder.Entity<WR_DOCUMENTS>()
                .Property(e => e.DOCUMENT_TYPE)
                .HasPrecision(8, 0);

            modelBuilder.Entity<WR_EDUCATION>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_EDUCATION>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_EDUCATION>()
                .Property(e => e.WE_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_EDUCATION>()
                .Property(e => e.WE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_EDUCATION>()
                .Property(e => e.WE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_EDUCATION>()
                .Property(e => e.WE_PROFESSION)
                .IsUnicode(false);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.WF_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.WF_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.WF_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.WF_COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.WF_POSITION)
                .IsUnicode(false);

            modelBuilder.Entity<WR_FAMILY>()
                .Property(e => e.WF_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_GROUPS>()
                .Property(e => e.WRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_GROUPS>()
                .Property(e => e.WRG_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_GROUPS>()
                .HasMany(e => e.ACT_ACTIONS)
                .WithRequired(e => e.WR_GROUPS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_GROUPS>()
                .HasMany(e => e.OPT_SHIFTS_BEFORE_PAY)
                .WithRequired(e => e.WR_GROUPS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_GROUPS>()
                .HasMany(e => e.WR_MIN_RESTS)
                .WithRequired(e => e.WR_GROUPS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_GROUPS>()
                .HasMany(e => e.WR_WAGES)
                .WithRequired(e => e.WR_GROUPS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_GROUPS>()
                .HasMany(e => e.WR_WORKERS)
                .WithRequired(e => e.WR_GROUPS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_HISTORY>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_HISTORY>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_HISTORY>()
                .Property(e => e.WRH_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_HISTORY>()
                .Property(e => e.WRH_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_HISTORY>()
                .Property(e => e.WRH_TYPE)
                .HasPrecision(2, 0);

            modelBuilder.Entity<WR_HISTORY>()
                .Property(e => e.WRH_NEW_STATUS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_IMAGES>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_IMAGES>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_IMAGES>()
                .Property(e => e.IN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_IMAGES>()
                .Property(e => e.WRI_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_IMAGES>()
                .Property(e => e.WRI_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<WR_IMAGES>()
                .Property(e => e.WRI_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_INTERNAL_CONTRACT>()
                .Property(e => e.US_ADDED)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INTERNAL_CONTRACT>()
                .Property(e => e.NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WR_INTERNAL_CONTRACT>()
                .HasMany(e => e.WR_WAGES)
                .WithRequired(e => e.WR_INTERNAL_CONTRACT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_INTERVIEW>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<WR_INTERVIEW>()
                .Property(e => e.IdPlace)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INTERVIEW>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<WR_INTERVIEW>()
                .Property(e => e.HowToGet)
                .IsUnicode(false);

            modelBuilder.Entity<WR_INTERVIEW>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INTERVIEW>()
                .HasMany(e => e.WR_INTERVIEW_AND_WORKER)
                .WithRequired(e => e.WR_INTERVIEW)
                .HasForeignKey(e => e.IdInterview)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_INTERVIEW_AND_WORKER>()
                .Property(e => e.IdTempProfile)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INVOICE_NUMBERS>()
                .Property(e => e.WRIN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INVOICE_NUMBERS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INVOICE_NUMBERS>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_INVOICE_NUMBERS>()
                .Property(e => e.CLJN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INVOICE_NUMBERS>()
                .Property(e => e.OURJN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INVOICE_NUMBERS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_INVOICE_NUMBERS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_KEEPING>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_KEEPING>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_KEEPING>()
                .Property(e => e.KP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_KEEPING>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_KEEPING>()
                .HasMany(e => e.WR_KEEPING_HISTORY)
                .WithRequired(e => e.WR_KEEPING)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KEEPING_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_KEEPING_HISTORY>()
                .HasMany(e => e.AC_ACCRUAL_KEEPING)
                .WithRequired(e => e.WR_KEEPING_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KLADR>()
                .Property(e => e.WK_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_KLADR>()
                .Property(e => e.WK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR>()
                .Property(e => e.WK_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR>()
                .Property(e => e.WK_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR>()
                .Property(e => e.WK_POST_INDEX)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR>()
                .HasMany(e => e.OPT_HOSTEL)
                .WithRequired(e => e.WR_KLADR)
                .HasForeignKey(e => e.ID_DISTRICT_KLADR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KLADR>()
                .HasMany(e => e.OPT_HOSTEL1)
                .WithRequired(e => e.WR_KLADR1)
                .HasForeignKey(e => e.ID_REGION_KLADR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KLADR>()
                .HasMany(e => e.OPT_HOSTEL2)
                .WithRequired(e => e.WR_KLADR2)
                .HasForeignKey(e => e.ID_STREET_KLADR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KLADR>()
                .HasMany(e => e.OPT_HOSTEL3)
                .WithRequired(e => e.WR_KLADR3)
                .HasForeignKey(e => e.ID_TOWN_KLADR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KLADR_COUNTRIES>()
                .Property(e => e.WKC_ID)
                .HasPrecision(4, 0);

            modelBuilder.Entity<WR_KLADR_COUNTRIES>()
                .Property(e => e.WKC_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR_COUNTRIES>()
                .Property(e => e.KeyCharValue)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR_COUNTRIES>()
                .HasMany(e => e.OPT_DOCS_STATES)
                .WithRequired(e => e.WR_KLADR_COUNTRIES)
                .HasForeignKey(e => e.STATE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KLADR_COUNTRIES>()
                .HasMany(e => e.OPT_HOSTEL)
                .WithRequired(e => e.WR_KLADR_COUNTRIES)
                .HasForeignKey(e => e.ID_STATE_KLADR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_KLADR_LESS>()
                .Property(e => e.WKL_LESS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR_LESS>()
                .Property(e => e.WKL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_KLADR_LESS>()
                .HasOptional(e => e.WR_ROSEURO_IDS)
                .WithRequired(e => e.WR_KLADR_LESS);

            modelBuilder.Entity<WR_LABOR_CONTRACTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LABOR_CONTRACTS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LABOR_CONTRACTS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LENTA_CARD>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LENTA_CARD>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.KP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.KP_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.WRLK_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.US_KEEPER_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_KEEPING>()
                .Property(e => e.KP_ORDER_COUNT_DIVIDE)
                .HasPrecision(3, 0);

            modelBuilder.Entity<WR_LOG_RETURN_KEEPING>()
                .Property(e => e.WRLRK_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_RETURN_KEEPING>()
                .Property(e => e.RK_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_LOG_RETURN_KEEPING>()
                .Property(e => e.WRLK_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_MEDICAL_BOOKS>()
                .Property(e => e.WRMB_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_MEDICAL_BOOKS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_MEDICAL_BOOKS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_MEDICAL_BOOKS>()
                .Property(e => e.WRMB_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<WR_MIN_RESTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_MIN_RESTS>()
                .Property(e => e.WRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_MIN_RESTS>()
                .Property(e => e.MIN_REST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_PAYMENT>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PAYMENT>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PAYMENT>()
                .Property(e => e.SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_PAYMENT>()
                .HasMany(e => e.AC_INTEGRATION_TRANSFERS_PAYMENT)
                .WithRequired(e => e.WR_PAYMENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_PAYMENT>()
                .HasMany(e => e.WR_PAYMENT_ACCRUALS)
                .WithRequired(e => e.WR_PAYMENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_PAYMENT>()
                .HasMany(e => e.WR_PAYMENT_HISTORY)
                .WithRequired(e => e.WR_PAYMENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_PAYMENT_ACCRUALS>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PAYMENT_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PAYMENT_HISTORY>()
                .HasMany(e => e.BANK_TRANSFERS_PAYMENT_HISTORY)
                .WithRequired(e => e.WR_PAYMENT_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_PAYMENT_HISTORY_ACCRUAL>()
                .Property(e => e.ACC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PAYMENT_TYPE>()
                .Property(e => e.ACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_PAYMENT_TYPE>()
                .Property(e => e.ACT_KEYCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_PAYMENT_TYPE>()
                .HasMany(e => e.WR_PAYMENT)
                .WithRequired(e => e.WR_PAYMENT_TYPE)
                .HasForeignKey(e => e.CALC_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_PENALTIES>()
                .Property(e => e.PEN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PENALTIES>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PENALTIES>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PENALTIES>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PENALTIES>()
                .Property(e => e.WR_PENALTY_TYPE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PENALTIES>()
                .Property(e => e.WRP_PRICE)
                .HasPrecision(6, 2);

            modelBuilder.Entity<WR_PENALTIES>()
                .HasMany(e => e.WR_PENALTY_HISTORY)
                .WithRequired(e => e.WR_PENALTIES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_PENALTY_HISTORY>()
                .Property(e => e.PEN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PENALTY_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PENALTY_HISTORY>()
                .Property(e => e.WPH_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_PENALTY_HISTORY>()
                .HasMany(e => e.AC_ACCRUAL_CHARGE)
                .WithRequired(e => e.WR_PENALTY_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.WPW_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.WPW_COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.WPW_COMPANY_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.WPW_COMPANY_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.WPW_POSITION)
                .IsUnicode(false);

            modelBuilder.Entity<WR_PREVIOUS_WORK>()
                .Property(e => e.WPW_WHY_LEFT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_REALLY>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_REALLY>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_REALLY>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECOMMENDATION>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECOMMENDATION>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECOMMENDATION>()
                .Property(e => e.WRR_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECOMMENDATION>()
                .Property(e => e.WRR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_RECOMMENDATION>()
                .Property(e => e.WRR_POSITION)
                .IsUnicode(false);

            modelBuilder.Entity<WR_RECOMMENDATION>()
                .Property(e => e.WRR_COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<WR_RECOMMENDATION>()
                .Property(e => e.WRR_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_RECRUITER>()
                .Property(e => e.UN_ID_MASTER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECRUITER>()
                .Property(e => e.WR_ID_MASTER)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECRUITER>()
                .Property(e => e.UN_ID_SLAVE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECRUITER>()
                .Property(e => e.WR_ID_SLAVE)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECRUITER>()
                .HasMany(e => e.WR_RECRUITER_PERIOD)
                .WithRequired(e => e.WR_RECRUITER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_RECRUITER_HISTORY>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_RECRUITER_HISTORY>()
                .Property(e => e.WRRH_AMOUNT)
                .HasPrecision(10, 4);

            modelBuilder.Entity<WR_RECRUITER_HISTORY>()
                .HasMany(e => e.AC_ACCRUAL_RECRUITER)
                .WithRequired(e => e.WR_RECRUITER_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_RECRUITER_PERIOD>()
                .Property(e => e.WRR_SUM)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_RECRUITER_PERIOD>()
                .HasMany(e => e.WR_RECRUITER_HISTORY)
                .WithRequired(e => e.WR_RECRUITER_PERIOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_RECRUITER_PERIOD>()
                .HasMany(e => e.WR_RECRUITER_PERIOD_HISTORY)
                .WithRequired(e => e.WR_RECRUITER_PERIOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_RECRUITER_PERIOD_HISTORY>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_ROSEURO_IDS>()
                .Property(e => e.WKL_LESS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_ROSEURO_IDS>()
                .Property(e => e.WRE_ID)
                .HasPrecision(3, 0);

            modelBuilder.Entity<WR_SHEDULE_ITEM>()
                .HasMany(e => e.WR_INTERVIEW)
                .WithRequired(e => e.WR_SHEDULE_ITEM)
                .HasForeignKey(e => e.IdSheduleItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_SMS>()
                .Property(e => e.WRS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_SMS>()
                .Property(e => e.WRS_SMSTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_SMS>()
                .Property(e => e.WRS_SMSNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WR_SMS>()
                .Property(e => e.WRS_SMSCOUNT)
                .HasPrecision(2, 0);

            modelBuilder.Entity<WR_SMS>()
                .Property(e => e.WRS_ERROR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_SMS>()
                .Property(e => e.WRS_STATUS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_SMS_TYPES>()
                .Property(e => e.WRS_KEY_CHAR_VAL)
                .IsFixedLength();

            modelBuilder.Entity<WR_SMS_TYPES>()
                .Property(e => e.WRS_TYPE_NAME)
                .IsFixedLength();

            modelBuilder.Entity<WR_SMS_TYPES>()
                .HasMany(e => e.WR_SMS)
                .WithRequired(e => e.WR_SMS_TYPES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_SUPERVISORS>()
                .Property(e => e.OST_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_SUPERVISORS>()
                .Property(e => e.SCU_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_SUPERVISORS>()
                .HasMany(e => e.CL_SUPERVISORS)
                .WithRequired(e => e.WR_SUPERVISORS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_FAMILY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_FATHER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_PHONE_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.OIS_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_WR_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_WR_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_VACANCY)
                .IsUnicode(false);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_AGE)
                .HasPrecision(4, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_IS_INCOMING_CALL)
                .HasPrecision(1, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.SCUP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .Property(e => e.WRT_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_TEMP_PROFILES>()
                .HasMany(e => e.WR_INTERVIEW_AND_WORKER)
                .WithRequired(e => e.WR_TEMP_PROFILES)
                .HasForeignKey(e => e.IdTempProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WAGES>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WAGES>()
                .Property(e => e.WRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WAGES>()
                .Property(e => e.WRW_COST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_WAGES>()
                .Property(e => e.WRW_COST_INC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<WR_WAGES>()
                .Property(e => e.WRW_HOURS_INC)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WAGES>()
                .Property(e => e.WRW_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WAGES>()
                .HasMany(e => e.CL_WR_WAGE)
                .WithRequired(e => e.WR_WAGES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WAGES>()
                .HasMany(e => e.OR_ORDER_WORKER_HISTORY)
                .WithRequired(e => e.WR_WAGES)
                .HasForeignKey(e => e.WORKER_RATE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WAGES>()
                .HasMany(e => e.WR_WAGES_OPTIONS)
                .WithRequired(e => e.WR_WAGES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WAGES>()
                .HasMany(e => e.WR_WAGES1)
                .WithOptional(e => e.WR_WAGES2)
                .HasForeignKey(e => e.WRW_MASTER_ID);

            modelBuilder.Entity<WR_WAGES_OPTIONS>()
                .HasOptional(e => e.WR_WAGES_OPTIONS_LMK)
                .WithRequired(e => e.WR_WAGES_OPTIONS);

            modelBuilder.Entity<WR_WAGES_OPTIONS_LMK>()
                .Property(e => e.LMK_COST)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WAGES_PERIODS>()
                .Property(e => e.WGP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WAITING_FOR_FMS_RESPONSE>()
                .Property(e => e.UnId)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WAITING_FOR_FMS_RESPONSE>()
                .Property(e => e.WrId)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WAITING_FOR_FMS_RESPONSE>()
                .Property(e => e.IdDocType)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_ACTION_BRING_FRIEND>()
                .Property(e => e.FRIEND_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_ACTION_BRING_FRIEND>()
                .Property(e => e.FRIEND_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_ACTION_PAYMENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_ACTION_PAYMENTS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_ACTION_PAYMENTS>()
                .HasMany(e => e.WR_WORKER_ACTION_BRING_FRIEND)
                .WithRequired(e => e.WR_WORKER_ACTION_PAYMENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKER_ACTION_PAYMENTS>()
                .HasMany(e => e.WR_WORKER_ACTION_PAYMENTS_HISTORY)
                .WithRequired(e => e.WR_WORKER_ACTION_PAYMENTS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKER_ACTION_PAYMENTS_HISTORY>()
                .HasMany(e => e.AC_ACCRUALS_WORKER_ACTION_PAYMENTS)
                .WithRequired(e => e.WR_WORKER_ACTION_PAYMENTS_HISTORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKER_COMMENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_COMMENTS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_COMMENTS>()
                .Property(e => e.WC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_COMMENTS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_COMMENTS>()
                .Property(e => e.WC_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKER_DOC_CONTENT>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOC_CONTENT>()
                .Property(e => e.ID_WORKER_DOC)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCS_ATTRIBUTES>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCS_ATTRIBUTES>()
                .Property(e => e.WORKER_DOC_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCS_ATTRIBUTES>()
                .Property(e => e.ID_DOC_STATE_ATTR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCS_ATTRIBUTES>()
                .HasMany(e => e.WR_WORKER_DOCUMENT_ATTR_CONTENT)
                .WithRequired(e => e.WR_WORKER_DOCS_ATTRIBUTES)
                .HasForeignKey(e => e.ID_DOCUMENT_ATTR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKER_DOCUMENT_ATTR_CONTENT>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCUMENT_ATTR_CONTENT>()
                .Property(e => e.ID_DOCUMENT_ATTR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCUMENT_ATTR_CONTENT>()
                .Property(e => e.ATTR_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKER_DOCUMENTS>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCUMENTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCUMENTS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCUMENTS>()
                .Property(e => e.DOC_STATE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_DOCUMENTS>()
                .HasMany(e => e.WR_WORKER_DOC_CONTENT)
                .WithRequired(e => e.WR_WORKER_DOCUMENTS)
                .HasForeignKey(e => e.ID_WORKER_DOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKER_DOCUMENTS>()
                .HasMany(e => e.WR_WORKER_DOCS_ATTRIBUTES)
                .WithRequired(e => e.WR_WORKER_DOCUMENTS)
                .HasForeignKey(e => e.WORKER_DOC_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKER_REFERENCES>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_REFERENCES>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_REFERENCES>()
                .Property(e => e.REF_ID)
                .HasPrecision(5, 0);

            modelBuilder.Entity<WR_WORKER_VACATIONS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_VACATIONS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_VACATIONS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_WORK_TYPE>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_WORK_TYPE>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKER_WORK_TYPE>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.ST_ID_CURR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.ST_ID_OLD)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.SZ_SIZE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_FAMILY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_FATHER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_PASS_NUMBER_FIRST)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_PASS_NUMBER_SECOND)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_PASS_UNIT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_PASS_WHO_GIVE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_PASS_REG_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDRESS_FACT_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDRESS_FACT_STREET)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDRESS_FACT_HOME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDRESS_FACT_BUILDING)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDRESS_FACT_APARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_NEAR_METRO_STATION)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_PHONE_HOME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_PHONE_MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_MEDICAL_BOOK)
                .HasPrecision(1, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_EDUCATION)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_WHERE_STUDY)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_WHY_SEARCH_WORK)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_WHERE_KNOW_ABOUT_COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_RECOMMENDATION)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_MARK)
                .HasPrecision(1, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_IMAGE_SRC)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_DAYS_TO_RET_OLD_STAT)
                .HasPrecision(4, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.MR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.NT_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_HEIGHT)
                .HasPrecision(4, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_FRIEND_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_FRIEND_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_RECRUTER_UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_RECRUTER_WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_COUNTRY_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_REGION_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_DISTRICT_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_TOWN_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_STREET_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_HOUSE_KLADR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_BUILDING_KLADR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_ADDR_ROOM_KLADR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_COUNTRY_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_REGION_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_DISTRICT_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_TOWN_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_STREET_KLADR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_HOUSE_KLADR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_BUILDING_KLADR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_REG_ROOM_KLADR)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_WHY_CHANGE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_MOTHERLAND)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_BIRTH_PLACE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_POSITION_LAT)
                .HasPrecision(18, 8);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_POSITION_LNG)
                .HasPrecision(18, 8);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.OIS_SITE_NAME)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_SECURITY_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_IS_SECURITY_STATUS)
                .HasPrecision(1, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_RecruiterActionType)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_RecruiterSum)
                .HasPrecision(6, 2);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.WR_BIRTH_PLACE_TOWN)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .Property(e => e.wr_ctzn_reg_address)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.AC_ACCURAL)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.CC_BLOCK)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.CC_CALL_RESULTS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.CCR_UN_ID, e.CCR_WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.CC_MANAGER_TASK_WORKERS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.CC_WORKER_REMINDS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.CWR_UN_ID, e.CWR_WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.CL_BLACKLIST)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.FIRE_MACHINE)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.GREEN_LIST)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID });

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.LOG_CC_IN_OUT)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.NT_BLACKLIST)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.OR_ORDER_WORKERS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.OR_PRE_ADD)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.tmp_calc_worker)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UnId, e.WrId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.TMP_RETURN_KEEPING)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_ACTION_15x15)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.WR_FRIEND_UN_ID, e.WR_FRIEND_WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_ACTION_15x151)
                .WithRequired(e => e.WR_WORKERS1)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_ACTION_BRING_FRIEND_2012_CALCS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_ACTION_BRING_FRIEND_2012_CALCS1)
                .WithRequired(e => e.WR_WORKERS1)
                .HasForeignKey(e => new { e.FUN_ID, e.FWR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_ACTION_STOKMANN_2012)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_ACTION_STOKMANN_20121)
                .WithRequired(e => e.WR_WORKERS1)
                .HasForeignKey(e => new { e.FUN_ID, e.FWR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_BANK_PROFILES)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_CARDS_LOST)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_CHARGE)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_DISMISSAL_ITEMS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_IMAGES)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_KEEPING)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_LABOR_CONTRACTS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasOptional(e => e.WR_LENTA_CARD)
                .WithRequired(e => e.WR_WORKERS);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_MEDICAL_BOOKS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_RECRUITER)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID_MASTER, e.WR_ID_MASTER })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_RECRUITER1)
                .WithRequired(e => e.WR_WORKERS1)
                .HasForeignKey(e => new { e.UN_ID_SLAVE, e.WR_ID_SLAVE })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_WAITING_FOR_FMS_RESPONSE)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UnId, e.WrId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_WORKER_ACTION_BRING_FRIEND)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.FRIEND_UN_ID, e.FRIEND_WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_WORKER_ACTION_PAYMENTS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_WORKER_DOCUMENTS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_WORKER_VACATIONS)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS>()
                .HasMany(e => e.WR_20x100COUNTER)
                .WithRequired(e => e.WR_WORKERS)
                .HasForeignKey(e => new { e.UN_ID, e.WR_ID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS>()
                .Property(e => e.WrExtID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS>()
                .Property(e => e.DATA)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS>()
                .Property(e => e.WR_WORKERS_EXTENSIONS_TYPE_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS>()
                .Property(e => e.USER_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS_TYPE>()
                .Property(e => e.ExtensionTypeID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS_TYPE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS_TYPE>()
                .Property(e => e.WR_DataTypeId)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS_TYPE>()
                .Property(e => e.KEY_CHAR_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<WR_WORKERS_EXTENSIONS_TYPE>()
                .HasMany(e => e.WR_WORKERS_EXTENSIONS)
                .WithRequired(e => e.WR_WORKERS_EXTENSIONS_TYPE)
                .HasForeignKey(e => e.WR_WORKERS_EXTENSIONS_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.WRG_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.WRW_COST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.WRW_COST_INC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.WRW_HOURS_INC)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.WGP_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ARCHIVE_WR_WAGES>()
                .Property(e => e.WRW_COST_LMK)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CGN_BONUS_CLIENTS>()
                .Property(e => e.CGN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_BONUS_CLIENTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<CGN_BONUS_CLIENTS>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LG_USERS_ACTS>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LG_USERS_ACTS>()
                .Property(e => e.ACTION_TYPE)
                .HasPrecision(3, 0);

            modelBuilder.Entity<LG_USERS_ACTS>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LG_USERS_ACTS>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LG_USERS_ACTS>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<LG_USERS_ACTS>()
                .Property(e => e.AC_COMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.DEFAULT_STATUS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.MIN_DAYS_IN_CALC)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.START_NUM_WORKERS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.START_NUM_USERS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.START_NUM_CLIENTS)
                .HasPrecision(10, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.COUNT_NUM_UNIT_IN_BAGE)
                .HasPrecision(2, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.COUNT_NUM_ID_IN_BAGE)
                .HasPrecision(2, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.FILTER_DEF_COUNT_DAYS_WORKING_FROM_START)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.FILTER_DEF_COUNT_DAYS_WORKING_TO_START)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.FILTER_DEF_COUNT_DAYS_FROM_INSERT)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.DEFAULT_CALL_AFTER_MINUTES)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.MAX_CALL_AFTER_MON)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.MAX_UPPER_WORK_PERS)
                .HasPrecision(4, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.PAY_FOR_FRIEND)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.COUNT_ORDERS_BY_FRIEND)
                .HasPrecision(3, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.BONUS_RECRUTER_BY_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.MIN_REST)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.PASSWORD_EXPIRE_DAYS)
                .HasPrecision(5, 0);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.COVER_MAIL_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<OPT_OPTIONS>()
                .Property(e => e.INV_STATUS_MAIL_BODY_TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USER_ROLES>()
                .Property(e => e.ROL_ROLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<SC_USER_ROLES>()
                .Property(e => e.US_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TMP_COUNTERS>()
                .Property(e => e.TMP_COUNTER)
                .HasPrecision(3, 0);

            modelBuilder.Entity<tmp_old_costs>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_old_costs>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tmp_old_costs>()
                .Property(e => e.CWC_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tmp_old_costs>()
                .Property(e => e.CWC_DOC_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_old_costs>()
                .Property(e => e.CWC_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tmp_old_costs>()
                .Property(e => e.WT_NAME_IN_DEAL)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_old_order_costs>()
                .Property(e => e.or_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tmp_old_order_costs>()
                .Property(e => e.OR_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tmpCL_WORK_COSTS>()
                .Property(e => e.WT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<tmpCL_WORK_COSTS>()
                .Property(e => e.CL_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tmpCL_WORK_COSTS>()
                .Property(e => e.CWC_NUM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tmpCL_WORK_COSTS>()
                .Property(e => e.CWC_DOC_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<tmpCL_WORK_COSTS>()
                .Property(e => e.CWC_COST_HUMAN_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tmpCL_WORK_COSTS>()
                .Property(e => e.WT_NAME_IN_DEAL)
                .IsUnicode(false);

            modelBuilder.Entity<WR_20x100COUNTER>()
                .Property(e => e.ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_20x100COUNTER>()
                .Property(e => e.UN_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_20x100COUNTER>()
                .Property(e => e.WR_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<WR_20x100COUNTER>()
                .Property(e => e.OR_ID)
                .HasPrecision(10, 0);
        }
    }
}
