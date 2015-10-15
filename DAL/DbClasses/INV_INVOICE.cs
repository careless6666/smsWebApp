namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_INVOICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INV_INVOICE()
        {
            INV_HISTORY = new HashSet<INV_HISTORY>();
            INV_ITEM = new HashSet<INV_ITEM>();
            INV_SIGN = new HashSet<INV_SIGN>();
            INV_SENT_EMAILS = new HashSet<INV_SENT_EMAILS>();
        }

        [Key]
        public int INV_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string INV_NUM { get; set; }

        public int CON_ID { get; set; }

        public DateTime INV_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INV_SUM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INV_VAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INV_TAX { get; set; }

        public DateTime DATE_FROM { get; set; }

        public DateTime DATE_TO { get; set; }

        [Required]
        public string Filters { get; set; }

        public virtual CL_CONTRACT CL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_HISTORY> INV_HISTORY { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ITEM> INV_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_SIGN> INV_SIGN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_SENT_EMAILS> INV_SENT_EMAILS { get; set; }
    }
}
