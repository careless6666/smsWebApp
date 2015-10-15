namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CLIENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_CLIENTS()
        {
            CL_ACTUAL_SETTINGS = new HashSet<CL_ACTUAL_SETTINGS>();
            CL_BLACKLIST = new HashSet<CL_BLACKLIST>();
            CL_CLIENTS_USERS = new HashSet<CL_CLIENTS_USERS>();
            CL_CLIENTS_CONTRAGENT = new HashSet<CL_CLIENTS_CONTRAGENT>();
            CL_RANGE_REQUIREMENTS = new HashSet<CL_RANGE_REQUIREMENTS>();
            CL_RATE = new HashSet<CL_RATE>();
            CL_WR_WAGE = new HashSet<CL_WR_WAGE>();
            CGN_BONUS_CLIENTS = new HashSet<CGN_BONUS_CLIENTS>();
            CL_CLIENTS_NETS_DEPARTEMNTS = new HashSet<CL_CLIENTS_NETS_DEPARTEMNTS>();
            CL_SUPERVISORS = new HashSet<CL_SUPERVISORS>();
            GREEN_LIST = new HashSet<GREEN_LIST>();
            CL_CONTACTS = new HashSet<CL_CONTACTS>();
            OR_ORDER = new HashSet<OR_ORDER>();
            CL_WORK_COSTS = new HashSet<CL_WORK_COSTS>();
            CL_CLIENTS1 = new HashSet<CL_CLIENTS>();
            CL_CLIENTS2 = new HashSet<CL_CLIENTS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CL_ID { get; set; }

        [StringLength(511)]
        public string CL_NAME { get; set; }

        [StringLength(300)]
        public string CL_ADDRESS { get; set; }

        [StringLength(150)]
        public string CL_PHONE { get; set; }

        [StringLength(8000)]
        public string CL_INFO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NT_ID { get; set; }

        [StringLength(200)]
        public string CL_SITE { get; set; }

        public DateTime? CL_DATEADD { get; set; }

        public bool? IS_DINNER_BONUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_POSITION_LAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_POSITION_LNG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Required]
        [StringLength(1024)]
        public string CL_EMAIL { get; set; }

        public int? CLJN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CL_PERMANENTW_PERCENT { get; set; }

        [StringLength(8000)]
        public string CL_HOW_TO_GET { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CL_PRIORITY { get; set; }

        public bool CL_IS_TECHNICAL { get; set; }

        public string CL_SMS_ADDRESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_ACTUAL_SETTINGS> CL_ACTUAL_SETTINGS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_BLACKLIST> CL_BLACKLIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS_USERS> CL_CLIENTS_USERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS_CONTRAGENT> CL_CLIENTS_CONTRAGENT { get; set; }

        public virtual CL_PRIORITY CL_PRIORITY1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_RANGE_REQUIREMENTS> CL_RANGE_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_RATE> CL_RATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_WR_WAGE> CL_WR_WAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGN_BONUS_CLIENTS> CGN_BONUS_CLIENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS_NETS_DEPARTEMNTS> CL_CLIENTS_NETS_DEPARTEMNTS { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual CL_MAIL_TEMPLATES CL_MAIL_TEMPLATES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_SUPERVISORS> CL_SUPERVISORS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GREEN_LIST> GREEN_LIST { get; set; }

        public virtual CL_NETS CL_NETS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTACTS> CL_CONTACTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER> OR_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_WORK_COSTS> CL_WORK_COSTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS> CL_CLIENTS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS> CL_CLIENTS2 { get; set; }
    }
}
