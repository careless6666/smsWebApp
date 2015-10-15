namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_IMG_NAMES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_IMG_NAMES()
        {
            WR_IMAGES = new HashSet<WR_IMAGES>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal IN_ID { get; set; }

        [StringLength(50)]
        public string IN_NAME { get; set; }

        public bool IN_IS_PASSPORT { get; set; }

        public bool IN_IS_SIGNATURE { get; set; }

        public bool IN_IS_REGISTRATION { get; set; }

        public bool IN_IS_WORK_RECORD_CARD { get; set; }

        public bool IN_IS_INN { get; set; }

        public bool IN_IS_INSURANCE { get; set; }

        public bool IN_IS_MILITARY_CARD { get; set; }

        public bool IN_IS_DIPLOMA { get; set; }

        public bool IN_IS_MEDICAL_CARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_IMAGES> WR_IMAGES { get; set; }
    }
}
