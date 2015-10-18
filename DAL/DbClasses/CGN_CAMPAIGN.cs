namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGN_CAMPAIGN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CGN_CAMPAIGN()
        {
            CC_IPTEL_TASK_CAMPAIGN = new HashSet<CC_IPTEL_TASK_CAMPAIGN>();
            CGN_BONUS_CLIENTS = new HashSet<CGN_BONUS_CLIENTS>();
            CGN_QUEUE_ACTUALISATION = new HashSet<CGN_QUEUE_ACTUALISATION>();
            OR_ORDER_WORKERS = new HashSet<OR_ORDER_WORKERS>();
        }

        [Column(TypeName = "numeric")]
        public decimal CGNT_ID { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CGN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGN_WORKERS_NEED { get; set; }

        public DateTime CGN_DATE_START { get; set; }

        public DateTime CGN_DATE_END { get; set; }

        [Required]
        [StringLength(400)]
        public string CGNT_COMMENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UN_ID { get; set; }

        [Required]
        [StringLength(555)]
        public string CGN_ADDRESS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGN_POSITION_LAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CGN_POSITION_LNG { get; set; }

        public bool CGN_CALC_BONUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CC_IPTEL_TASK_CAMPAIGN> CC_IPTEL_TASK_CAMPAIGN { get; set; }

        public virtual CGN_CAMPAIGN_TYPES CGN_CAMPAIGN_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGN_BONUS_CLIENTS> CGN_BONUS_CLIENTS { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGN_QUEUE_ACTUALISATION> CGN_QUEUE_ACTUALISATION { get; set; }

        public virtual OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_WORKERS> OR_ORDER_WORKERS { get; set; }
    }
}
