namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_PAYMENT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WR_PAYMENT_TYPE()
        {
            WR_PAYMENT = new HashSet<WR_PAYMENT>();
        }

        [Key]
        public byte ACT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string ACT_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string ACT_KEYCHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_PAYMENT> WR_PAYMENT { get; set; }
    }
}
