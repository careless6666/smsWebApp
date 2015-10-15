namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CONTRACT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_CONTRACT()
        {
            CL_CONTRACT_ITEM = new HashSet<CL_CONTRACT_ITEM>();
            CL_CONTRACT1 = new HashSet<CL_CONTRACT>();
            INV_INVOICE = new HashSet<INV_INVOICE>();
            LE_OBLIGATION = new HashSet<LE_OBLIGATION>();
            OR_ORDER_HISTORY = new HashSet<OR_ORDER_HISTORY>();
        }

        [Key]
        public int CON_ID { get; set; }

        public int? CON_MASTER_ID { get; set; }

        public int CLJN_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CON_NUMBER { get; set; }

        public DateTime CON_DATE_FROM { get; set; }

        public DateTime CON_DATE_TO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CON_MIN_DURATION { get; set; }

        public DateTime CON_DATE { get; set; }

        [Required]
        [StringLength(100)]
        public string CON_SIGNATORY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RP_SIGNATORY { get; set; }

        public byte[] CON_DATA { get; set; }

        [StringLength(10)]
        public string CON_DATA_EXT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ADDED { get; set; }

        public DateTime DATE_ADDED { get; set; }

        public bool IS_MISTAKEN { get; set; }

        public int INNER_CLJN_ID { get; set; }

        public virtual CL_JURI_NAMES CL_JURI_NAMES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT_ITEM> CL_CONTRACT_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT> CL_CONTRACT1 { get; set; }

        public virtual CL_CONTRACT CL_CONTRACT2 { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual SC_USERS SC_USERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_INVOICE> INV_INVOICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LE_OBLIGATION> LE_OBLIGATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_ORDER_HISTORY> OR_ORDER_HISTORY { get; set; }
    }
}
