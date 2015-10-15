namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGNT_FIN_UNIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CGNT_FIN_UNIT()
        {
            CGNT_CONTRAGENT = new HashSet<CGNT_CONTRAGENT>();
            CGNT_FIN_UNIT_UNIT = new HashSet<CGNT_FIN_UNIT_UNIT>();
        }

        [Key]
        public int CUN_ID { get; set; }

        public Guid? CUN_FIN_ID { get; set; }

        [StringLength(20)]
        public string CUN_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGNT_CONTRAGENT> CGNT_CONTRAGENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGNT_FIN_UNIT_UNIT> CGNT_FIN_UNIT_UNIT { get; set; }
    }
}
