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
    
    public partial class CL_CLOSED_PERIODS
    {
        public decimal CLL_ID { get; set; }
        public decimal CLL_US_ID { get; set; }
        public System.DateTime CLL_DATETIME_CPERIOD { get; set; }
        public System.DateTime CLL_RCREATE_DATETIME { get; set; }
    
        public virtual SC_USERS SC_USERS { get; set; }
    }
}
