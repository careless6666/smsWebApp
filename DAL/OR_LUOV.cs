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
    
    public partial class OR_LUOV
    {
        public decimal OR_ID { get; set; }
        public string ORL_FILENAME { get; set; }
        public byte[] ORL_CONTENT { get; set; }
        public Nullable<decimal> ORL_USER_SUBMITTED { get; set; }
        public Nullable<System.DateTime> ORL_SUBMITTED_TIME { get; set; }
        public bool ORL_MARK_DELETED { get; set; }
    
        public virtual OR_ORDER OR_ORDER { get; set; }
        public virtual SC_USERS SC_USERS { get; set; }
    }
}
