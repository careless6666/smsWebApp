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
    
    public partial class AC_ACCRUAL_ORDER
    {
        public int ACCRUAL_ORDER_ID { get; set; }
        public int OOWH_ID { get; set; }
        public decimal ACC_ID { get; set; }
    
        public virtual AC_ACCURAL AC_ACCURAL { get; set; }
        public virtual OR_ORDER_WORKER_HISTORY OR_ORDER_WORKER_HISTORY { get; set; }
    }
}
