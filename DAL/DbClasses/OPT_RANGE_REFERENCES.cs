namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_RANGE_REFERENCES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_RANGE_REFERENCES()
        {
            CL_RANGE_REQUIREMENTS = new HashSet<CL_RANGE_REQUIREMENTS>();
            NT_RANGE_REQUIREMENTS = new HashSet<NT_RANGE_REQUIREMENTS>();
            OR_RANGE_REQUIREMENTS = new HashSet<OR_RANGE_REQUIREMENTS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RR_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string RR_NAME { get; set; }

        public int RR_VALUE { get; set; }

        public int? RR_MIN { get; set; }

        public int? RR_MAX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_RANGE_REQUIREMENTS> CL_RANGE_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NT_RANGE_REQUIREMENTS> NT_RANGE_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OR_RANGE_REQUIREMENTS> OR_RANGE_REQUIREMENTS { get; set; }
    }
}
