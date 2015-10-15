namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CGNT_CONTRAGENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CGNT_CONTRAGENT()
        {
            CGNT_BILL = new HashSet<CGNT_BILL>();
            CL_CLIENTS_CONTRAGENT = new HashSet<CL_CLIENTS_CONTRAGENT>();
        }

        [Key]
        public int CGNT_ID { get; set; }

        [StringLength(511)]
        public string CGNT_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CGNT_INN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CGNT_KPP { get; set; }

        public Guid? CGNT_FIN_ID { get; set; }

        public int CUN_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CGNT_BILL> CGNT_BILL { get; set; }

        public virtual CGNT_FIN_UNIT CGNT_FIN_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS_CONTRAGENT> CL_CLIENTS_CONTRAGENT { get; set; }
    }
}
