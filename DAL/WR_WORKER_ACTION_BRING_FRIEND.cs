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
    
    public partial class WR_WORKER_ACTION_BRING_FRIEND
    {
        public int WWABF_ID { get; set; }
        public decimal FRIEND_UN_ID { get; set; }
        public decimal FRIEND_WR_ID { get; set; }
        public int WWAP_ID { get; set; }
    
        public virtual WR_WORKER_ACTION_PAYMENTS WR_WORKER_ACTION_PAYMENTS { get; set; }
        public virtual WR_WORKERS WR_WORKERS { get; set; }
    }
}
