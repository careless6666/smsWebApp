namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_BANKS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AC_BANKS()
        {
            AC_BANKS_UNITS = new HashSet<AC_BANKS_UNITS>();
            BANK_TRANSFERS = new HashSet<BANK_TRANSFERS>();
            WR_CARDS_ROSEURO = new HashSet<WR_CARDS_ROSEURO>();
            OPT_BANK_CARDS = new HashSet<OPT_BANK_CARDS>();
            SC_BANK_SIGNS_RESP = new HashSet<SC_BANK_SIGNS_RESP>();
            WR_BANK_PROFILES = new HashSet<WR_BANK_PROFILES>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal AB_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string AB_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_BANKS_UNITS> AC_BANKS_UNITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANK_TRANSFERS> BANK_TRANSFERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CARDS_ROSEURO> WR_CARDS_ROSEURO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_BANK_CARDS> OPT_BANK_CARDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SC_BANK_SIGNS_RESP> SC_BANK_SIGNS_RESP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_BANK_PROFILES> WR_BANK_PROFILES { get; set; }
    }
}
