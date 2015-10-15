namespace DAL.DbClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPT_OPTIONS
    {
        [Column(TypeName = "numeric")]
        public decimal? DEFAULT_STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MIN_DAYS_IN_CALC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? START_NUM_WORKERS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? START_NUM_USERS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? START_NUM_CLIENTS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COUNT_NUM_UNIT_IN_BAGE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COUNT_NUM_ID_IN_BAGE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FILTER_DEF_COUNT_DAYS_WORKING_FROM_START { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FILTER_DEF_COUNT_DAYS_WORKING_TO_START { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FILTER_DEF_COUNT_DAYS_FROM_INSERT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DEFAULT_CALL_AFTER_MINUTES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAX_CALL_AFTER_MON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAX_UPPER_WORK_PERS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PAY_FOR_FRIEND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COUNT_ORDERS_BY_FRIEND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BONUS_RECRUTER_BY_HOUR { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal MIN_REST { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal PASSWORD_EXPIRE_DAYS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2048)]
        public string SMS_ACTION_BRINGFRIEND_2012 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2048)]
        public string SMS_ACTION_20x100 { get; set; }

        [Column(TypeName = "text")]
        public string COVER_MAIL_TEMPLATE { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "text")]
        public string INV_STATUS_MAIL_BODY_TEMPLATE { get; set; }

        public virtual OPT_STATUSES OPT_STATUSES { get; set; }
    }
}
