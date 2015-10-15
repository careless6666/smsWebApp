namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_REFERENCES_UNIT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORU_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal REF_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UN_ID { get; set; }

        public int RUS_ID { get; set; }

        public virtual OPT_REFERENCES OPT_REFERENCES { get; set; }

        public virtual OPT_REFERENCES_CHECK_SEQURITY OPT_REFERENCES_CHECK_SEQURITY { get; set; }

        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
