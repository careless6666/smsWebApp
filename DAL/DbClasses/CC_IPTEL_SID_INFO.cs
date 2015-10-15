namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_IPTEL_SID_INFO
    {
        [Key]
        [StringLength(222)]
        public string CISI_SID { get; set; }

        public bool CISI_PRESSED_PROLONGATION { get; set; }
    }
}
