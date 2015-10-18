namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_REFERENCES_CHECK_SEQURITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_REFERENCES_CHECK_SEQURITY()
        {
            OPT_REFERENCES_UNIT = new HashSet<OPT_REFERENCES_UNIT>();
        }

        [Key]
        public int ORS_ID { get; set; }

        public bool IS_SHOULD_BE_CHECKED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPT_REFERENCES_UNIT> OPT_REFERENCES_UNIT { get; set; }
    }
}
