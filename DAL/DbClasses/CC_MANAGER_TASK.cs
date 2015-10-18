namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_MANAGER_TASK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC_MANAGER_TASK()
        {
            CC_MANAGER_TASK_CANDIDATES = new HashSet<CC_MANAGER_TASK_CANDIDATES>();
            CC_MANAGER_TASK_WORKERS = new HashSet<CC_MANAGER_TASK_WORKERS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TASK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CIT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string WORK_TYPE { get; set; }

        public int CALL_LIST_TYPE_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [StringLength(300)]
        public string COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public virtual CC_IPTEL_TASKS CC_IPTEL_TASKS { get; set; }

        public virtual CC_MANAGER_TASK_TYPE CC_MANAGER_TASK_TYPE { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_MANAGER_TASK_CANDIDATES> CC_MANAGER_TASK_CANDIDATES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_MANAGER_TASK_WORKERS> CC_MANAGER_TASK_WORKERS { get; set; }
    }
}
