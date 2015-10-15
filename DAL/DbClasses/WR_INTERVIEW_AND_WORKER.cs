namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_INTERVIEW_AND_WORKER
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdInterview { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IdTempProfile { get; set; }

        public bool IsCurrent { get; set; }

        public virtual WR_INTERVIEW WR_INTERVIEW { get; set; }

        public virtual WR_TEMP_PROFILES WR_TEMP_PROFILES { get; set; }
    }
}
