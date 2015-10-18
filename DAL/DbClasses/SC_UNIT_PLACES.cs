namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SC_UNIT_PLACES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SC_UNIT_PLACES()
        {
            SC_BANK_SIGNS_RESP = new HashSet<SC_BANK_SIGNS_RESP>();
            SC_PLACES_SMS = new HashSet<SC_PLACES_SMS>();
            WR_INTERVIEW = new HashSet<WR_INTERVIEW>();
        }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal SCUP_ID { get; set; }

        [StringLength(50)]
        public string SCUP_NAME { get; set; }

        public bool SCUP_IS_INTERVIEW_PLACE { get; set; }

        [StringLength(300)]
        public string SCUP_ADDRESS { get; set; }

        [StringLength(8000)]
        public string SCUP_HOWTOGET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_BANK_SIGNS_RESP> SC_BANK_SIGNS_RESP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_PLACES_SMS> SC_PLACES_SMS { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_INTERVIEW> WR_INTERVIEW { get; set; }
    }
}
