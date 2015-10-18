namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WR_WAITING_FOR_FMS_RESPONSE
    {
        [Column(TypeName = "numeric")]
        public decimal UnId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal WrId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IdDocType { get; set; }

        public DateTime GeneratingDate { get; set; }

        public int Id { get; set; }

        public virtual OPT_DOCUMENT_TYPES OPT_DOCUMENT_TYPES { get; set; }

        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
