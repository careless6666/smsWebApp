namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CC_MANAGER_TASK_CANDIDATES
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int TASK_ID { get; set; }

        [Required]
        [StringLength(70)]
        public string FIO { get; set; }

        public bool SEX { get; set; }

        public DateTime BIRTH_DATE { get; set; }

        [Required]
        [StringLength(200)]
        public string COMMENT { get; set; }

        [Required]
        [StringLength(50)]
        public string TELEFON { get; set; }

        public bool IS_CALLED { get; set; }

        public int AGE { get; set; }

        public virtual CC_MANAGER_TASK CC_MANAGER_TASK { get; set; }
    }
}
