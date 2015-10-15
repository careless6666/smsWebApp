namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMS_TEMPLATES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMS_TEMPLATES()
        {
            SMS_SEND_CONDITIONS_PARAMS = new HashSet<SMS_SEND_CONDITIONS_PARAMS>();
            SMS_TEMPLATES_HISTORY = new HashSet<SMS_TEMPLATES_HISTORY>();
            SMS_TEMPLATES_PARAMS = new HashSet<SMS_TEMPLATES_PARAMS>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_SMS_EVENT { get; set; }

        public bool IS_SEND { get; set; }

        public string NAME { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string MESSAGE { get; set; }

        public bool IS_NEED_TRANSLIT { get; set; }

        public bool IS_DEFAULT { get; set; }

        public virtual OPT_SMS_EVENTS OPT_SMS_EVENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_SEND_CONDITIONS_PARAMS> SMS_SEND_CONDITIONS_PARAMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_TEMPLATES_HISTORY> SMS_TEMPLATES_HISTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMS_TEMPLATES_PARAMS> SMS_TEMPLATES_PARAMS { get; set; }
    }
}
