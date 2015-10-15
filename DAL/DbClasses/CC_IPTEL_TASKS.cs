namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_TASKS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_IPTEL_TASKS()
        {
            CC_IPTEL_TASK_CAMPAIGN = new HashSet<CC_IPTEL_TASK_CAMPAIGN>();
            CC_IPTEL_TASK_ORDER = new HashSet<CC_IPTEL_TASK_ORDER>();
            CC_RECALL_TASK = new HashSet<CC_RECALL_TASK>();
            CC_MANAGER_TASK = new HashSet<CC_MANAGER_TASK>();
            SC_USERS = new HashSet<SC_USERS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CIT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CIT_TASK_TYPE { get; set; }

        public DateTime CIT_CREATED { get; set; }

        public DateTime CIT_DISACTIVATED { get; set; }

        public int CIT_PRIORITY { get; set; }

        public int CIT_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_TASK_CAMPAIGN> CC_IPTEL_TASK_CAMPAIGN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_TASK_ORDER> CC_IPTEL_TASK_ORDER { get; set; }

        public virtual CC_IPTEL_TASK_PRIORITY CC_IPTEL_TASK_PRIORITY { get; set; }

        public virtual CC_IPTEL_TASK_STATUS CC_IPTEL_TASK_STATUS { get; set; }

        public virtual CC_IPTEL_TASK_TYPES CC_IPTEL_TASK_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_RECALL_TASK> CC_RECALL_TASK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_MANAGER_TASK> CC_MANAGER_TASK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_USERS> SC_USERS { get; set; }
    }
}
