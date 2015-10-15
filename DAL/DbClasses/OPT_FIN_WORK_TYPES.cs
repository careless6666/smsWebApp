namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_FIN_WORK_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_FIN_WORK_TYPES()
        {
            CGNT_BILL_ITEM = new HashSet<CGNT_BILL_ITEM>();
            OPT_FIN_BDP_WORK_TYPES = new HashSet<OPT_FIN_BDP_WORK_TYPES>();
        }

        [Key]
        public int FWT_ID { get; set; }

        [StringLength(100)]
        public string FWT_NAME { get; set; }

        public Guid? FWT_FIN_ID { get; set; }

        [StringLength(20)]
        public string FWT_UNIT_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGNT_BILL_ITEM> CGNT_BILL_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_FIN_BDP_WORK_TYPES> OPT_FIN_BDP_WORK_TYPES { get; set; }
    }
}
