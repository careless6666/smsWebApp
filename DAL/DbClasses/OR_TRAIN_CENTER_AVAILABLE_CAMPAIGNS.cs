namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OR_TRAIN_CENTER_AVAILABLE_CAMPAIGNS()
        {
            OR_TRAIN_CENTER_WORKERS_CAMPAIGN = new HashSet<OR_TRAIN_CENTER_WORKERS_CAMPAIGN>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal CGN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORTC_WORKERS_MAX { get; set; }

        public virtual CGN_CAMPAIGN CGN_CAMPAIGN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_TRAIN_CENTER_WORKERS_CAMPAIGN> OR_TRAIN_CENTER_WORKERS_CAMPAIGN { get; set; }
    }
}
