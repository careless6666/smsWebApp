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
    
    public partial class CL_JURI_NAMES_EXTENSIONS
    {
        public decimal JrNmExtID { get; set; }
        public int JURI_NAME_ID { get; set; }
        public string DATA { get; set; }
        public string COMMENT { get; set; }
        public decimal CL_JURI_NAMES_EXTENSIONS_TYPE_ID { get; set; }
        public System.DateTime CL_DATE_CHANGE { get; set; }
        public decimal USER_ID { get; set; }
    
        public virtual CL_JURI_NAMES CL_JURI_NAMES { get; set; }
        public virtual CL_JURI_NAMES_EXTENSIONS_TYPE CL_JURI_NAMES_EXTENSIONS_TYPE { get; set; }
    }
}
