//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class WR_CARDS_ROSEURO
    {
        public decimal UN_ID { get; set; }
        public decimal WR_ID { get; set; }
        public string WR_CARDNUM { get; set; }
        public bool WR_CARDISSUED { get; set; }
        public string WR_CARD_ACCOUNT_NUMBER { get; set; }
        public decimal WC_BANK_ID { get; set; }
        public string WCR_ID_CARD { get; set; }
        public bool WCR_IS_SENT { get; set; }
        public Nullable<System.DateTime> CARD_APPLIED_DATE { get; set; }
        public Nullable<System.DateTime> CARD_ISSUED_DATE { get; set; }
    
        public virtual AC_BANKS AC_BANKS { get; set; }
    }
}
