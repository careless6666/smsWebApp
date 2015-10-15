namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_WORK_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_WORK_TYPES()
        {
            CL_CLIENT_REQUIREMENTS = new HashSet<CL_CLIENT_REQUIREMENTS>();
            CL_CONTRACT_WORK_TYPE = new HashSet<CL_CONTRACT_WORK_TYPE>();
            CL_RANGE_REQUIREMENTS = new HashSet<CL_RANGE_REQUIREMENTS>();
            CL_WORK_COSTS = new HashSet<CL_WORK_COSTS>();
            OPT_FIN_BDP_WORK_TYPES = new HashSet<OPT_FIN_BDP_WORK_TYPES>();
            CGN_BONUS_CLIENTS = new HashSet<CGN_BONUS_CLIENTS>();
            WR_WAGES = new HashSet<WR_WAGES>();
            WR_WORKER_WORK_TYPE = new HashSet<WR_WORKER_WORK_TYPE>();
            OR_ORDER = new HashSet<OR_ORDER>();
        }

        [Key]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WT_COST { get; set; }

        public bool? WT_IS_OFFICE { get; set; }

        public bool? WT_IS_BY_JOB { get; set; }

        [StringLength(50)]
        public string WT_UNIT_NAME { get; set; }

        [StringLength(200)]
        public string WT_SERVICE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENT_REQUIREMENTS> CL_CLIENT_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT_WORK_TYPE> CL_CONTRACT_WORK_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_RANGE_REQUIREMENTS> CL_RANGE_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_WORK_COSTS> CL_WORK_COSTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_FIN_BDP_WORK_TYPES> OPT_FIN_BDP_WORK_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGN_BONUS_CLIENTS> CGN_BONUS_CLIENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WAGES> WR_WAGES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WORKER_WORK_TYPE> WR_WORKER_WORK_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER> OR_ORDER { get; set; }
    }
}
