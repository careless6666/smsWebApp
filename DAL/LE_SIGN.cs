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
    
    public partial class LE_SIGN
    {
        public int LE_SIGN_ID { get; set; }
        public int CLJN_ID { get; set; }
        public decimal UN_ID { get; set; }
        public int INV_SIGN_TYPE_ID { get; set; }
        public string NAME { get; set; }
    
        public virtual CL_JURI_NAMES CL_JURI_NAMES { get; set; }
        public virtual INV_SIGN_TYPE INV_SIGN_TYPE { get; set; }
        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
