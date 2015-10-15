namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_JURI_NAMES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_JURI_NAMES()
        {
            CL_CONTRACT = new HashSet<CL_CONTRACT>();
            LE_SIGN = new HashSet<LE_SIGN>();
            CL_JURI_NAMES_EXTENSIONS = new HashSet<CL_JURI_NAMES_EXTENSIONS>();
            CL_JURI_NETS = new HashSet<CL_JURI_NETS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLJN_ID { get; set; }

        [Required]
        [StringLength(256)]
        public string CLJN_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string CLJN_ORGANIZATION_TYPE { get; set; }

        [Required]
        [StringLength(256)]
        public string CLJN_SHORT_NAME { get; set; }

        [Required]
        [StringLength(500)]
        public string CLJN_ADDRESS { get; set; }

        [Required]
        [StringLength(100)]
        public string CLJN_INN { get; set; }

        [Required]
        [StringLength(100)]
        public string CLJN_KPP { get; set; }

        [Required]
        [StringLength(50)]
        public string CLJN_CURRENT_ACCOUNT { get; set; }

        [Required]
        [StringLength(50)]
        public string CLJN_OFFSETING_ACCOUNT { get; set; }

        [Required]
        [StringLength(300)]
        public string CLJN_BANK { get; set; }

        [Required]
        [StringLength(50)]
        public string CLJN_BIC { get; set; }

        [Required]
        [StringLength(300)]
        public string CLJN_SIGNATORY { get; set; }

        public bool IS_INNER { get; set; }

        [Required]
        [StringLength(200)]
        public string CLJN_PHONE_NUMBERS { get; set; }

        public int TAX_TYPE_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT> CL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LE_SIGN> LE_SIGN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_JURI_NAMES_EXTENSIONS> CL_JURI_NAMES_EXTENSIONS { get; set; }

        public virtual CL_LEGAL_ENTITY_TAXATION_TYPES CL_LEGAL_ENTITY_TAXATION_TYPES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_JURI_NETS> CL_JURI_NETS { get; set; }
    }
}
