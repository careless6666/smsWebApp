namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CONTRACT_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_CONTRACT_ITEM()
        {
            CL_CONTRACT_ITEM1 = new HashSet<CL_CONTRACT_ITEM>();
            CL_RATE = new HashSet<CL_RATE>();
        }

        [Key]
        public int CCI_ID { get; set; }

        public int? CCI_MASTER_ID { get; set; }

        public int CON_ID { get; set; }

        public int CCWT_ID { get; set; }

        [StringLength(30)]
        public string CCI_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CCI_SUM { get; set; }

        public virtual CL_CONTRACT CL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT_ITEM> CL_CONTRACT_ITEM1 { get; set; }

        public virtual CL_CONTRACT_ITEM CL_CONTRACT_ITEM2 { get; set; }

        public virtual CL_CONTRACT_WORK_TYPE CL_CONTRACT_WORK_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_RATE> CL_RATE { get; set; }
    }
}
