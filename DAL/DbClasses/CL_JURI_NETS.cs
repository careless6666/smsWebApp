namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_JURI_NETS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_JURI_NETS()
        {
            CL_CONTRACT_WORK_TYPE = new HashSet<CL_CONTRACT_WORK_TYPE>();
        }

        public int? CLJN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NT_ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CJNN_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CONTRACT_WORK_TYPE> CL_CONTRACT_WORK_TYPE { get; set; }

        public virtual CL_JURI_NAMES CL_JURI_NAMES { get; set; }

        public virtual CL_NETS CL_NETS { get; set; }
    }
}
