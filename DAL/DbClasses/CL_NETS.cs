namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CL_NETS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_NETS()
        {
            CL_CLIENTS = new HashSet<CL_CLIENTS>();
            CL_JURI_NETS = new HashSet<CL_JURI_NETS>();
            NT_BLACKLIST = new HashSet<NT_BLACKLIST>();
            NT_RANGE_REQUIREMENTS = new HashSet<NT_RANGE_REQUIREMENTS>();
            CL_NETS_DEPARTMENTS = new HashSet<CL_NETS_DEPARTMENTS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal NT_ID { get; set; }

        [StringLength(100)]
        public string NT_NAME { get; set; }

        public bool? NT_BY_DEFAULT { get; set; }

        public virtual CGN_BONUS_OPTIONS CGN_BONUS_OPTIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CLIENTS> CL_CLIENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_JURI_NETS> CL_JURI_NETS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NT_BLACKLIST> NT_BLACKLIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NT_RANGE_REQUIREMENTS> NT_RANGE_REQUIREMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_NETS_DEPARTMENTS> CL_NETS_DEPARTMENTS { get; set; }
    }
}
