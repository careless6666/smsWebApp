namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_INTERNAL_CONTRACT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_INTERNAL_CONTRACT()
        {
            WR_WAGES = new HashSet<WR_WAGES>();
        }

        [Key]
        public int WIC_ID { get; set; }

        public DateTime WIC_DATE_FROM { get; set; }

        public DateTime WIC_DATE_TO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ADDED { get; set; }

        public DateTime DATE_ADDED { get; set; }

        public byte[] WIC_DATA { get; set; }

        public int FILE_EXT { get; set; }

        [Required]
        [StringLength(50)]
        public string NUMBER { get; set; }

        public virtual OPT_FILE_EXTENSIONS OPT_FILE_EXTENSIONS { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual SC_USERS SC_USERS1 { get; set; }

        public virtual SC_USERS SC_USERS2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WAGES> WR_WAGES { get; set; }
    }
}
