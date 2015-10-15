namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WORKERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_WORKERS()
        {
            AC_ACCURAL = new HashSet<AC_ACCURAL>();
            CC_BLOCK = new HashSet<CC_BLOCK>();
            CC_CALL_RESULTS = new HashSet<CC_CALL_RESULTS>();
            CC_MANAGER_TASK_WORKERS = new HashSet<CC_MANAGER_TASK_WORKERS>();
            CC_WORKER_REMINDS = new HashSet<CC_WORKER_REMINDS>();
            CL_BLACKLIST = new HashSet<CL_BLACKLIST>();
            FIRE_MACHINE = new HashSet<FIRE_MACHINE>();
            GREEN_LIST = new HashSet<GREEN_LIST>();
            LOG_CC_IN_OUT = new HashSet<LOG_CC_IN_OUT>();
            NT_BLACKLIST = new HashSet<NT_BLACKLIST>();
            OR_ORDER_WORKERS = new HashSet<OR_ORDER_WORKERS>();
            OR_PRE_ADD = new HashSet<OR_PRE_ADD>();
            tmp_calc_worker = new HashSet<tmp_calc_worker>();
            TMP_RETURN_KEEPING = new HashSet<TMP_RETURN_KEEPING>();
            WR_ACTION_15x15 = new HashSet<WR_ACTION_15x15>();
            WR_ACTION_15x151 = new HashSet<WR_ACTION_15x15>();
            WR_ACTION_BRING_FRIEND_2012_CALCS = new HashSet<WR_ACTION_BRING_FRIEND_2012_CALCS>();
            WR_ACTION_BRING_FRIEND_2012_CALCS1 = new HashSet<WR_ACTION_BRING_FRIEND_2012_CALCS>();
            WR_ACTION_STOKMANN_2012 = new HashSet<WR_ACTION_STOKMANN_2012>();
            WR_ACTION_STOKMANN_20121 = new HashSet<WR_ACTION_STOKMANN_2012>();
            WR_BANK_PROFILES = new HashSet<WR_BANK_PROFILES>();
            WR_CARDS_LOST = new HashSet<WR_CARDS_LOST>();
            WR_CHARGE = new HashSet<WR_CHARGE>();
            WR_DISMISSAL_ITEMS = new HashSet<WR_DISMISSAL_ITEMS>();
            WR_IMAGES = new HashSet<WR_IMAGES>();
            WR_KEEPING = new HashSet<WR_KEEPING>();
            WR_LABOR_CONTRACTS = new HashSet<WR_LABOR_CONTRACTS>();
            WR_MEDICAL_BOOKS = new HashSet<WR_MEDICAL_BOOKS>();
            WR_RECRUITER = new HashSet<WR_RECRUITER>();
            WR_RECRUITER1 = new HashSet<WR_RECRUITER>();
            WR_WAITING_FOR_FMS_RESPONSE = new HashSet<WR_WAITING_FOR_FMS_RESPONSE>();
            WR_WORKER_ACTION_BRING_FRIEND = new HashSet<WR_WORKER_ACTION_BRING_FRIEND>();
            WR_WORKER_ACTION_PAYMENTS = new HashSet<WR_WORKER_ACTION_PAYMENTS>();
            WR_WORKER_DOCUMENTS = new HashSet<WR_WORKER_DOCUMENTS>();
            WR_WORKER_VACATIONS = new HashSet<WR_WORKER_VACATIONS>();
            WR_20x100COUNTER = new HashSet<WR_20x100COUNTER>();
        }

        [Column(TypeName = "numeric")]
        public decimal? ST_ID_CURR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ST_ID_OLD { get; set; }

        [Required]
        [StringLength(15)]
        public string SZ_SIZE_NAME { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal WR_ID { get; set; }

        [StringLength(50)]
        public string WR_FAMILY_NAME { get; set; }

        [StringLength(50)]
        public string WR_FATHER_NAME { get; set; }

        [StringLength(50)]
        public string WR_NAME { get; set; }

        public DateTime? WR_BIRTH_DAY { get; set; }

        public bool? WR_IS_CHILD { get; set; }

        [StringLength(50)]
        public string WR_PASS_NUMBER_FIRST { get; set; }

        [StringLength(50)]
        public string WR_PASS_NUMBER_SECOND { get; set; }

        [StringLength(50)]
        public string WR_PASS_UNIT_NUMBER { get; set; }

        [StringLength(250)]
        public string WR_PASS_WHO_GIVE { get; set; }

        public DateTime? WR_PASS_WHEN_GIVE { get; set; }

        [StringLength(250)]
        public string WR_PASS_REG_ADDRESS { get; set; }

        [StringLength(50)]
        public string WR_ADDRESS_FACT_CITY { get; set; }

        [StringLength(50)]
        public string WR_ADDRESS_FACT_STREET { get; set; }

        [StringLength(50)]
        public string WR_ADDRESS_FACT_HOME { get; set; }

        [StringLength(50)]
        public string WR_ADDRESS_FACT_BUILDING { get; set; }

        [StringLength(50)]
        public string WR_ADDRESS_FACT_APARTMENT { get; set; }

        [StringLength(50)]
        public string WR_NEAR_METRO_STATION { get; set; }

        [StringLength(50)]
        public string WR_PHONE_HOME { get; set; }

        [StringLength(50)]
        public string WR_PHONE_MOBILE { get; set; }

        [StringLength(50)]
        public string WR_EMAIL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_MEDICAL_BOOK { get; set; }

        [StringLength(50)]
        public string WR_EDUCATION { get; set; }

        [StringLength(50)]
        public string WR_WHERE_STUDY { get; set; }

        [StringLength(100)]
        public string WR_WHY_SEARCH_WORK { get; set; }

        [StringLength(100)]
        public string WR_WHERE_KNOW_ABOUT_COMPANY { get; set; }

        [StringLength(50)]
        public string WR_RECOMMENDATION { get; set; }

        public bool? WR_IS_TRUST_MVD { get; set; }

        public bool? WR_IS_WORK_MON { get; set; }

        public bool? WR_IS_WORK_TUE { get; set; }

        public bool? WR_IS_WORK_WED { get; set; }

        public bool? WR_IS_WORK_THU { get; set; }

        public bool? WR_IS_WORK_FRI { get; set; }

        public bool? WR_IS_WORK_SAT { get; set; }

        public bool? WR_IS_WORK_SUN { get; set; }

        [StringLength(8000)]
        public string WR_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_MARK { get; set; }

        public bool? WR_SEX { get; set; }

        [StringLength(100)]
        public string WR_IMAGE_SRC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_DAYS_TO_RET_OLD_STAT { get; set; }

        public DateTime? WR_DATE_CURR_STAT_SET { get; set; }

        public bool? WR_IS_OFFICE_WORKER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_HEIGHT { get; set; }

        public bool? WR_HAS_AUTO { get; set; }

        public bool? WR_HAS_DRIVER_LICENSE { get; set; }

        public bool? WR_HAS_DRIVER_CAT_A { get; set; }

        public bool? WR_HAS_DRIVER_CAT_B { get; set; }

        public bool? WR_HAS_DRIVER_CAT_C { get; set; }

        public bool? WR_HAS_DRIVER_CAT_D { get; set; }

        public bool? WR_HAS_DRIVER_CAT_E { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_FRIEND_UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_FRIEND_WR_ID { get; set; }

        public bool? WR_FRIEND_IS_BONUSED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_RECRUTER_UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_RECRUTER_WR_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ADDR_COUNTRY_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ADDR_REGION_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ADDR_DISTRICT_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ADDR_TOWN_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_ADDR_STREET_KLADR { get; set; }

        [StringLength(50)]
        public string WR_ADDR_HOUSE_KLADR { get; set; }

        [StringLength(50)]
        public string WR_ADDR_BUILDING_KLADR { get; set; }

        [StringLength(50)]
        public string WR_ADDR_ROOM_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_REG_COUNTRY_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_REG_REGION_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_REG_DISTRICT_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_REG_TOWN_KLADR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_REG_STREET_KLADR { get; set; }

        [StringLength(50)]
        public string WR_REG_HOUSE_KLADR { get; set; }

        [StringLength(50)]
        public string WR_REG_BUILDING_KLADR { get; set; }

        [StringLength(50)]
        public string WR_REG_ROOM_KLADR { get; set; }

        [StringLength(300)]
        public string WR_WHY_CHANGE_NAME { get; set; }

        [StringLength(300)]
        public string WR_MOTHERLAND { get; set; }

        [StringLength(300)]
        public string WR_BIRTH_PLACE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_POSITION_LAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_POSITION_LNG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OIS_SITE_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WRG_ID { get; set; }

        [StringLength(500)]
        public string WR_SECURITY_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WR_IS_SECURITY_STATUS { get; set; }

        public bool WR_IS_CONTRACT_WRITTEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_RecruiterActionType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WR_RecruiterSum { get; set; }

        public int CH_CARD_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string WR_BIRTH_PLACE_TOWN { get; set; }

        public Guid WR_GUID { get; set; }

        [StringLength(250)]
        public string wr_ctzn_reg_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCURAL> AC_ACCURAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_BLOCK> CC_BLOCK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_CALL_RESULTS> CC_CALL_RESULTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_MANAGER_TASK_WORKERS> CC_MANAGER_TASK_WORKERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_WORKER_REMINDS> CC_WORKER_REMINDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_BLACKLIST> CL_BLACKLIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIRE_MACHINE> FIRE_MACHINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GREEN_LIST> GREEN_LIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOG_CC_IN_OUT> LOG_CC_IN_OUT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NT_BLACKLIST> NT_BLACKLIST { get; set; }

        public virtual OPT_MARRIED_TYPES OPT_MARRIED_TYPES { get; set; }

        public virtual OPT_NATIONALITY_TYPES OPT_NATIONALITY_TYPES { get; set; }

        public virtual OPT_RecruiterTypes OPT_RecruiterTypes { get; set; }

        public virtual OPT_SIZES OPT_SIZES { get; set; }

        public virtual OPT_STATUSES OPT_STATUSES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKERS> OR_ORDER_WORKERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_PRE_ADD> OR_PRE_ADD { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmp_calc_worker> tmp_calc_worker { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TMP_RETURN_KEEPING> TMP_RETURN_KEEPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_ACTION_15x15> WR_ACTION_15x15 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_ACTION_15x15> WR_ACTION_15x151 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_ACTION_BRING_FRIEND_2012_CALCS> WR_ACTION_BRING_FRIEND_2012_CALCS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_ACTION_BRING_FRIEND_2012_CALCS> WR_ACTION_BRING_FRIEND_2012_CALCS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_ACTION_STOKMANN_2012> WR_ACTION_STOKMANN_2012 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_ACTION_STOKMANN_2012> WR_ACTION_STOKMANN_20121 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_BANK_PROFILES> WR_BANK_PROFILES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CARDS_LOST> WR_CARDS_LOST { get; set; }

        public virtual WR_CH_CARD WR_CH_CARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CHARGE> WR_CHARGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_DISMISSAL_ITEMS> WR_DISMISSAL_ITEMS { get; set; }

        public virtual WR_GROUPS WR_GROUPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_IMAGES> WR_IMAGES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_KEEPING> WR_KEEPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_LABOR_CONTRACTS> WR_LABOR_CONTRACTS { get; set; }

        public virtual WR_LENTA_CARD WR_LENTA_CARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_MEDICAL_BOOKS> WR_MEDICAL_BOOKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER> WR_RECRUITER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_RECRUITER> WR_RECRUITER1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WAITING_FOR_FMS_RESPONSE> WR_WAITING_FOR_FMS_RESPONSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_ACTION_BRING_FRIEND> WR_WORKER_ACTION_BRING_FRIEND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_ACTION_PAYMENTS> WR_WORKER_ACTION_PAYMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_DOCUMENTS> WR_WORKER_DOCUMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_VACATIONS> WR_WORKER_VACATIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_20x100COUNTER> WR_20x100COUNTER { get; set; }
    }
}
