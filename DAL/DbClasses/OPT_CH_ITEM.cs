namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_CH_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPT_CH_ITEM()
        {
            WR_CH_CARD_ITEM = new HashSet<WR_CH_CARD_ITEM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CH_IT_ID { get; set; }

        public int? CH_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CH_IT_NAME { get; set; }

        public int CH_IT_VALUE { get; set; }

        public virtual OPT_CHARACTERISTIC OPT_CHARACTERISTIC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_CH_CARD_ITEM> WR_CH_CARD_ITEM { get; set; }
    }
}
