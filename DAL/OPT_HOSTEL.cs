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
    
    public partial class OPT_HOSTEL
    {
        public decimal ID { get; set; }
        public string NAME { get; set; }
        public decimal UN_ID { get; set; }
        public bool IS_MAIN { get; set; }
        public decimal ID_STATE_KLADR { get; set; }
        public decimal ID_REGION_KLADR { get; set; }
        public decimal ID_DISTRICT_KLADR { get; set; }
        public decimal ID_TOWN_KLADR { get; set; }
        public decimal ID_STREET_KLADR { get; set; }
        public string HOUSE_NUMBER { get; set; }
        public string COMMENT { get; set; }
        public Nullable<decimal> DAY_COST { get; set; }
    
        public virtual WR_KLADR WR_KLADR { get; set; }
        public virtual WR_KLADR WR_KLADR1 { get; set; }
        public virtual WR_KLADR_COUNTRIES WR_KLADR_COUNTRIES { get; set; }
        public virtual WR_KLADR WR_KLADR2 { get; set; }
        public virtual WR_KLADR WR_KLADR3 { get; set; }
        public virtual SC_UNIT SC_UNIT { get; set; }
    }
}
