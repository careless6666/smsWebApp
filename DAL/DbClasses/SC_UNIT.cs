namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_UNIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SC_UNIT()
        {
            AC_BANKS_UNITS = new HashSet<AC_BANKS_UNITS>();
            ACT_ACTIONS = new HashSet<ACT_ACTIONS>();
            CC_MANAGER_TASK = new HashSet<CC_MANAGER_TASK>();
            CGN_CAMPAIGN = new HashSet<CGN_CAMPAIGN>();
            CGNT_FIN_UNIT_UNIT = new HashSet<CGNT_FIN_UNIT_UNIT>();
            CL_CLIENTS = new HashSet<CL_CLIENTS>();
            LE_SIGN = new HashSet<LE_SIGN>();
            NT_NET_REQUIREMENTS = new HashSet<NT_NET_REQUIREMENTS>();
            NT_RANGE_REQUIREMENTS = new HashSet<NT_RANGE_REQUIREMENTS>();
            OPT_DISMISSAL_ITEM_COST = new HashSet<OPT_DISMISSAL_ITEM_COST>();
            OPT_EMAILS = new HashSet<OPT_EMAILS>();
            OPT_HOSTEL = new HashSet<OPT_HOSTEL>();
            OPT_INFO_SITES = new HashSet<OPT_INFO_SITES>();
            OPT_KEEPING_UNITS = new HashSet<OPT_KEEPING_UNITS>();
            OPT_MAIN_REGIONS = new HashSet<OPT_MAIN_REGIONS>();
            OPT_MAIN_REGIONS1 = new HashSet<OPT_MAIN_REGIONS>();
            OPT_REFERENCES_UNIT = new HashSet<OPT_REFERENCES_UNIT>();
            OPT_REGIONAL_PENALTY_COSTS = new HashSet<OPT_REGIONAL_PENALTY_COSTS>();
            OPT_REGIONAL_SMS = new HashSet<OPT_REGIONAL_SMS>();
            OPT_SHIFTS_BEFORE_PAY = new HashSet<OPT_SHIFTS_BEFORE_PAY>();
            OPT_TEL_CODE_ZONES = new HashSet<OPT_TEL_CODE_ZONES>();
            SC_RELATED_UNITS = new HashSet<SC_RELATED_UNITS>();
            SC_RELATED_UNITS1 = new HashSet<SC_RELATED_UNITS>();
            SC_UNIT_PLACES = new HashSet<SC_UNIT_PLACES>();
            WR_MIN_RESTS = new HashSet<WR_MIN_RESTS>();
            WR_WORKERS = new HashSet<WR_WORKERS>();
            SC_USERS = new HashSet<SC_USERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [StringLength(20)]
        public string UN_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UN_MIN_REST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UN_HOUR_OFFSET { get; set; }

        [StringLength(255)]
        public string IP_TEL_LINE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_POSITION_LAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_POSITION_LNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_BANKS_UNITS> AC_BANKS_UNITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACT_ACTIONS> ACT_ACTIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_MANAGER_TASK> CC_MANAGER_TASK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGN_CAMPAIGN> CGN_CAMPAIGN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGNT_FIN_UNIT_UNIT> CGNT_FIN_UNIT_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS> CL_CLIENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LE_SIGN> LE_SIGN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NT_NET_REQUIREMENTS> NT_NET_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NT_RANGE_REQUIREMENTS> NT_RANGE_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_DISMISSAL_ITEM_COST> OPT_DISMISSAL_ITEM_COST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_EMAILS> OPT_EMAILS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_HOSTEL> OPT_HOSTEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_INFO_SITES> OPT_INFO_SITES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_KEEPING_UNITS> OPT_KEEPING_UNITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_MAIN_REGIONS> OPT_MAIN_REGIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_MAIN_REGIONS> OPT_MAIN_REGIONS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_REFERENCES_UNIT> OPT_REFERENCES_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_REGIONAL_PENALTY_COSTS> OPT_REGIONAL_PENALTY_COSTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_REGIONAL_SMS> OPT_REGIONAL_SMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_SHIFTS_BEFORE_PAY> OPT_SHIFTS_BEFORE_PAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_TEL_CODE_ZONES> OPT_TEL_CODE_ZONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_RELATED_UNITS> SC_RELATED_UNITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_RELATED_UNITS> SC_RELATED_UNITS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_UNIT_PLACES> SC_UNIT_PLACES { get; set; }

        public virtual WR_ACTION_BRING_FRIEND_2012_UNITS WR_ACTION_BRING_FRIEND_2012_UNITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_MIN_RESTS> WR_MIN_RESTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKERS> WR_WORKERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_USERS> SC_USERS { get; set; }
    }
}
