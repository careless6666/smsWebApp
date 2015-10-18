namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tmp_calc_worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tmp_calc_worker()
        {
            AC_ACCURAL = new HashSet<AC_ACCURAL>();
        }

        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WrId { get; set; }

        public int FileId { get; set; }

        public int CalcType { get; set; }

        public bool ShouldFire { get; set; }

        [Required]
        [StringLength(64)]
        public string State { get; set; }

        public virtual tmp_calc_file tmp_calc_file { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AC_ACCURAL> AC_ACCURAL { get; set; }
    }
}
