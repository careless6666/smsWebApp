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
    
    public partial class CC_RECALL_TASK
    {
        public int CRT_ID { get; set; }
        public Nullable<decimal> CIT_ID { get; set; }
        public string CRT_COMMENT { get; set; }
        public Nullable<System.DateTime> CRT_RECALL_TIME { get; set; }
        public string CRT_RECALL_PHONE { get; set; }
        public Nullable<int> UN_ID { get; set; }
        public Nullable<int> WR_ID { get; set; }
        public int ID_SUBSCRIBER { get; set; }
    
        public virtual CC_IPTEL_TASKS CC_IPTEL_TASKS { get; set; }
    }
}
