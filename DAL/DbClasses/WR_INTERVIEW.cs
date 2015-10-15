namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_INTERVIEW
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_INTERVIEW()
        {
            WR_INTERVIEW_AND_WORKER = new HashSet<WR_INTERVIEW_AND_WORKER>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdInterViewType { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IdPlace { get; set; }

        public int IdSheduleItem { get; set; }

        public int Duration { get; set; }

        public string Address { get; set; }

        public string HowToGet { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public virtual OPT_INTERVIEW_TYPE OPT_INTERVIEW_TYPE { get; set; }

        public virtual SC_UNIT_PLACES SC_UNIT_PLACES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_INTERVIEW_AND_WORKER> WR_INTERVIEW_AND_WORKER { get; set; }

        public virtual WR_SHEDULE_ITEM WR_SHEDULE_ITEM { get; set; }
    }
}
