namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGNT_BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CGNT_BILL()
        {
            CGNT_BILL_ITEM = new HashSet<CGNT_BILL_ITEM>();
        }

        [Key]
        public int BL_ID { get; set; }

        [StringLength(50)]
        public string BL_NUM { get; set; }

        public int CGNT_ID { get; set; }

        public DateTime? BL_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BL_SUM { get; set; }

        public Guid? BL_FIN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BL_TAX_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGNT_BILL_ITEM> CGNT_BILL_ITEM { get; set; }

        public virtual CGNT_CONTRAGENT CGNT_CONTRAGENT { get; set; }
    }
}
