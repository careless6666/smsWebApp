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
    
    public partial class INV_ITEM_LEGAL_ENTITY
    {
        public int IILE_ID { get; set; }
        public int INV_ITEM_ID { get; set; }
        public int LEOH_ID { get; set; }
    
        public virtual INV_ITEM INV_ITEM { get; set; }
        public virtual LE_OBLIGATION_HISTORY LE_OBLIGATION_HISTORY { get; set; }
    }
}
