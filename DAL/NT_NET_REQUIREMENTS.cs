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
    
    public partial class NT_NET_REQUIREMENTS
    {
        public decimal NT_ID { get; set; }
        public decimal OREQ_TYPE { get; set; }
        public decimal REF_ID { get; set; }
        public decimal UN_ID { get; set; }
    
        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
