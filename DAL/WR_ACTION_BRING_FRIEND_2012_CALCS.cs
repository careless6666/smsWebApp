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
    
    public partial class WR_ACTION_BRING_FRIEND_2012_CALCS
    {
        public decimal WABF_ID { get; set; }
        public decimal UN_ID { get; set; }
        public decimal WR_ID { get; set; }
        public decimal FUN_ID { get; set; }
        public decimal FWR_ID { get; set; }
        public decimal WABF_SUM { get; set; }
    
        public virtual WR_WORKERS WR_WORKERS { get; set; }
        public virtual WR_WORKERS WR_WORKERS1 { get; set; }
    }
}
