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
    
    public partial class AC_ACCRUALS_WORKER_ACTION_PAYMENTS
    {
        public int AAWAP_ID { get; set; }
        public decimal ACC_ID { get; set; }
        public int WWAPH_ID { get; set; }
    
        public virtual WR_WORKER_ACTION_PAYMENTS_HISTORY WR_WORKER_ACTION_PAYMENTS_HISTORY { get; set; }
        public virtual AC_ACCURAL AC_ACCURAL { get; set; }
    }
}
