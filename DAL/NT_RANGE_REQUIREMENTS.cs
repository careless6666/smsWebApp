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
    
    public partial class NT_RANGE_REQUIREMENTS
    {
        public decimal NT_ID { get; set; }
        public int RR_ID { get; set; }
        public decimal UN_ID { get; set; }
        public Nullable<int> NT_RR_MIN { get; set; }
        public Nullable<int> NT_RR_MAX { get; set; }
    
        public virtual CL_NETS CL_NETS { get; set; }
        public virtual OPT_RANGE_REFERENCES OPT_RANGE_REFERENCES { get; set; }
        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
