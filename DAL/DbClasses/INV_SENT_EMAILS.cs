namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INV_SENT_EMAILS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INV_SENT_EMAILS()
        {
            INV_INVOICE = new HashSet<INV_INVOICE>();
        }

        [Key]
        public int EMAIL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FROM_US_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TO_US_ID { get; set; }

        public DateTime SENT_DATE { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }

        public virtual SC_USERS SC_USERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_INVOICE> INV_INVOICE { get; set; }
    }
}
