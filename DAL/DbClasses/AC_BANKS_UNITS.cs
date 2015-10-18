namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AC_BANKS_UNITS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AC_BANKS_UNITS()
        {
            AC_BANKS_UNITS_ACTIONS = new HashSet<AC_BANKS_UNITS_ACTIONS>();
        }

        [Key]
        public int ABU_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AB_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal US_ID { get; set; }

        public DateTime ABU_EDIT_TIME { get; set; }

        public bool ABU_VISIBILITY { get; set; }

        public virtual AC_BANKS AC_BANKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_BANKS_UNITS_ACTIONS> AC_BANKS_UNITS_ACTIONS { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }

        public virtual SC_USERS SC_USERS { get; set; }
    }
}
