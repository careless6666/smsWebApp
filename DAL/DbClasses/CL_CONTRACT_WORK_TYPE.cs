namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_CONTRACT_WORK_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_CONTRACT_WORK_TYPE()
        {
            CL_CONTRACT_ITEM = new HashSet<CL_CONTRACT_ITEM>();
        }

        [Key]
        public int CCWT_ID { get; set; }

        public int CJNN_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string WT_NAME { get; set; }

        [Required]
        [StringLength(300)]
        public string CL_WT_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT_ITEM> CL_CONTRACT_ITEM { get; set; }

        public virtual CL_JURI_NETS CL_JURI_NETS { get; set; }

        public virtual OPT_WORK_TYPES OPT_WORK_TYPES { get; set; }
    }
}
