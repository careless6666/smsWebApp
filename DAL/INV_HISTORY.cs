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
    
    public partial class INV_HISTORY
    {
        public int IIH_ID { get; set; }
        public int INV_ID { get; set; }
        public int STATUS_ID { get; set; }
        public System.DateTime EDIT_TIME { get; set; }
        public decimal US_ID { get; set; }
    
        public virtual INV_INVOICE INV_INVOICE { get; set; }
        public virtual OPT_STATUS OPT_STATUS { get; set; }
        public virtual SC_USERS SC_USERS { get; set; }
    }
}
